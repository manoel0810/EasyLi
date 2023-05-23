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
            this.tb_dados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_solicitante = new System.Windows.Forms.Label();
            this.lb_sistema = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_versao = new System.Windows.Forms.Label();
            this.lb_aprovado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o problema";
            // 
            // tb_dados
            // 
            this.tb_dados.Location = new System.Drawing.Point(10, 25);
            this.tb_dados.Multiline = true;
            this.tb_dados.Name = "tb_dados";
            this.tb_dados.Size = new System.Drawing.Size(598, 226);
            this.tb_dados.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe um E-mail válido para retorno de informações";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(9, 270);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(599, 20);
            this.tb_email.TabIndex = 3;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(533, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(452, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solicitante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sistema:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data:";
            // 
            // lb_solicitante
            // 
            this.lb_solicitante.AutoSize = true;
            this.lb_solicitante.Location = new System.Drawing.Point(77, 310);
            this.lb_solicitante.Name = "lb_solicitante";
            this.lb_solicitante.Size = new System.Drawing.Size(16, 13);
            this.lb_solicitante.TabIndex = 9;
            this.lb_solicitante.Text = "...";
            // 
            // lb_sistema
            // 
            this.lb_sistema.AutoSize = true;
            this.lb_sistema.Location = new System.Drawing.Point(77, 334);
            this.lb_sistema.Name = "lb_sistema";
            this.lb_sistema.Size = new System.Drawing.Size(16, 13);
            this.lb_sistema.TabIndex = 10;
            this.lb_sistema.Text = "...";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(77, 360);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(16, 13);
            this.lb_data.TabIndex = 11;
            this.lb_data.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Versão:";
            // 
            // lb_versao
            // 
            this.lb_versao.AutoSize = true;
            this.lb_versao.Location = new System.Drawing.Point(77, 386);
            this.lb_versao.Name = "lb_versao";
            this.lb_versao.Size = new System.Drawing.Size(16, 13);
            this.lb_versao.TabIndex = 13;
            this.lb_versao.Text = "...";
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
            this.ClientSize = new System.Drawing.Size(620, 416);
            this.Controls.Add(this.lb_aprovado);
            this.Controls.Add(this.lb_versao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_sistema);
            this.Controls.Add(this.lb_solicitante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dados);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Suporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suporte";
            this.Load += new System.EventHandler(this.F_Suporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_solicitante;
        private System.Windows.Forms.Label lb_sistema;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_versao;
        private System.Windows.Forms.Label lb_aprovado;
    }
}