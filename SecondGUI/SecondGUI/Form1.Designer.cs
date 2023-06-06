namespace SecondGUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labePassword = new System.Windows.Forms.Label();
            this.labelFogottenpassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picShowPassword = new System.Windows.Forms.PictureBox();
            this.picHidePassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // texBoxUsername
            // 
            this.texBoxUsername.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texBoxUsername.Location = new System.Drawing.Point(361, 187);
            this.texBoxUsername.Name = "texBoxUsername";
            this.texBoxUsername.Size = new System.Drawing.Size(200, 31);
            this.texBoxUsername.TabIndex = 2;
            this.texBoxUsername.Tag = "";
            this.texBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texBoxUsername_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(361, 233);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(200, 31);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(231, 195);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(114, 23);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "UserName";
            // 
            // labePassword
            // 
            this.labePassword.AutoSize = true;
            this.labePassword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labePassword.Location = new System.Drawing.Point(231, 241);
            this.labePassword.Name = "labePassword";
            this.labePassword.Size = new System.Drawing.Size(105, 23);
            this.labePassword.TabIndex = 5;
            this.labePassword.Text = "Password";
            // 
            // labelFogottenpassword
            // 
            this.labelFogottenpassword.AutoSize = true;
            this.labelFogottenpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFogottenpassword.ForeColor = System.Drawing.Color.Red;
            this.labelFogottenpassword.Location = new System.Drawing.Point(475, 267);
            this.labelFogottenpassword.Name = "labelFogottenpassword";
            this.labelFogottenpassword.Size = new System.Drawing.Size(86, 13);
            this.labelFogottenpassword.TabIndex = 6;
            this.labelFogottenpassword.Text = "Forget Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(361, 292);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(200, 51);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecondGUI.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(183, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picShowPassword
            // 
            this.picShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowPassword.Image = global::SecondGUI.Properties.Resources.show_hide_password_03_512;
            this.picShowPassword.Location = new System.Drawing.Point(624, 267);
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.Size = new System.Drawing.Size(27, 23);
            this.picShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowPassword.TabIndex = 8;
            this.picShowPassword.TabStop = false;
            this.picShowPassword.Click += new System.EventHandler(this.picShowPassword_Click);
            // 
            // picHidePassword
            // 
            this.picHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHidePassword.Image = global::SecondGUI.Properties.Resources.show_hide_password_10_512;
            this.picHidePassword.Location = new System.Drawing.Point(606, 219);
            this.picHidePassword.Name = "picHidePassword";
            this.picHidePassword.Size = new System.Drawing.Size(27, 23);
            this.picHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHidePassword.TabIndex = 9;
            this.picHidePassword.TabStop = false;
            this.picHidePassword.Click += new System.EventHandler(this.picHidePassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picHidePassword);
            this.Controls.Add(this.picShowPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelFogottenpassword);
            this.Controls.Add(this.labePassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.texBoxUsername);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "FastLoginPage";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox texBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labePassword;
        private System.Windows.Forms.Label labelFogottenpassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox picShowPassword;
        private System.Windows.Forms.PictureBox picHidePassword;
    }
}

