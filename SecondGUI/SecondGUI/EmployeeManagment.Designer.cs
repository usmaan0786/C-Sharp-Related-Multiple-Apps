namespace SecondGUI
{
    partial class EmployeeManagment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvRecords = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDateOfJoining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailRecordsDataSet3 = new SecondGUI.EmailRecordsDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtPosition = new System.Windows.Forms.TextBox();
            this.DateJoining = new System.Windows.Forms.DateTimePicker();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new SecondGUI.EmailRecordsDataSet3TableAdapters.EmployeeTableAdapter();
            this.ComboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emailRecordsDataSet5 = new SecondGUI.EmailRecordsDataSet5();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailRecordsDataSet4 = new SecondGUI.EmailRecordsDataSet4();
            this.departmentTableAdapter = new SecondGUI.EmailRecordsDataSet4TableAdapters.DepartmentTableAdapter();
            this.departmentTableAdapter1 = new SecondGUI.EmailRecordsDataSet5TableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailRecordsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailRecordsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailRecordsDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRecords
            // 
            this.DgvRecords.AllowUserToAddRows = false;
            this.DgvRecords.AllowUserToResizeColumns = false;
            this.DgvRecords.AllowUserToResizeRows = false;
            this.DgvRecords.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.UserName,
            this.EmpDepartment,
            this.EmpPosition,
            this.EmpDateOfJoining,
            this.Password,
            this.LoginID,
            this.EmpPhoto});
            this.DgvRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvRecords.Location = new System.Drawing.Point(23, 293);
            this.DgvRecords.Name = "DgvRecords";
            this.DgvRecords.ReadOnly = true;
            this.DgvRecords.RowHeadersVisible = false;
            this.DgvRecords.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRecords.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.DgvRecords.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.DgvRecords.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRecords.RowTemplate.Height = 50;
            this.DgvRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRecords.Size = new System.Drawing.Size(762, 218);
            this.DgvRecords.TabIndex = 41;
            this.DgvRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRecords_CellClick);
            this.DgvRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRecords_CellContentClick);
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // EmpDepartment
            // 
            this.EmpDepartment.HeaderText = "Department";
            this.EmpDepartment.Name = "EmpDepartment";
            this.EmpDepartment.ReadOnly = true;
            this.EmpDepartment.Width = 120;
            // 
            // EmpPosition
            // 
            this.EmpPosition.HeaderText = "Position";
            this.EmpPosition.Name = "EmpPosition";
            this.EmpPosition.ReadOnly = true;
            // 
            // EmpDateOfJoining
            // 
            this.EmpDateOfJoining.HeaderText = "Date of Joining";
            this.EmpDateOfJoining.Name = "EmpDateOfJoining";
            this.EmpDateOfJoining.ReadOnly = true;
            this.EmpDateOfJoining.Width = 160;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // LoginID
            // 
            this.LoginID.HeaderText = "loginID";
            this.LoginID.Name = "LoginID";
            this.LoginID.ReadOnly = true;
            this.LoginID.Visible = false;
            // 
            // EmpPhoto
            // 
            this.EmpPhoto.HeaderText = "EmpPhoto";
            this.EmpPhoto.Name = "EmpPhoto";
            this.EmpPhoto.ReadOnly = true;
            this.EmpPhoto.Visible = false;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.emailRecordsDataSet3;
            // 
            // emailRecordsDataSet3
            // 
            this.emailRecordsDataSet3.DataSetName = "EmailRecordsDataSet3";
            this.emailRecordsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(241, 9);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(199, 32);
            this.TxtName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Confirm Password:";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmPassword.Location = new System.Drawing.Point(241, 112);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(199, 32);
            this.TxtConfirmPassword.TabIndex = 36;
            this.TxtConfirmPassword.TextChanged += new System.EventHandler(this.TxtConfirmPassword_TextChanged);
            this.TxtConfirmPassword.Leave += new System.EventHandler(this.TxtConfirmPassword_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Department:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(241, 77);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(199, 32);
            this.TxtPassword.TabIndex = 32;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(241, 43);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(199, 32);
            this.TxtUserName.TabIndex = 30;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(692, 169);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(93, 72);
            this.BtnUpdate.TabIndex = 54;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(692, 91);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(93, 72);
            this.BtnDelete.TabIndex = 53;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(692, 11);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 72);
            this.BtnAdd.TabIndex = 52;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Position:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "User Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "Joining Date:";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackColor = System.Drawing.Color.Silver;
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBrowse.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Location = new System.Drawing.Point(521, 181);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(137, 34);
            this.BtnBrowse.TabIndex = 56;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.button4_Click);
            // 
            // TxtPosition
            // 
            this.TxtPosition.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPosition.Location = new System.Drawing.Point(241, 181);
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(199, 32);
            this.TxtPosition.TabIndex = 58;
            this.TxtPosition.Text = "Students";
            // 
            // DateJoining
            // 
            this.DateJoining.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateJoining.Location = new System.Drawing.Point(250, 221);
            this.DateJoining.Name = "DateJoining";
            this.DateJoining.Size = new System.Drawing.Size(172, 22);
            this.DateJoining.TabIndex = 59;
            // 
            // PicUser
            // 
            this.PicUser.Image = global::SecondGUI.Properties.Resources.No_Image;
            this.PicUser.Location = new System.Drawing.Point(497, 9);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(161, 165);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUser.TabIndex = 55;
            this.PicUser.TabStop = false;
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpID.Location = new System.Drawing.Point(241, 245);
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.Size = new System.Drawing.Size(199, 32);
            this.TxtEmpID.TabIndex = 60;
            this.TxtEmpID.TextChanged += new System.EventHandler(this.TxtEmpID_TextChanged);
          //  this.TxtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Emp ID:";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // ComboBoxDepartment
            // 
            this.ComboBoxDepartment.DataSource = this.departmentBindingSource1;
            this.ComboBoxDepartment.DisplayMember = "DptName";
            this.ComboBoxDepartment.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDepartment.FormattingEnabled = true;
            this.ComboBoxDepartment.Location = new System.Drawing.Point(241, 147);
            this.ComboBoxDepartment.Name = "ComboBoxDepartment";
            this.ComboBoxDepartment.Size = new System.Drawing.Size(199, 31);
            this.ComboBoxDepartment.TabIndex = 62;
            this.ComboBoxDepartment.ValueMember = "DptID";
            this.ComboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDepartment_SelectedIndexChanged);
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.emailRecordsDataSet5;
            // 
            // emailRecordsDataSet5
            // 
            this.emailRecordsDataSet5.DataSetName = "EmailRecordsDataSet5";
            this.emailRecordsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.emailRecordsDataSet4;
            // 
            // emailRecordsDataSet4
            // 
            this.emailRecordsDataSet4.DataSetName = "EmailRecordsDataSet4";
            this.emailRecordsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            // 
            // EmployeeManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 523);
            this.Controls.Add(this.ComboBoxDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtEmpID);
            this.Controls.Add(this.DateJoining);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.PicUser);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Name = "EmployeeManagment";
            this.Text = "EmployeeManagment";
            this.Load += new System.EventHandler(this.EmployeeManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailRecordsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailRecordsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailRecordsDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtPosition;
        private System.Windows.Forms.DateTimePicker DateJoining;
        private System.Windows.Forms.TextBox TxtEmpID;
        private System.Windows.Forms.Label label2;
        private EmailRecordsDataSet3 emailRecordsDataSet3;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmailRecordsDataSet3TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ComboBox ComboBoxDepartment;
        private EmailRecordsDataSet4 emailRecordsDataSet4;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private EmailRecordsDataSet4TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDateOfJoining;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginID;
        private EmailRecordsDataSet5 emailRecordsDataSet5;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private EmailRecordsDataSet5TableAdapters.DepartmentTableAdapter departmentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPhoto;
    }
}