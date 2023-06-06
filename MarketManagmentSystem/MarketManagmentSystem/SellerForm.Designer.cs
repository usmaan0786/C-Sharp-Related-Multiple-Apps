namespace MarketManagmentSystem
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSellerEdit = new System.Windows.Forms.Button();
            this.btnSellerDelete = new System.Windows.Forms.Button();
            this.dgvManagesSellers = new System.Windows.Forms.DataGridView();
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketManagmentDataSet12 = new MarketManagmentSystem.MarketManagmentDataSet12();
            this.btnSellerAdd = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.sellerTableAdapter = new MarketManagmentSystem.MarketManagmentDataSet12TableAdapters.SellerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagesSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSellerEdit);
            this.panel1.Controls.Add(this.btnSellerDelete);
            this.panel1.Controls.Add(this.dgvManagesSellers);
            this.panel1.Controls.Add(this.btnSellerAdd);
            this.panel1.Controls.Add(this.btnManageProducts);
            this.panel1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(160, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 664);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 39);
            this.label3.TabIndex = 75;
            this.label3.Text = "Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 39);
            this.label2.TabIndex = 74;
            this.label2.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 73;
            this.label1.Text = "Add";
            // 
            // btnSellerEdit
            // 
            this.btnSellerEdit.AutoEllipsis = true;
            this.btnSellerEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSellerEdit.FlatAppearance.BorderSize = 0;
            this.btnSellerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellerEdit.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnSellerEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSellerEdit.Location = new System.Drawing.Point(31, 310);
            this.btnSellerEdit.Name = "btnSellerEdit";
            this.btnSellerEdit.Size = new System.Drawing.Size(103, 29);
            this.btnSellerEdit.TabIndex = 72;
            this.btnSellerEdit.Text = "Click here";
            this.btnSellerEdit.UseVisualStyleBackColor = false;
            this.btnSellerEdit.Click += new System.EventHandler(this.btnSellerEdit_Click);
            // 
            // btnSellerDelete
            // 
            this.btnSellerDelete.AutoEllipsis = true;
            this.btnSellerDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSellerDelete.FlatAppearance.BorderSize = 0;
            this.btnSellerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellerDelete.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnSellerDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSellerDelete.Location = new System.Drawing.Point(31, 412);
            this.btnSellerDelete.Name = "btnSellerDelete";
            this.btnSellerDelete.Size = new System.Drawing.Size(103, 29);
            this.btnSellerDelete.TabIndex = 71;
            this.btnSellerDelete.Text = "Click here";
            this.btnSellerDelete.UseVisualStyleBackColor = false;
            this.btnSellerDelete.Click += new System.EventHandler(this.btnSellerDelete_Click);
            // 
            // dgvManagesSellers
            // 
            this.dgvManagesSellers.AllowUserToAddRows = false;
            this.dgvManagesSellers.AllowUserToResizeColumns = false;
            this.dgvManagesSellers.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagesSellers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagesSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagesSellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerIDDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.sellerAgeDataGridViewTextBoxColumn,
            this.sellerPhoneDataGridViewTextBoxColumn,
            this.sellerPasswordDataGridViewTextBoxColumn});
            this.dgvManagesSellers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvManagesSellers.DataSource = this.sellerBindingSource;
            this.dgvManagesSellers.Location = new System.Drawing.Point(359, 148);
            this.dgvManagesSellers.Name = "dgvManagesSellers";
            this.dgvManagesSellers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagesSellers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManagesSellers.RowHeadersVisible = false;
            this.dgvManagesSellers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManagesSellers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvManagesSellers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvManagesSellers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvManagesSellers.RowTemplate.Height = 35;
            this.dgvManagesSellers.Size = new System.Drawing.Size(678, 499);
            this.dgvManagesSellers.TabIndex = 45;
            // 
            // sellerIDDataGridViewTextBoxColumn
            // 
            this.sellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.HeaderText = "Seller ID";
            this.sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
            this.sellerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerIDDataGridViewTextBoxColumn.Width = 140;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "Seller Name";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            this.sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sellerAgeDataGridViewTextBoxColumn
            // 
            this.sellerAgeDataGridViewTextBoxColumn.DataPropertyName = "SellerAge";
            this.sellerAgeDataGridViewTextBoxColumn.HeaderText = "Age";
            this.sellerAgeDataGridViewTextBoxColumn.Name = "sellerAgeDataGridViewTextBoxColumn";
            this.sellerAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerAgeDataGridViewTextBoxColumn.Width = 90;
            // 
            // sellerPhoneDataGridViewTextBoxColumn
            // 
            this.sellerPhoneDataGridViewTextBoxColumn.DataPropertyName = "SellerPhone";
            this.sellerPhoneDataGridViewTextBoxColumn.HeaderText = "Phone no";
            this.sellerPhoneDataGridViewTextBoxColumn.Name = "sellerPhoneDataGridViewTextBoxColumn";
            this.sellerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerPhoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // sellerPasswordDataGridViewTextBoxColumn
            // 
            this.sellerPasswordDataGridViewTextBoxColumn.DataPropertyName = "SellerPassword";
            this.sellerPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.sellerPasswordDataGridViewTextBoxColumn.Name = "sellerPasswordDataGridViewTextBoxColumn";
            this.sellerPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerPasswordDataGridViewTextBoxColumn.Width = 180;
            // 
            // sellerBindingSource
            // 
            this.sellerBindingSource.DataMember = "Seller";
            this.sellerBindingSource.DataSource = this.marketManagmentDataSet12;
            // 
            // marketManagmentDataSet12
            // 
            this.marketManagmentDataSet12.DataSetName = "MarketManagmentDataSet12";
            this.marketManagmentDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSellerAdd
            // 
            this.btnSellerAdd.AutoEllipsis = true;
            this.btnSellerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSellerAdd.FlatAppearance.BorderSize = 0;
            this.btnSellerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellerAdd.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnSellerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSellerAdd.Location = new System.Drawing.Point(31, 212);
            this.btnSellerAdd.Name = "btnSellerAdd";
            this.btnSellerAdd.Size = new System.Drawing.Size(103, 29);
            this.btnSellerAdd.TabIndex = 42;
            this.btnSellerAdd.Text = "Click here";
            this.btnSellerAdd.UseVisualStyleBackColor = false;
            this.btnSellerAdd.Click += new System.EventHandler(this.btnSellerAdd_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.AutoEllipsis = true;
            this.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageProducts.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.ForeColor = System.Drawing.Color.DimGray;
            this.btnManageProducts.Location = new System.Drawing.Point(407, 24);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(283, 54);
            this.btnManageProducts.TabIndex = 19;
            this.btnManageProducts.Text = "Manage Sellers";
            this.btnManageProducts.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1195, -10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.AutoEllipsis = true;
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategory.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategory.Location = new System.Drawing.Point(12, 115);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(142, 54);
            this.btnCategory.TabIndex = 24;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.AutoEllipsis = true;
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelling.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.DimGray;
            this.btnSelling.Location = new System.Drawing.Point(12, 175);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(121, 54);
            this.btnSelling.TabIndex = 23;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.AutoEllipsis = true;
            this.btnSeller.BackColor = System.Drawing.Color.White;
            this.btnSeller.FlatAppearance.BorderSize = 0;
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeller.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeller.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSeller.Location = new System.Drawing.Point(12, 55);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(121, 54);
            this.btnSeller.TabIndex = 22;
            this.btnSeller.Text = "Products";
            this.btnSeller.UseVisualStyleBackColor = false;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // sellerTableAdapter
            // 
            this.sellerTableAdapter.ClearBeforeFill = true;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 688);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagesSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvManagesSellers;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnSeller;
        private MarketManagmentDataSet12 marketManagmentDataSet12;
        private System.Windows.Forms.BindingSource sellerBindingSource;
        private MarketManagmentDataSet12TableAdapters.SellerTableAdapter sellerTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSellerEdit;
        private System.Windows.Forms.Button btnSellerDelete;
        private System.Windows.Forms.Button btnSellerAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerPasswordDataGridViewTextBoxColumn;
    }
}