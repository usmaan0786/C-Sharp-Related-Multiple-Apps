namespace SecondGUI
{
    partial class AdvancedTools
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
            this.BtnAdvancedTools = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // BtnAdvancedTools
            // 
            this.BtnAdvancedTools.BackColor = System.Drawing.Color.White;
            this.BtnAdvancedTools.Font = new System.Drawing.Font("Imprint MT Shadow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdvancedTools.Location = new System.Drawing.Point(50, 38);
            this.BtnAdvancedTools.Name = "BtnAdvancedTools";
            this.BtnAdvancedTools.Size = new System.Drawing.Size(700, 62);
            this.BtnAdvancedTools.TabIndex = 3;
            this.BtnAdvancedTools.Text = "View Path";
            this.BtnAdvancedTools.UseVisualStyleBackColor = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(50, 120);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(700, 292);
            this.treeView1.TabIndex = 2;
            // 
            // AdvancedTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdvancedTools);
            this.Controls.Add(this.treeView1);
            this.Name = "AdvancedTools";
            this.Text = "AdvancedTools";
            this.Load += new System.EventHandler(this.AdvancedTools_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdvancedTools;
        private System.Windows.Forms.TreeView treeView1;
    }
}