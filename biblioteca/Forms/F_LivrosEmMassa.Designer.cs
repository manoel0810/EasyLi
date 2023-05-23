namespace biblioteca
{
    partial class F_LivrosEmMassa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LivrosEmMassa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_livro = new System.Windows.Forms.TextBox();
            this.tb_tombo = new System.Windows.Forms.TextBox();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.tb_aluno = new System.Windows.Forms.TextBox();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.bnt_voltar = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tombo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome do Aluno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Matrícula";
            // 
            // tb_livro
            // 
            this.tb_livro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_livro.Location = new System.Drawing.Point(12, 35);
            this.tb_livro.Name = "tb_livro";
            this.tb_livro.Size = new System.Drawing.Size(472, 20);
            this.tb_livro.TabIndex = 1;
            // 
            // tb_tombo
            // 
            this.tb_tombo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_tombo.Location = new System.Drawing.Point(12, 75);
            this.tb_tombo.Name = "tb_tombo";
            this.tb_tombo.Size = new System.Drawing.Size(100, 20);
            this.tb_tombo.TabIndex = 2;
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(139, 75);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(132, 21);
            this.cb_turma.TabIndex = 3;
            // 
            // mask_data
            // 
            this.mask_data.Location = new System.Drawing.Point(398, 76);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(86, 20);
            this.mask_data.TabIndex = 4;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // tb_aluno
            // 
            this.tb_aluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_aluno.Location = new System.Drawing.Point(12, 131);
            this.tb_aluno.Name = "tb_aluno";
            this.tb_aluno.Size = new System.Drawing.Size(366, 20);
            this.tb_aluno.TabIndex = 5;
            // 
            // tb_matricula
            // 
            this.tb_matricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_matricula.Location = new System.Drawing.Point(384, 131);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(100, 20);
            this.tb_matricula.TabIndex = 6;
            this.tb_matricula.Leave += new System.EventHandler(this.tb_matricula_Leave);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(409, 211);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // bnt_voltar
            // 
            this.bnt_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_voltar.Location = new System.Drawing.Point(328, 211);
            this.bnt_voltar.Name = "bnt_voltar";
            this.bnt_voltar.Size = new System.Drawing.Size(75, 23);
            this.bnt_voltar.TabIndex = 9;
            this.bnt_voltar.Text = "Voltar";
            this.bnt_voltar.UseVisualStyleBackColor = true;
            this.bnt_voltar.Click += new System.EventHandler(this.bnt_voltar_Click);
            // 
            // tb_email
            // 
            this.tb_email.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_email.Location = new System.Drawing.Point(12, 175);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(475, 20);
            this.tb_email.TabIndex = 7;
            this.tb_email.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Endereço eletrônico (Facultativo) - DESETIVADO";
            // 
            // F_LivrosEmMassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 246);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.bnt_voltar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.tb_aluno);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.cb_turma);
            this.Controls.Add(this.tb_tombo);
            this.Controls.Add(this.tb_livro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_LivrosEmMassa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.F_LivrosEmMassa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_LivrosEmMassa_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_livro;
        private System.Windows.Forms.TextBox tb_tombo;
        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.TextBox tb_aluno;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button bnt_voltar;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label7;
    }
}