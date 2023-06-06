namespace MarketManagmentSystem
{
    partial class EditProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEditProdCategory = new System.Windows.Forms.ComboBox();
            this.categoriesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketManagmentDataSet11 = new MarketManagmentSystem.MarketManagmentDataSet11();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBoxProductEditPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBoxProductEditQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxProductEditName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBoxProductEditcancel = new System.Windows.Forms.Button();
            this.btnBoxProductEditOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxProductEditID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoriesTableTableAdapter = new MarketManagmentSystem.MarketManagmentDataSet11TableAdapters.CategoriesTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet11)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(36, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Your Label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(141, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 4);
            this.panel1.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(34, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 101;
            this.label5.Text = "Category";
            // 
            // comboBoxEditProdCategory
            // 
            this.comboBoxEditProdCategory.BackColor = System.Drawing.Color.White;
            this.comboBoxEditProdCategory.DataSource = this.categoriesTableBindingSource;
            this.comboBoxEditProdCategory.DisplayMember = "CatName";
            this.comboBoxEditProdCategory.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditProdCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxEditProdCategory.FormattingEnabled = true;
            this.comboBoxEditProdCategory.Location = new System.Drawing.Point(140, 248);
            this.comboBoxEditProdCategory.Name = "comboBoxEditProdCategory";
            this.comboBoxEditProdCategory.Size = new System.Drawing.Size(211, 31);
            this.comboBoxEditProdCategory.TabIndex = 100;
            this.comboBoxEditProdCategory.ValueMember = "CatID";
            // 
            // categoriesTableBindingSource
            // 
            this.categoriesTableBindingSource.DataMember = "CategoriesTable";
            this.categoriesTableBindingSource.DataSource = this.marketManagmentDataSet11;
            // 
            // marketManagmentDataSet11
            // 
            this.marketManagmentDataSet11.DataSetName = "MarketManagmentDataSet11";
            this.marketManagmentDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(140, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 4);
            this.panel5.TabIndex = 99;
            // 
            // txtBoxProductEditPrice
            // 
            this.txtBoxProductEditPrice.BackColor = System.Drawing.Color.White;
            this.txtBoxProductEditPrice.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductEditPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxProductEditPrice.Location = new System.Drawing.Point(140, 201);
            this.txtBoxProductEditPrice.Name = "txtBoxProductEditPrice";
            this.txtBoxProductEditPrice.Size = new System.Drawing.Size(212, 30);
            this.txtBoxProductEditPrice.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(35, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 97;
            this.label3.Text = "Price";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(141, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 4);
            this.panel4.TabIndex = 96;
            // 
            // txtBoxProductEditQuantity
            // 
            this.txtBoxProductEditQuantity.BackColor = System.Drawing.Color.White;
            this.txtBoxProductEditQuantity.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductEditQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxProductEditQuantity.Location = new System.Drawing.Point(141, 148);
            this.txtBoxProductEditQuantity.Name = "txtBoxProductEditQuantity";
            this.txtBoxProductEditQuantity.Size = new System.Drawing.Size(212, 30);
            this.txtBoxProductEditQuantity.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 94;
            this.label2.Text = "Quantity";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(140, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 4);
            this.panel3.TabIndex = 93;
            // 
            // txtBoxProductEditName
            // 
            this.txtBoxProductEditName.BackColor = System.Drawing.Color.White;
            this.txtBoxProductEditName.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductEditName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxProductEditName.Location = new System.Drawing.Point(140, 95);
            this.txtBoxProductEditName.Name = "txtBoxProductEditName";
            this.txtBoxProductEditName.Size = new System.Drawing.Size(212, 30);
            this.txtBoxProductEditName.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 91;
            this.label1.Text = "Name";
            // 
            // btnBoxProductEditcancel
            // 
            this.btnBoxProductEditcancel.AutoEllipsis = true;
            this.btnBoxProductEditcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBoxProductEditcancel.FlatAppearance.BorderSize = 0;
            this.btnBoxProductEditcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxProductEditcancel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxProductEditcancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBoxProductEditcancel.Location = new System.Drawing.Point(472, 311);
            this.btnBoxProductEditcancel.Name = "btnBoxProductEditcancel";
            this.btnBoxProductEditcancel.Size = new System.Drawing.Size(81, 38);
            this.btnBoxProductEditcancel.TabIndex = 106;
            this.btnBoxProductEditcancel.Text = "Cancel";
            this.btnBoxProductEditcancel.UseVisualStyleBackColor = false;
            this.btnBoxProductEditcancel.Click += new System.EventHandler(this.btnBoxProductEditcancel_Click);
            // 
            // btnBoxProductEditOk
            // 
            this.btnBoxProductEditOk.AutoEllipsis = true;
            this.btnBoxProductEditOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBoxProductEditOk.FlatAppearance.BorderSize = 0;
            this.btnBoxProductEditOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoxProductEditOk.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxProductEditOk.ForeColor = System.Drawing.Color.Maroon;
            this.btnBoxProductEditOk.Location = new System.Drawing.Point(450, 243);
            this.btnBoxProductEditOk.Name = "btnBoxProductEditOk";
            this.btnBoxProductEditOk.Size = new System.Drawing.Size(103, 52);
            this.btnBoxProductEditOk.TabIndex = 105;
            this.btnBoxProductEditOk.Text = "OK";
            this.btnBoxProductEditOk.UseVisualStyleBackColor = false;
            this.btnBoxProductEditOk.Click += new System.EventHandler(this.btnBoxProductEditOk_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(141, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 4);
            this.panel2.TabIndex = 109;
            // 
            // txtBoxProductEditID
            // 
            this.txtBoxProductEditID.BackColor = System.Drawing.Color.White;
            this.txtBoxProductEditID.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProductEditID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxProductEditID.Location = new System.Drawing.Point(141, 53);
            this.txtBoxProductEditID.Name = "txtBoxProductEditID";
            this.txtBoxProductEditID.Size = new System.Drawing.Size(212, 30);
            this.txtBoxProductEditID.TabIndex = 108;
            this.txtBoxProductEditID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxProductEditID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(35, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 30);
            this.label6.TabIndex = 107;
            this.label6.Text = "ID";
            // 
            // categoriesTableTableAdapter
            // 
            this.categoriesTableTableAdapter.ClearBeforeFill = true;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(565, 355);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBoxProductEditID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBoxProductEditcancel);
            this.Controls.Add(this.btnBoxProductEditOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEditProdCategory);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtBoxProductEditPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtBoxProductEditQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBoxProductEditName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketManagmentDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEditProdCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBoxProductEditPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBoxProductEditQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBoxProductEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoxProductEditcancel;
        private System.Windows.Forms.Button btnBoxProductEditOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxProductEditID;
        private System.Windows.Forms.Label label6;
        private MarketManagmentDataSet11 marketManagmentDataSet11;
        private System.Windows.Forms.BindingSource categoriesTableBindingSource;
        private MarketManagmentDataSet11TableAdapters.CategoriesTableTableAdapter categoriesTableTableAdapter;
    }
}