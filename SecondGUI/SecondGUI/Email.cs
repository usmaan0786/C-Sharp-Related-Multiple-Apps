using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondGUI
{
    public partial class Email : Form
    {
        private object mailCount;
        private object listBox2;
        static SqlReader sqlReader;
        static SqlCommand sqlCommand;
        static SqlDataAdapter sqlDataAdaptor;
        static DataSet dataSet;
        static SqlTransaction sqlTransaction;


        public string HtmlTextBody { get; private set; }
        public object OpenDBConnection { get; private set; }

        public Email()
        {
            InitializeComponent();
        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send Cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            //if (mailCount == listBox2.Items.Count)
            {
                MessageBox.Show("The extracted emails has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            { 
                string password = textBoxAppCode.Text;
                NetworkCredential login = new NetworkCredential(TextBoxFromEmail.Text, password);
                string stmp = "smtp.gmail.com";
                SmtpClient client = new SmtpClient(stmp)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = login,
                    Port = 587
                };
                MailMessage msg = new MailMessage
                {
                    From = new MailAddress(TextBoxFromEmail.Text, textBoxDisplayName.Text.Trim(), Encoding.UTF8)
                };
                msg.To.Add(new MailAddress(textBoxToEmail.Text.Trim()));


                msg.Subject = textBoxSubject.Text.Trim();
                msg.Body = textBoxMessage.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;

                msg.Priority = MailPriority.High;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";

                client.SendAsync(msg, userstate);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
