namespace SecondGUI
{
    partial class ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnProgressBar = new System.Windows.Forms.Button();
            this.RichTxtTable = new System.Windows.Forms.RichTextBox();
            this.TxtTable = new System.Windows.Forms.TextBox();
            this.TxtEndingNo = new System.Windows.Forms.TextBox();
            this.TxtStartingNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(32, 375);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(636, 44);
            this.progressBar1.TabIndex = 0;
            // 
            // BtnProgressBar
            // 
            this.BtnProgressBar.BackColor = System.Drawing.Color.Aqua;
            this.BtnProgressBar.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProgressBar.Location = new System.Drawing.Point(153, 12);
            this.BtnProgressBar.Name = "BtnProgressBar";
            this.BtnProgressBar.Size = new System.Drawing.Size(363, 57);
            this.BtnProgressBar.TabIndex = 1;
            this.BtnProgressBar.Text = "Progress Bar";
            this.BtnProgressBar.UseVisualStyleBackColor = false;
            this.BtnProgressBar.Click += new System.EventHandler(this.BtnProgressBar_Click);
            // 
            // RichTxtTable
            // 
            this.RichTxtTable.Location = new System.Drawing.Point(444, 91);
            this.RichTxtTable.Name = "RichTxtTable";
            this.RichTxtTable.Size = new System.Drawing.Size(224, 278);
            this.RichTxtTable.TabIndex = 2;
            this.RichTxtTable.Text = "";
            // 
            // TxtTable
            // 
            this.TxtTable.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTable.Location = new System.Drawing.Point(197, 153);
            this.TxtTable.Name = "TxtTable";
            this.TxtTable.Size = new System.Drawing.Size(174, 26);
            this.TxtTable.TabIndex = 3;
            // 
            // TxtEndingNo
            // 
            this.TxtEndingNo.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEndingNo.Location = new System.Drawing.Point(197, 260);
            this.TxtEndingNo.Name = "TxtEndingNo";
            this.TxtEndingNo.Size = new System.Drawing.Size(174, 26);
            this.TxtEndingNo.TabIndex = 4;
            // 
            // TxtStartingNo
            // 
            this.TxtStartingNo.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStartingNo.Location = new System.Drawing.Point(197, 202);
            this.TxtStartingNo.Name = "TxtStartingNo";
            this.TxtStartingNo.Size = new System.Drawing.Size(174, 26);
            this.TxtStartingNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ending Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Starting Number :";
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtStartingNo);
            this.Controls.Add(this.TxtEndingNo);
            this.Controls.Add(this.TxtTable);
            this.Controls.Add(this.RichTxtTable);
            this.Controls.Add(this.BtnProgressBar);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressBar";
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnProgressBar;
        private System.Windows.Forms.RichTextBox RichTxtTable;
        private System.Windows.Forms.TextBox TxtTable;
        private System.Windows.Forms.TextBox TxtEndingNo;
        private System.Windows.Forms.TextBox TxtStartingNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}