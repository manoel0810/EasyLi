namespace biblioteca
{
    partial class F_Motivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Motivo));
            this.lb_caracteres = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.tb_outro = new System.Windows.Forms.TextBox();
            this.rb_OUT = new System.Windows.Forms.RadioButton();
            this.rb_TRANS = new System.Windows.Forms.RadioButton();
            this.rb_DJD = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_DCP = new System.Windows.Forms.RadioButton();
            this.lb_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_turma = new System.Windows.Forms.Label();
            this.lb_livro = new System.Windows.Forms.Label();
            this.lb_aluno = new System.Windows.Forms.Label();
            this.lb_matricula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_caracteres
            // 
            this.lb_caracteres.AutoSize = true;
            this.lb_caracteres.Location = new System.Drawing.Point(365, 163);
            this.lb_caracteres.Name = "lb_caracteres";
            this.lb_caracteres.Size = new System.Drawing.Size(36, 13);
            this.lb_caracteres.TabIndex = 25;
            this.lb_caracteres.Text = "0/100";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Location = new System.Drawing.Point(534, 152);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 24;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // tb_outro
            // 
            this.tb_outro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_outro.Location = new System.Drawing.Point(214, 99);
            this.tb_outro.MaxLength = 100;
            this.tb_outro.Multiline = true;
            this.tb_outro.Name = "tb_outro";
            this.tb_outro.Size = new System.Drawing.Size(191, 62);
            this.tb_outro.TabIndex = 23;
            this.tb_outro.TextChanged += new System.EventHandler(this.tb_outro_TextChanged);
            // 
            // rb_OUT
            // 
            this.rb_OUT.AutoSize = true;
            this.rb_OUT.Location = new System.Drawing.Point(215, 80);
            this.rb_OUT.Name = "rb_OUT";
            this.rb_OUT.Size = new System.Drawing.Size(54, 17);
            this.rb_OUT.TabIndex = 22;
            this.rb_OUT.TabStop = true;
            this.rb_OUT.Text = "Outro:";
            this.rb_OUT.UseVisualStyleBackColor = true;
            this.rb_OUT.CheckedChanged += new System.EventHandler(this.rb_OUT_CheckedChanged);
            // 
            // rb_TRANS
            // 
            this.rb_TRANS.AutoSize = true;
            this.rb_TRANS.Location = new System.Drawing.Point(215, 36);
            this.rb_TRANS.Name = "rb_TRANS";
            this.rb_TRANS.Size = new System.Drawing.Size(162, 30);
            this.rb_TRANS.TabIndex = 21;
            this.rb_TRANS.TabStop = true;
            this.rb_TRANS.Text = "Transferido e não efetuada a\r\ndevolução";
            this.rb_TRANS.UseVisualStyleBackColor = true;
            // 
            // rb_DJD
            // 
            this.rb_DJD.AutoSize = true;
            this.rb_DJD.Location = new System.Drawing.Point(7, 80);
            this.rb_DJD.Name = "rb_DJD";
            this.rb_DJD.Size = new System.Drawing.Size(178, 30);
            this.rb_DJD.TabIndex = 20;
            this.rb_DJD.TabStop = true;
            this.rb_DJD.Text = "Declara já ter devolvido, todavia\r\nnão está na biblioteca";
            this.rb_DJD.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "MOTIVO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lb_caracteres);
            this.panel1.Controls.Add(this.btn_registrar);
            this.panel1.Controls.Add(this.tb_outro);
            this.panel1.Controls.Add(this.rb_OUT);
            this.panel1.Controls.Add(this.rb_TRANS);
            this.panel1.Controls.Add(this.rb_DJD);
            this.panel1.Controls.Add(this.rb_DCP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(4, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 181);
            this.panel1.TabIndex = 29;
            // 
            // rb_DCP
            // 
            this.rb_DCP.AutoSize = true;
            this.rb_DCP.Location = new System.Drawing.Point(7, 36);
            this.rb_DCP.Name = "rb_DCP";
            this.rb_DCP.Size = new System.Drawing.Size(129, 17);
            this.rb_DCP.TabIndex = 19;
            this.rb_DCP.TabStop = true;
            this.rb_DCP.Text = "Declara como perdido";
            this.rb_DCP.UseVisualStyleBackColor = true;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(548, 49);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(19, 13);
            this.lb_data.TabIndex = 28;
            this.lb_data.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data:";
            // 
            // lb_turma
            // 
            this.lb_turma.AutoSize = true;
            this.lb_turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_turma.Location = new System.Drawing.Point(394, 49);
            this.lb_turma.Name = "lb_turma";
            this.lb_turma.Size = new System.Drawing.Size(19, 13);
            this.lb_turma.TabIndex = 26;
            this.lb_turma.Text = "...";
            // 
            // lb_livro
            // 
            this.lb_livro.AutoSize = true;
            this.lb_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_livro.Location = new System.Drawing.Point(42, 49);
            this.lb_livro.Name = "lb_livro";
            this.lb_livro.Size = new System.Drawing.Size(19, 13);
            this.lb_livro.TabIndex = 25;
            this.lb_livro.Text = "...";
            // 
            // lb_aluno
            // 
            this.lb_aluno.AutoSize = true;
            this.lb_aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_aluno.Location = new System.Drawing.Point(190, 5);
            this.lb_aluno.Name = "lb_aluno";
            this.lb_aluno.Size = new System.Drawing.Size(19, 13);
            this.lb_aluno.TabIndex = 24;
            this.lb_aluno.Text = "...";
            // 
            // lb_matricula
            // 
            this.lb_matricula.AutoSize = true;
            this.lb_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula.Location = new System.Drawing.Point(65, 5);
            this.lb_matricula.Name = "lb_matricula";
            this.lb_matricula.Size = new System.Drawing.Size(19, 13);
            this.lb_matricula.TabIndex = 23;
            this.lb_matricula.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Livro:";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(357, 49);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(40, 13);
            this.labelx.TabIndex = 21;
            this.labelx.Text = "Turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Matrícula:";
            // 
            // F_Motivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_turma);
            this.Controls.Add(this.lb_livro);
            this.Controls.Add(this.lb_aluno);
            this.Controls.Add(this.lb_matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Motivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo";
            this.Load += new System.EventHandler(this.F_Motivo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Motivo_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_caracteres;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox tb_outro;
        private System.Windows.Forms.RadioButton rb_OUT;
        private System.Windows.Forms.RadioButton rb_TRANS;
        private System.Windows.Forms.RadioButton rb_DJD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_DCP;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_turma;
        private System.Windows.Forms.Label lb_livro;
        private System.Windows.Forms.Label lb_aluno;
        private System.Windows.Forms.Label lb_matricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}