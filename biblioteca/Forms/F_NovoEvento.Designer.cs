namespace biblioteca
{
    partial class F_NovoEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NovoEvento));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_informacoesEvento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_localEvento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mask_comeca = new System.Windows.Forms.MaskedTextBox();
            this.mas_termina = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Evento";
            // 
            // tb_nomeEvento
            // 
            this.tb_nomeEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nomeEvento.Location = new System.Drawing.Point(12, 34);
            this.tb_nomeEvento.Name = "tb_nomeEvento";
            this.tb_nomeEvento.Size = new System.Drawing.Size(406, 20);
            this.tb_nomeEvento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informações do Evento";
            // 
            // tb_informacoesEvento
            // 
            this.tb_informacoesEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_informacoesEvento.Location = new System.Drawing.Point(12, 79);
            this.tb_informacoesEvento.Multiline = true;
            this.tb_informacoesEvento.Name = "tb_informacoesEvento";
            this.tb_informacoesEvento.Size = new System.Drawing.Size(406, 87);
            this.tb_informacoesEvento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local";
            // 
            // tb_localEvento
            // 
            this.tb_localEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_localEvento.Location = new System.Drawing.Point(12, 192);
            this.tb_localEvento.Name = "tb_localEvento";
            this.tb_localEvento.Size = new System.Drawing.Size(406, 20);
            this.tb_localEvento.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Começa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Termina";
            // 
            // mask_comeca
            // 
            this.mask_comeca.Location = new System.Drawing.Point(11, 243);
            this.mask_comeca.Mask = "00/00/0000";
            this.mask_comeca.Name = "mask_comeca";
            this.mask_comeca.Size = new System.Drawing.Size(73, 20);
            this.mask_comeca.TabIndex = 8;
            this.mask_comeca.ValidatingType = typeof(System.DateTime);
            // 
            // mas_termina
            // 
            this.mas_termina.Location = new System.Drawing.Point(114, 243);
            this.mas_termina.Mask = "00/00/0000";
            this.mas_termina.Name = "mas_termina";
            this.mas_termina.Size = new System.Drawing.Size(73, 20);
            this.mas_termina.TabIndex = 9;
            this.mas_termina.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // F_NovoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mas_termina);
            this.Controls.Add(this.mask_comeca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_localEvento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_informacoesEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nomeEvento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_NovoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Evento";
            this.Load += new System.EventHandler(this.F_NovoEvento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_NovoEvento_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_informacoesEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_localEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mask_comeca;
        private System.Windows.Forms.MaskedTextBox mas_termina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}