﻿namespace biblioteca
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
            this.SuspendLayout();
            // 
            // ProductInfo
            // 
            this.ProductInfo.BackColor = System.Drawing.Color.White;
            this.ProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfo.Location = new System.Drawing.Point(10, 12);
            this.ProductInfo.Multiline = true;
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.ReadOnly = true;
            this.ProductInfo.Size = new System.Drawing.Size(342, 263);
            this.ProductInfo.TabIndex = 1;
            this.ProductInfo.TabStop = false;
            this.ProductInfo.Text = resources.GetString("ProductInfo.Text");
            // 
            // F_InformacoesDoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 297);
            this.Controls.Add(this.ProductInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_InformacoesDoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProductInfo;
    }
}