namespace MarketManagmentSystem
{
    partial class CategoryForm
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
            this.btnCatEdit = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.dgvManageCategories = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketManagmentDataSet8 = new MarketManagmentSystem.MarketManagmentDataSet8();
            this.button4 = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.categoriesTableTableAdapter = new MarketManagmentSystem.MarketManagmentDataSet8TableAdapters.CategoriesTableTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCatEdit);
            this.panel1.Controls.Add(this.btnCatDelete);
            this.panel1.Controls.Add(this.btnCatAdd);
            this.panel1.Controls.Add(this.dgvManageCategories);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnManageProducts);
            this.panel1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(160, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 662);
            this.panel1.TabIndex = 25;
      //      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.//panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 39);
            this.label3.TabIndex = 63;
            this.label3.Text = "Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 39);
            this.label2.TabIndex = 62;
            this.label2.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 61;
            this.label1.Text = "Add";
            // 
            // btnCatEdit
            // 
            this.btnCatEdit.AutoEllipsis = true;
            this.btnCatEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCatEdit.FlatAppearance.BorderSize = 0;
            this.btnCatEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatEdit.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnCatEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCatEdit.Location = new System.Drawing.Point(41, 340);
            this.btnCatEdit.Name = "btnCatEdit";
            this.btnCatEdit.Size = new System.Drawing.Size(103, 29);
            this.btnCatEdit.TabIndex = 60;
            this.btnCatEdit.Text = "Click here";
            this.btnCatEdit.UseVisualStyleBackColor = false;
            this.btnCatEdit.Click += new System.EventHandler(this.btnCatEdit_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.AutoEllipsis = true;
            this.btnCatDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCatDelete.FlatAppearance.BorderSize = 0;
            this.btnCatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatDelete.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnCatDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCatDelete.Location = new System.Drawing.Point(41, 442);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(103, 29);
            this.btnCatDelete.TabIndex = 59;
            this.btnCatDelete.Text = "Click here";
            this.btnCatDelete.UseVisualStyleBackColor = false;
            this.btnCatDelete.Click += new System.EventHandler(this.btnCatDelete_Click);
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.AutoEllipsis = true;
            this.btnCatAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCatAdd.FlatAppearance.BorderSize = 0;
            this.btnCatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatAdd.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCatAdd.Location = new System.Drawing.Point(41, 239);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(103, 28);
            this.btnCatAdd.TabIndex = 58;
            this.btnCatAdd.Text = "Click here";
            this.btnCatAdd.UseVisualStyleBackColor = false;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // dgvManageCategories
            // 
            this.dgvManageCategories.AllowUserToAddRows = false;
            this.dgvManageCategories.AllowUserToResizeColumns = false;
            this.dgvManageCategories.AllowUserToResizeRows = false;
            this.dgvManageCategories.AutoGenerateColumns = false;
            this.dgvManageCategories.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvManageCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.catNameDataGridViewTextBoxColumn,
            this.catDescriptionDataGridViewTextBoxColumn});
            this.dgvManageCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvManageCategories.DataSource = this.categoriesTableBindingSource;
            this.dgvManageCategories.GridColor = System.Drawing.Color.White;
            this.dgvManageCategories.Location = new System.Drawing.Point(254, 148);
            this.dgvManageCategories.Name = "dgvManageCategories";
            this.dgvManageCategories.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageCategories.RowHeadersVisible = false;
            this.dgvManageCategories.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvManageCategories.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManageCategories.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvManageCategories.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvManageCategories.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvManageCategories.RowTemplate.Height = 35;
            this.dgvManageCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvManageCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageCategories.Size = new System.Drawing.Size(795, 499);
            this.dgvManageCategories.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CatID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // catNameDataGridViewTextBoxColumn
            // 
            this.catNameDataGridViewTextBoxColumn.DataPropertyName = "CatName";
            this.catNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.catNameDataGridViewTextBoxColumn.Name = "catNameDataGridViewTextBoxColumn";
            this.catNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.catNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // catDescriptionDataGridViewTextBoxColumn
            // 
            this.catDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CatDescription";
            this.catDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.catDescriptionDataGridViewTextBoxColumn.Name = "catDescriptionDataGridViewTextBoxColumn";
            this.catDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.catDescriptionDataGridViewTextBoxColumn.Width = 550;
            // 
            // categoriesTableBindingSource
            // 
            this.categoriesTableBindingSource.DataMember = "CategoriesTable";
            this.categoriesTableBindingSource.DataSource = this.marketManagmentDataSet8;
            // 
            // marketManagmentDataSet8
            // 
            this.marketManagmentDataSet8.DataSetName = "MarketManagmentDataSet8";
            this.marketManagmentDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1179, -10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 34);
            this.button4.TabIndex = 29;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.AutoEllipsis = true;
            this.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageProducts.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.ForeColor = System.Drawing.Color.DimGray;
            this.btnManageProducts.Location = new System.Drawing.Point(338, 24);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(283, 54);
            this.btnManageProducts.TabIndex = 19;
            this.btnManageProducts.Text = "Manage Categories";
            this.btnManageProducts.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1195, -10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.AutoEllipsis = true;
            this.btnSellers.BackColor = System.Drawing.Color.White;
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellers.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellers.ForeColor = System.Drawing.Color.DimGray;
            this.btnSellers.Location = new System.Drawing.Point(12, 55);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(121, 52);
            this.btnSellers.TabIndex = 29;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.AutoEllipsis = true;
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelling.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.DimGray;
            this.btnSelling.Location = new System.Drawing.Point(12, 173);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(121, 54);
            this.btnSelling.TabIndex = 28;
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
            this.btnSeller.Location = new System.Drawing.Point(12, 113);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(121, 54);
            this.btnSeller.TabIndex = 27;
            this.btnSeller.Text = "Products";
            this.btnSeller.UseVisualStyleBackColor = false;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // categoriesTableTableAdapter
            // 
            this.categoriesTableTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 688);
            this.Controls.Add(this.btnSellers);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartegoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.DataGridView dgvManageCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCatEdit;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.Button btnCatAdd;
        private MarketManagmentDataSet8 marketManagmentDataSet8;
        private System.Windows.Forms.BindingSource categoriesTableBindingSource;
        private MarketManagmentDataSet8TableAdapters.CategoriesTableTableAdapter categoriesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catDescriptionDataGridViewTextBoxColumn;
    }
}