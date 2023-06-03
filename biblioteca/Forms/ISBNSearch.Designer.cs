namespace biblioteca.Forms
{
    partial class ISBNSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ISBNSearch));
            this.Buscar = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Capa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(129, 47);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(13, 25);
            this.ISBN.MaxLength = 16;
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(191, 20);
            this.ISBN.TabIndex = 0;
            this.ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Capa
            // 
            this.Capa.AutoSize = true;
            this.Capa.Location = new System.Drawing.Point(13, 53);
            this.Capa.Name = "Capa";
            this.Capa.Size = new System.Drawing.Size(91, 17);
            this.Capa.TabIndex = 2;
            this.Capa.Text = "Buscar capas";
            this.Capa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ISBN13/ISBN10";
            // 
            // ISBNSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(217, 79);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Capa);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ISBNSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar dados por ISBN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.CheckBox Capa;
        private System.Windows.Forms.Label label1;
    }
}