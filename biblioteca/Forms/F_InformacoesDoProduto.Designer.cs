namespace biblioteca
{
    partial class F_InformacoesDoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_InformacoesDoProduto));
            this.ProductInfo = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductInfo
            // 
            this.ProductInfo.BackColor = System.Drawing.Color.White;
            this.ProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductInfo.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ProductInfo.Location = new System.Drawing.Point(11, 358);
            this.ProductInfo.Multiline = true;
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.ReadOnly = true;
            this.ProductInfo.Size = new System.Drawing.Size(342, 66);
            this.ProductInfo.TabIndex = 1;
            this.ProductInfo.TabStop = false;
            this.ProductInfo.Text = "\r\nVersão do software 1.0.0. Última revisão em 10/11/2023\r\nEasyLi Pro - Todos os d" +
    "ireitos reservados\r\nCopyright 2023.\r\n";
            this.ProductInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(13, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(340, 340);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // F_InformacoesDoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 436);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ProductInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_InformacoesDoProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_InformacoesDoProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProductInfo;
        private System.Windows.Forms.PictureBox Logo;
    }
}