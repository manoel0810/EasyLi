namespace biblioteca.Forms
{
    partial class GitProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitProperties));
            this.Token = new System.Windows.Forms.TextBox();
            this.Proprietario = new System.Windows.Forms.TextBox();
            this.Repositorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aplicar = new System.Windows.Forms.Button();
            this.Calcelar = new System.Windows.Forms.Button();
            this.RemoverAcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Token
            // 
            this.Token.Location = new System.Drawing.Point(12, 26);
            this.Token.MaxLength = 256;
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(230, 20);
            this.Token.TabIndex = 0;
            // 
            // Proprietario
            // 
            this.Proprietario.Location = new System.Drawing.Point(258, 26);
            this.Proprietario.MaxLength = 24;
            this.Proprietario.Name = "Proprietario";
            this.Proprietario.Size = new System.Drawing.Size(128, 20);
            this.Proprietario.TabIndex = 1;
            // 
            // Repositorio
            // 
            this.Repositorio.Location = new System.Drawing.Point(12, 63);
            this.Repositorio.MaxLength = 64;
            this.Repositorio.Name = "Repositorio";
            this.Repositorio.Size = new System.Drawing.Size(230, 20);
            this.Repositorio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Token de acesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repositório";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proprietário";
            // 
            // Aplicar
            // 
            this.Aplicar.Location = new System.Drawing.Point(311, 107);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(75, 23);
            this.Aplicar.TabIndex = 3;
            this.Aplicar.Text = "Aplicar";
            this.Aplicar.UseVisualStyleBackColor = true;
            this.Aplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // Calcelar
            // 
            this.Calcelar.Location = new System.Drawing.Point(230, 107);
            this.Calcelar.Name = "Calcelar";
            this.Calcelar.Size = new System.Drawing.Size(75, 23);
            this.Calcelar.TabIndex = 4;
            this.Calcelar.Text = "Cancelar";
            this.Calcelar.UseVisualStyleBackColor = true;
            this.Calcelar.Click += new System.EventHandler(this.Calcelar_Click);
            // 
            // RemoverAcesso
            // 
            this.RemoverAcesso.ForeColor = System.Drawing.Color.Maroon;
            this.RemoverAcesso.Location = new System.Drawing.Point(12, 107);
            this.RemoverAcesso.Name = "RemoverAcesso";
            this.RemoverAcesso.Size = new System.Drawing.Size(126, 23);
            this.RemoverAcesso.TabIndex = 5;
            this.RemoverAcesso.Text = "Remover credenciais";
            this.RemoverAcesso.UseVisualStyleBackColor = true;
            this.RemoverAcesso.Click += new System.EventHandler(this.RemoverAcesso_Click);
            // 
            // GitProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 142);
            this.Controls.Add(this.RemoverAcesso);
            this.Controls.Add(this.Calcelar);
            this.Controls.Add(this.Aplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Repositorio);
            this.Controls.Add(this.Proprietario);
            this.Controls.Add(this.Token);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GitProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definir acesso";
            this.Load += new System.EventHandler(this.GitProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Token;
        private System.Windows.Forms.TextBox Proprietario;
        private System.Windows.Forms.TextBox Repositorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Aplicar;
        private System.Windows.Forms.Button Calcelar;
        private System.Windows.Forms.Button RemoverAcesso;
    }
}