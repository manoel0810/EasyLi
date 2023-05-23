namespace biblioteca
{
    partial class F_RegistroLivroSaindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_RegistroLivroSaindo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_aluno = new System.Windows.Forms.TextBox();
            this.tb_livro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_data = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tombo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Livro";
            // 
            // tb_aluno
            // 
            this.tb_aluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_aluno.Location = new System.Drawing.Point(12, 152);
            this.tb_aluno.Name = "tb_aluno";
            this.tb_aluno.Size = new System.Drawing.Size(508, 20);
            this.tb_aluno.TabIndex = 5;
            // 
            // tb_livro
            // 
            this.tb_livro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_livro.Location = new System.Drawing.Point(12, 21);
            this.tb_livro.Name = "tb_livro";
            this.tb_livro.Size = new System.Drawing.Size(508, 20);
            this.tb_livro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // msk_data
            // 
            this.msk_data.Location = new System.Drawing.Point(169, 71);
            this.msk_data.Mask = "00/00/0000";
            this.msk_data.Name = "msk_data";
            this.msk_data.Size = new System.Drawing.Size(86, 20);
            this.msk_data.TabIndex = 3;
            this.msk_data.TabStop = false;
            this.msk_data.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turma";
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(360, 71);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(160, 21);
            this.cb_turma.TabIndex = 4;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmar.Location = new System.Drawing.Point(445, 244);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 8;
            this.btn_confirmar.Text = "Salvar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matrícula";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(12, 199);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(91, 20);
            this.tb_matricula.TabIndex = 6;
            this.tb_matricula.Tag = "";
            this.tb_matricula.Leave += new System.EventHandler(this.tb_matricula_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tombo";
            // 
            // tb_tombo
            // 
            this.tb_tombo.Location = new System.Drawing.Point(12, 72);
            this.tb_tombo.Name = "tb_tombo";
            this.tb_tombo.Size = new System.Drawing.Size(111, 20);
            this.tb_tombo.TabIndex = 2;
            this.tb_tombo.Leave += new System.EventHandler(this.tb_tombo_Leave);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(364, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "E-Mail (Opicional)";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(111, 199);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(409, 20);
            this.tb_email.TabIndex = 7;
            // 
            // F_RegistroLivroSaindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 279);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_tombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.cb_turma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msk_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_livro);
            this.Controls.Add(this.tb_aluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_RegistroLivroSaindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirada de livro";
            this.Load += new System.EventHandler(this.F_RegistroLivroSaindo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_RegistroLivroSaindo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_aluno;
        private System.Windows.Forms.TextBox tb_livro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_email;
    }
}