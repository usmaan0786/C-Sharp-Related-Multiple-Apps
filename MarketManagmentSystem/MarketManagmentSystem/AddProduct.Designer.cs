namespace MarketManagmentSystem
{
    partial class AddProduct
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
            this.roundButton1 = new MarketManagmentSystem.RoundButton();
            this.roundButton2 = new MarketManagmentSystem.RoundButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAddProdCategory = new System.Windows.Forms.ComboBox();
            this.categoriesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketManagmentDataSet10 = new MarketManagmentSystem.MarketManagmentDataSet10();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBoxProductAddPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBoxProductAddQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxProductEditName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBoxCatAddcancel = new System.Windows.Forms.Button();
            this.btnBoxCatAddOk = new System.Windows.Forms.Button();
            this.categoriesTableTableAdapter = new MarketManagmentSystem.MarketManagmentDataSet10TableAdapters.CategoriesTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Location = new System.Drawing.Point(-174, -42);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(618, 462);
            this.roundButton1.TabIndex = 65;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.White;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Location = new System.Drawing.Point(450, -92);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(266, 254);
            this.roundButton2.TabIndex = 77;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(43, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 88;
            this.label5.Text = "Category";
            // 
            // comboBoxAddProdCategory
            // 
            this.comboBoxAddProdCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxAddProdCategory.DataSource = this.categoriesTableBindingSource;
            this.comboBoxAddProdCategory.DisplayMember = "CatName";
            this.comboBoxAddProdCategory.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAddProdCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxAddProdCategory.FormattingEnabled = true;
            this.comboBoxAddProdCategory.Location = new System.Drawing.Point(149, 228);
            this.comboBoxAddProdCategory.Name = "comboBoxAddProdCategory";
            this.comboBoxAddProdCategory.Size = new System.Drawing.Size(211, 31);
            this.comboBoxAddProdCategory.TabIndex = 87;
            this.comboBoxAddProdCategory.ValueMember = "CatID";
            // 
            // categoriesTableBindingSource
            // 
            this.categoriesTableBindingSource.DataMember = "CategoriesTable";
            this.categoriesTableBindingSource.DataSource = this.marketManagmentDataSet10;
            // 
            // marketManagmentDataSet10
            // 
            this.marketManagmentDataSet10.DataSetName = "MarketManagmentDataSet10";
            this.marketManagmentDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(149, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 4);
            this.panel5.TabIndex = 86;
            // 
            // txtBoxProductAddPrice
            // 
            this.txtBoxProductAddPrice.BackColor = System.Drawing.Color.White;
            this.txtBoxProductAddPrice.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductAddPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxProductAddPrice.Location = new System.Drawing.Point(149, 181);
            this.txtBoxProductAddPrice.Name = "txtBoxProductAddPrice";
            this.txtBoxProductAddPrice.Size = new System.Drawing.Size(212, 30);
            this.txtBoxProductAddPrice.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 84;
            this.label3.Text = "Price";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(150, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 4);
            this.panel4.TabIndex = 83;
            // 
            // txtBoxProductAddQuantity
            // 
            this.txtBoxProductAddQuantity.BackColor = System.Drawing.Color.White;
            this.txtBoxProductAddQuantity.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductAddQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxProductAddQuantity.Location = new System.Drawing.Point(150, 128);
            this.txtBoxProductAddQuantity.Name = "txtBoxProductAddQuantity";
            this.txtBoxProductAddQuantity.Size = new System.Drawing.Size(212, 30);
            this.txtBoxProductAddQuantity.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 81;
            this.label2.Text = "Quantity";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(149, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 4);
            this.panel3.TabIndex = 80;
            // 
            // txtBoxProductEditName
            // 
            this.txtBoxProductEditName.BackColor = System.Drawing.Color.White;
            this.txtBoxProductEditName.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductEditName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxProductEditName.Location = new System.Drawing.Point(149, 75);
            this.txtBoxProductEditName.Name = "txtBoxProductEditName";
            this.txtBoxProductEditName.Size = new System.Drawing.Size(212, 30);
            this.txtBoxProductEditName.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 78;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(150, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 4);
            this.panel1.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(45, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 90;
            this.label4.Text = "Your Label";
            // 
            // btnBoxCatAddcancel
            // 
            this.btnBoxCatAddcancel.AutoEllipsis = true;
            this.btnBoxCatAddcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBoxCatAddcancel.FlatAppearance.BorderSize = 0;
            this.btnBoxCatAddcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxCatAddcancel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxCatAddcancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnBoxCatAddcancel.Location = new System.Drawing.Point(472, 309);
            this.btnBoxCatAddcancel.Name = "btnBoxCatAddcancel";
            this.btnBoxCatAddcancel.Size = new System.Drawing.Size(81, 38);
            this.btnBoxCatAddcancel.TabIndex = 93;
            this.btnBoxCatAddcancel.Text = "Cancel";
            this.btnBoxCatAddcancel.UseVisualStyleBackColor = false;
            this.btnBoxCatAddcancel.Click += new System.EventHandler(this.btnBoxCatAddcancel_Click);
            // 
            // btnBoxCatAddOk
            // 
            this.btnBoxCatAddOk.AutoEllipsis = true;
            this.btnBoxCatAddOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBoxCatAddOk.FlatAppearance.BorderSize = 0;
            this.btnBoxCatAddOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxCatAddOk.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxCatAddOk.ForeColor = System.Drawing.Color.Maroon;
            this.btnBoxCatAddOk.Location = new System.Drawing.Point(450, 241);
            this.btnBoxCatAddOk.Name = "btnBoxCatAddOk";
            this.btnBoxCatAddOk.Size = new System.Drawing.Size(103, 52);
            this.btnBoxCatAddOk.TabIndex = 92;
            this.btnBoxCatAddOk.Text = "OK";
            this.btnBoxCatAddOk.UseVisualStyleBackColor = false;
            this.btnBoxCatAddOk.Click += new System.EventHandler(this.btnBoxCatAddOk_Click);
            // 
            // categoriesTableTableAdapter
            // 
            this.categoriesTableTableAdapter.ClearBeforeFill = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(565, 355);
            this.Controls.Add(this.btnBoxCatAddcancel);
            this.Controls.Add(this.btnBoxCatAddOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAddProdCategory);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtBoxProductAddPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBoxProductAddQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBoxProductEditName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAddProdCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBoxProductAddPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBoxProductAddQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxProductEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBoxCatAddcancel;
        private System.Windows.Forms.Button btnBoxCatAddOk;
        private MarketManagmentDataSet10 marketManagmentDataSet10;
        private System.Windows.Forms.BindingSource categoriesTableBindingSource;
        private MarketManagmentDataSet10TableAdapters.CategoriesTableTableAdapter categoriesTableTableAdapter;
    }
}