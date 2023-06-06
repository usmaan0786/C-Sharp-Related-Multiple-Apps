
namespace MarketManagmentSystem
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.dgvManageProducts = new System.Windows.Forms.DataGridView();
            this.prodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketManagmentDataSet9 = new MarketManagmentSystem.MarketManagmentDataSet9();
            this.comboBoxProdSelectCategory = new System.Windows.Forms.ComboBox();
            this.btnProdRefresh = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.productTableAdapter = new MarketManagmentSystem.MarketManagmentDataSet9TableAdapters.ProductTableAdapter();
            this.marketManagmentDataSet19 = new MarketManagmentSystem.MarketManagmentDataSet19();
            this.categoriesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableTableAdapter = new MarketManagmentSystem.MarketManagmentDataSet19TableAdapters.CategoriesTableTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnProductEdit);
            this.panel1.Controls.Add(this.btnProductDelete);
            this.panel1.Controls.Add(this.btnProductAdd);
            this.panel1.Controls.Add(this.dgvManageProducts);
            this.panel1.Controls.Add(this.comboBoxProdSelectCategory);
            this.panel1.Controls.Add(this.btnProdRefresh);
            this.panel1.Controls.Add(this.btnManageProducts);
            this.panel1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(160, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 665);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 39);
            this.label3.TabIndex = 69;
            this.label3.Text = "Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 39);
            this.label2.TabIndex = 68;
            this.label2.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 67;
            this.label1.Text = "Add";
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.AutoEllipsis = true;
            this.btnProductEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductEdit.FlatAppearance.BorderSize = 0;
            this.btnProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductEdit.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnProductEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductEdit.Location = new System.Drawing.Point(60, 334);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(103, 29);
            this.btnProductEdit.TabIndex = 66;
            this.btnProductEdit.Text = "Click here";
            this.btnProductEdit.UseVisualStyleBackColor = false;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.AutoEllipsis = true;
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductDelete.FlatAppearance.BorderSize = 0;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductDelete.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnProductDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductDelete.Location = new System.Drawing.Point(60, 436);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(103, 29);
            this.btnProductDelete.TabIndex = 65;
            this.btnProductDelete.Text = "Click here";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.AutoEllipsis = true;
            this.btnProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductAdd.FlatAppearance.BorderSize = 0;
            this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductAdd.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProductAdd.Location = new System.Drawing.Point(60, 233);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(103, 28);
            this.btnProductAdd.TabIndex = 64;
            this.btnProductAdd.Text = "Click here";
            this.btnProductAdd.UseVisualStyleBackColor = false;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // dgvManageProducts
            // 
            this.dgvManageProducts.AllowUserToAddRows = false;
            this.dgvManageProducts.AllowUserToResizeColumns = false;
            this.dgvManageProducts.AllowUserToResizeRows = false;
            this.dgvManageProducts.AutoGenerateColumns = false;
            this.dgvManageProducts.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvManageProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvManageProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvManageProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodQuantityDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn});
            this.dgvManageProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvManageProducts.DataSource = this.productBindingSource;
            this.dgvManageProducts.GridColor = System.Drawing.Color.White;
            this.dgvManageProducts.Location = new System.Drawing.Point(341, 148);
            this.dgvManageProducts.Name = "dgvManageProducts";
            this.dgvManageProducts.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvManageProducts.RowHeadersVisible = false;
            this.dgvManageProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManageProducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvManageProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvManageProducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvManageProducts.RowTemplate.Height = 35;
            this.dgvManageProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvManageProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageProducts.Size = new System.Drawing.Size(708, 499);
            this.dgvManageProducts.TabIndex = 49;
            // 
            // prodIDDataGridViewTextBoxColumn
            // 
            this.prodIDDataGridViewTextBoxColumn.DataPropertyName = "ProdID";
            this.prodIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.prodIDDataGridViewTextBoxColumn.Name = "prodIDDataGridViewTextBoxColumn";
            this.prodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodIDDataGridViewTextBoxColumn.Width = 180;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.Width = 210;
            // 
            // prodQuantityDataGridViewTextBoxColumn
            // 
            this.prodQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProdQuantity";
            this.prodQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.prodQuantityDataGridViewTextBoxColumn.Name = "prodQuantityDataGridViewTextBoxColumn";
            this.prodQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.marketManagmentDataSet9;
            // 
            // marketManagmentDataSet9
            // 
            this.marketManagmentDataSet9.DataSetName = "MarketManagmentDataSet9";
            this.marketManagmentDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxProdSelectCategory
            // 
            this.comboBoxProdSelectCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxProdSelectCategory.DataSource = this.categoriesTableBindingSource;
            this.comboBoxProdSelectCategory.DisplayMember = "CatName";
            this.comboBoxProdSelectCategory.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProdSelectCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxProdSelectCategory.FormattingEnabled = true;
            this.comboBoxProdSelectCategory.Location = new System.Drawing.Point(545, 105);
            this.comboBoxProdSelectCategory.Name = "comboBoxProdSelectCategory";
            this.comboBoxProdSelectCategory.Size = new System.Drawing.Size(221, 35);
            this.comboBoxProdSelectCategory.TabIndex = 48;
            this.comboBoxProdSelectCategory.ValueMember = "CatID";
            // 
            // btnProdRefresh
            // 
            this.btnProdRefresh.AutoEllipsis = true;
            this.btnProdRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProdRefresh.FlatAppearance.BorderSize = 0;
            this.btnProdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdRefresh.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdRefresh.ForeColor = System.Drawing.Color.White;
            this.btnProdRefresh.Location = new System.Drawing.Point(787, 105);
            this.btnProdRefresh.Name = "btnProdRefresh";
            this.btnProdRefresh.Size = new System.Drawing.Size(166, 37);
            this.btnProdRefresh.TabIndex = 47;
            this.btnProdRefresh.Text = "Refresh";
            this.btnProdRefresh.UseVisualStyleBackColor = false;
            this.btnProdRefresh.Click += new System.EventHandler(this.btnProdRefresh_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.AutoEllipsis = true;
            this.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageProducts.FlatAppearance.BorderSize = 0;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageProducts.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.ForeColor = System.Drawing.Color.DimGray;
            this.btnManageProducts.Location = new System.Drawing.Point(403, 24);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(283, 54);
            this.btnManageProducts.TabIndex = 19;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = false;
            // 
            // btnSeller
            // 
            this.btnSeller.AutoEllipsis = true;
            this.btnSeller.BackColor = System.Drawing.Color.White;
            this.btnSeller.FlatAppearance.BorderSize = 0;
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeller.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeller.ForeColor = System.Drawing.Color.DimGray;
            this.btnSeller.Location = new System.Drawing.Point(12, 55);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(121, 54);
            this.btnSeller.TabIndex = 18;
            this.btnSeller.Text = "Seller";
            this.btnSeller.UseVisualStyleBackColor = false;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
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
            this.btnSelling.TabIndex = 19;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
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
            this.btnCategory.TabIndex = 20;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
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
            this.button4.TabIndex = 20;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // marketManagmentDataSet19
            // 
            this.marketManagmentDataSet19.DataSetName = "MarketManagmentDataSet19";
            this.marketManagmentDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableBindingSource
            // 
            this.categoriesTableBindingSource.DataMember = "CategoriesTable";
            this.categoriesTableBindingSource.DataSource = this.marketManagmentDataSet19;
            // 
            // categoriesTableTableAdapter
            // 
            this.categoriesTableTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 688);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBoxProdSelectCategory;
        private System.Windows.Forms.Button btnProdRefresh;
        private System.Windows.Forms.DataGridView dgvManageProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductAdd;
        private MarketManagmentDataSet9 marketManagmentDataSet9;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MarketManagmentDataSet9TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private MarketManagmentDataSet19 marketManagmentDataSet19;
        private System.Windows.Forms.BindingSource categoriesTableBindingSource;
        private MarketManagmentDataSet19TableAdapters.CategoriesTableTableAdapter categoriesTableTableAdapter;
    }
}