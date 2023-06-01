namespace biblioteca
{
    partial class F_Suporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Suporte));
            this.label1 = new System.Windows.Forms.Label();
            this.Problema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Solicitante = new System.Windows.Forms.Label();
            this.Sistema = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Versao = new System.Windows.Forms.Label();
            this.lb_aprovado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o problema";
            // 
            // Problema
            // 
            this.Problema.Location = new System.Drawing.Point(10, 25);
            this.Problema.Multiline = true;
            this.Problema.Name = "Problema";
            this.Problema.Size = new System.Drawing.Size(598, 140);
            this.Problema.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe um E-mail válido para retorno de informações";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(9, 185);
            this.Email.MaxLength = 128;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(336, 20);
            this.Email.TabIndex = 1;
            this.Email.TextChanged += new System.EventHandler(this.EmailTextChenged);
            // 
            // Enviar
            // 
            this.Enviar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Enviar.Location = new System.Drawing.Point(533, 247);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 2;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.EnviarClick);
            // 
            // Voltar
            // 
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Voltar.Location = new System.Drawing.Point(452, 247);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 3;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.VoltarClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solicitante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sistema:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data:";
            // 
            // Solicitante
            // 
            this.Solicitante.AutoSize = true;
            this.Solicitante.Location = new System.Drawing.Point(72, 214);
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.Size = new System.Drawing.Size(16, 13);
            this.Solicitante.TabIndex = 9;
            this.Solicitante.Text = "...";
            // 
            // Sistema
            // 
            this.Sistema.AutoSize = true;
            this.Sistema.Location = new System.Drawing.Point(72, 228);
            this.Sistema.Name = "Sistema";
            this.Sistema.Size = new System.Drawing.Size(16, 13);
            this.Sistema.TabIndex = 10;
            this.Sistema.Text = "...";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(72, 241);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(16, 13);
            this.Data.TabIndex = 11;
            this.Data.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Versão:";
            // 
            // Versao
            // 
            this.Versao.AutoSize = true;
            this.Versao.Location = new System.Drawing.Point(72, 255);
            this.Versao.Name = "Versao";
            this.Versao.Size = new System.Drawing.Size(16, 13);
            this.Versao.TabIndex = 13;
            this.Versao.Text = "...";
            // 
            // lb_aprovado
            // 
            this.lb_aprovado.AutoSize = true;
            this.lb_aprovado.Location = new System.Drawing.Point(6, 293);
            this.lb_aprovado.Name = "lb_aprovado";
            this.lb_aprovado.Size = new System.Drawing.Size(0, 13);
            this.lb_aprovado.TabIndex = 14;
            // 
            // F_Suporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 279);
            this.Controls.Add(this.lb_aprovado);
            this.Controls.Add(this.Versao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Sistema);
            this.Controls.Add(this.Solicitante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Problema);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Suporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato de suporte";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Problema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Solicitante;
        private System.Windows.Forms.Label Sistema;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Versao;
        private System.Windows.Forms.Label lb_aprovado;
    }
}