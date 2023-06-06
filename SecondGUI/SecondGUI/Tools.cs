using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SecondGUI
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicBox_Font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = this.Txt_Message.Font;
            DialogResult result = fontDialog1.ShowDialog();
            //See if Ok was pressed.
            if(result == DialogResult.OK)
            {
                // Get Font
                Font font = fontDialog1.Font;
                Color color = fontDialog1.Color;
                // Set TextBox Prpoerties.
                this.Txt_Message.SelectionFont = font;
                this.Txt_Message.SelectionColor = color;
            }
        }

        //Send Email From c#
        private void SendEmail(string sMTP_Gmail)
        {
            try
            {
                string password = Txt_AppCode.Text;
                NetworkCredential login = new NetworkCredential(Txt_From.Text, password);
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
                    From = new MailAddress(Txt_From.Text, Txt_DisplayName.Text.Trim(), Encoding.UTF8)
                };
                msg.To.Add(new MailAddress(Txt_ToEmail.Text.Trim()));


                msg.Subject = Txt_Subject.Text.Trim();
                msg.Body = Txt_Message.Text;
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

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //Check internet in c#
        // Check Internet Connection 
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        private void Btn_SendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if(Txt_From.Text != string.Empty && Txt_Subject.Text != string.Empty &&
                    Txt_DisplayName.Text != "" && Txt_Subject.Text != string.Empty && Txt_ToEmail.Text != string.Empty)
                {
                    if (CheckNet())
                    {
                        if (Rdo_Gmail.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_Gmail);
                        else if (Rdo_Hotmail.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_Hotmail);
                        else if (Rdo_Outlook.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_OutLook);
                        else if (Rdo_Yahoo.Checked)
                            SendEmail(Properties.Settings.Default.SMTP_Yahoo);
                    }
                    else
                    {
                        MessageBox.Show("Please check your internet", "No Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    tabControl1.SelectTab(0);
                    MessageBox.Show("Following fields are required "
                        + Environment.NewLine + "1 .From Email"
                        + Environment.NewLine + "2. App Code"
                        + Environment.NewLine + "3. Display Name"
                        + Environment.NewLine + "4. Subject"
                        + Environment.NewLine + "5. To Email"
                        , "Field required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Tools_Load(object sender, EventArgs e)
        {
            Txt_From.Text = Properties.Settings.Default.FromEmail;
            //Txt_AppCode.Text = Properties.Settings.Default.FromCode;
            Txt_ToEmail.Text = Properties.Settings.Default.TOEmail;
        }

        private void Txt_AppCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
