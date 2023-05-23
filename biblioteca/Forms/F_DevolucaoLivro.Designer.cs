namespace biblioteca
{
    partial class F_DevolucaoLivro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DevolucaoLivro));
            this.dgv_livrosPdevol = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomeAluno = new System.Windows.Forms.TextBox();
            this.tb_nomeLivro = new System.Windows.Forms.TextBox();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.cb_devolvido = new System.Windows.Forms.CheckBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Fnome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Fmatricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosPdevol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_livrosPdevol
            // 
            this.dgv_livrosPdevol.AllowUserToAddRows = false;
            this.dgv_livrosPdevol.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_livrosPdevol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_livrosPdevol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livrosPdevol.EnableHeadersVisualStyles = false;
            this.dgv_livrosPdevol.Location = new System.Drawing.Point(359, 11);
            this.dgv_livrosPdevol.MultiSelect = false;
            this.dgv_livrosPdevol.Name = "dgv_livrosPdevol";
            this.dgv_livrosPdevol.ReadOnly = true;
            this.dgv_livrosPdevol.RowHeadersVisible = false;
            this.dgv_livrosPdevol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livrosPdevol.Size = new System.Drawing.Size(592, 517);
            this.dgv_livrosPdevol.TabIndex = 0;
            this.dgv_livrosPdevol.SelectionChanged += new System.EventHandler(this.dgv_livrosPdevol_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Turma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status:";
            // 
            // tb_nomeAluno
            // 
            this.tb_nomeAluno.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nomeAluno.Location = new System.Drawing.Point(9, 148);
            this.tb_nomeAluno.Name = "tb_nomeAluno";
            this.tb_nomeAluno.ReadOnly = true;
            this.tb_nomeAluno.Size = new System.Drawing.Size(341, 20);
            this.tb_nomeAluno.TabIndex = 6;
            this.tb_nomeAluno.TabStop = false;
            // 
            // tb_nomeLivro
            // 
            this.tb_nomeLivro.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nomeLivro.Location = new System.Drawing.Point(9, 206);
            this.tb_nomeLivro.Name = "tb_nomeLivro";
            this.tb_nomeLivro.ReadOnly = true;
            this.tb_nomeLivro.Size = new System.Drawing.Size(341, 20);
            this.tb_nomeLivro.TabIndex = 7;
            this.tb_nomeLivro.TabStop = false;
            // 
            // tb_turma
            // 
            this.tb_turma.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_turma.Location = new System.Drawing.Point(9, 296);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(154, 20);
            this.tb_turma.TabIndex = 8;
            this.tb_turma.TabStop = false;
            // 
            // tb_data
            // 
            this.tb_data.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_data.Location = new System.Drawing.Point(239, 296);
            this.tb_data.Name = "tb_data";
            this.tb_data.ReadOnly = true;
            this.tb_data.Size = new System.Drawing.Size(111, 20);
            this.tb_data.TabIndex = 9;
            this.tb_data.TabStop = false;
            // 
            // tb_status
            // 
            this.tb_status.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_status.Location = new System.Drawing.Point(9, 360);
            this.tb_status.Name = "tb_status";
            this.tb_status.ReadOnly = true;
            this.tb_status.Size = new System.Drawing.Size(111, 20);
            this.tb_status.TabIndex = 10;
            this.tb_status.TabStop = false;
            // 
            // cb_devolvido
            // 
            this.cb_devolvido.AutoSize = true;
            this.cb_devolvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_devolvido.Location = new System.Drawing.Point(17, 421);
            this.cb_devolvido.Name = "cb_devolvido";
            this.cb_devolvido.Size = new System.Drawing.Size(74, 17);
            this.cb_devolvido.TabIndex = 1;
            this.cb_devolvido.Text = "Devolvido";
            this.cb_devolvido.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmar.Location = new System.Drawing.Point(275, 493);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Location = new System.Drawing.Point(194, 493);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Voltar";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(286, 360);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(64, 20);
            this.tb_id.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matrícula";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_matricula.Location = new System.Drawing.Point(141, 360);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.ReadOnly = true;
            this.tb_matricula.Size = new System.Drawing.Size(111, 20);
            this.tb_matricula.TabIndex = 14;
            this.tb_matricula.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Filtros (Escolha somente um método)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome do Aluno";
            // 
            // tb_Fnome
            // 
            this.tb_Fnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Fnome.Location = new System.Drawing.Point(12, 67);
            this.tb_Fnome.Name = "tb_Fnome";
            this.tb_Fnome.Size = new System.Drawing.Size(242, 20);
            this.tb_Fnome.TabIndex = 17;
            this.tb_Fnome.TextChanged += new System.EventHandler(this.tb_Fnome_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Matrícula";
            // 
            // tb_Fmatricula
            // 
            this.tb_Fmatricula.Location = new System.Drawing.Point(260, 67);
            this.tb_Fmatricula.Name = "tb_Fmatricula";
            this.tb_Fmatricula.Size = new System.Drawing.Size(90, 20);
            this.tb_Fmatricula.TabIndex = 19;
            this.tb_Fmatricula.TextChanged += new System.EventHandler(this.tb_Fmatricula_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(275, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // F_DevolucaoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Fmatricula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_Fnome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.cb_devolvido);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.tb_nomeLivro);
            this.Controls.Add(this.tb_nomeAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_livrosPdevol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_DevolucaoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução de Livros";
            this.Load += new System.EventHandler(this.F_DevolucaoLivro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_DevolucaoLivro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosPdevol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_livrosPdevol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nomeAluno;
        private System.Windows.Forms.TextBox tb_nomeLivro;
        private System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.CheckBox cb_devolvido;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Fnome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Fmatricula;
        private System.Windows.Forms.Button button1;
    }
}