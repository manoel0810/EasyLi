namespace biblioteca
{
    partial class F_RelatorioA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_RelatorioA));
            this.mask_ano = new System.Windows.Forms.MaskedTextBox();
            this.pgb_gerando = new System.Windows.Forms.ProgressBar();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.rb_thiss = new System.Windows.Forms.RadioButton();
            this.rb_exp = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.cb_avan = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mask_ano
            // 
            this.mask_ano.Location = new System.Drawing.Point(296, 24);
            this.mask_ano.Mask = "0000";
            this.mask_ano.Name = "mask_ano";
            this.mask_ano.Size = new System.Drawing.Size(41, 20);
            this.mask_ano.TabIndex = 2;
            // 
            // pgb_gerando
            // 
            this.pgb_gerando.Location = new System.Drawing.Point(12, 193);
            this.pgb_gerando.Name = "pgb_gerando";
            this.pgb_gerando.Size = new System.Drawing.Size(444, 23);
            this.pgb_gerando.TabIndex = 3;
            // 
            // btn_gerar
            // 
            this.btn_gerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerar.Location = new System.Drawing.Point(393, 230);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(63, 23);
            this.btn_gerar.TabIndex = 4;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(324, 230);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(63, 23);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // rb_thiss
            // 
            this.rb_thiss.AutoSize = true;
            this.rb_thiss.Location = new System.Drawing.Point(12, 27);
            this.rb_thiss.Name = "rb_thiss";
            this.rb_thiss.Size = new System.Drawing.Size(117, 17);
            this.rb_thiss.TabIndex = 6;
            this.rb_thiss.TabStop = true;
            this.rb_thiss.Text = "Relatório deste ano";
            this.rb_thiss.UseVisualStyleBackColor = true;
            // 
            // rb_exp
            // 
            this.rb_exp.AutoSize = true;
            this.rb_exp.Location = new System.Drawing.Point(184, 27);
            this.rb_exp.Name = "rb_exp";
            this.rb_exp.Size = new System.Drawing.Size(106, 17);
            this.rb_exp.TabIndex = 7;
            this.rb_exp.TabStop = true;
            this.rb_exp.Text = "Relatório do ano:";
            this.rb_exp.UseVisualStyleBackColor = true;
            this.rb_exp.CheckedChanged += new System.EventHandler(this.rb_exp_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_estado);
            this.panel1.Controls.Add(this.cb_turma);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 95);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado: (Vazio para todos)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turma: (Vazio para todas)";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Emprestado",
            "Devolvido",
            "PERDIDO",
            "BLOQUEADO"});
            this.cb_estado.Location = new System.Drawing.Point(256, 25);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(157, 21);
            this.cb_estado.TabIndex = 1;
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(15, 25);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(157, 21);
            this.cb_turma.TabIndex = 0;
            // 
            // cb_avan
            // 
            this.cb_avan.AutoSize = true;
            this.cb_avan.Location = new System.Drawing.Point(12, 69);
            this.cb_avan.Name = "cb_avan";
            this.cb_avan.Size = new System.Drawing.Size(120, 17);
            this.cb_avan.TabIndex = 9;
            this.cb_avan.Text = "Opções Avançadas";
            this.cb_avan.UseVisualStyleBackColor = true;
            this.cb_avan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // F_RelatorioA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.cb_avan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rb_exp);
            this.Controls.Add(this.rb_thiss);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_gerar);
            this.Controls.Add(this.pgb_gerando);
            this.Controls.Add(this.mask_ano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_RelatorioA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Anual";
            this.Load += new System.EventHandler(this.F_RelatorioA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mask_ano;
        private System.Windows.Forms.ProgressBar pgb_gerando;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.RadioButton rb_thiss;
        private System.Windows.Forms.RadioButton rb_exp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.CheckBox cb_avan;
    }
}