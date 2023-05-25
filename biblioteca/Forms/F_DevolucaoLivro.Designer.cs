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
            this.NomeUsuario = new System.Windows.Forms.TextBox();
            this.Livro = new System.Windows.Forms.TextBox();
            this.Turma = new System.Windows.Forms.TextBox();
            this.Devolvido = new System.Windows.Forms.CheckBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FiltroNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FiltroMatricula = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosPdevol)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgv_livrosPdevol.Location = new System.Drawing.Point(360, 11);
            this.dgv_livrosPdevol.MultiSelect = false;
            this.dgv_livrosPdevol.Name = "dgv_livrosPdevol";
            this.dgv_livrosPdevol.ReadOnly = true;
            this.dgv_livrosPdevol.RowHeadersVisible = false;
            this.dgv_livrosPdevol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livrosPdevol.Size = new System.Drawing.Size(444, 278);
            this.dgv_livrosPdevol.TabIndex = 0;
            this.dgv_livrosPdevol.SelectionChanged += new System.EventHandler(this.DGVSelectionChenged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Turma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data ";
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.BackColor = System.Drawing.Color.White;
            this.NomeUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.NomeUsuario.Location = new System.Drawing.Point(9, 117);
            this.NomeUsuario.MaxLength = 64;
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.ReadOnly = true;
            this.NomeUsuario.Size = new System.Drawing.Size(341, 20);
            this.NomeUsuario.TabIndex = 5;
            this.NomeUsuario.TabStop = false;
            // 
            // Livro
            // 
            this.Livro.BackColor = System.Drawing.Color.White;
            this.Livro.Cursor = System.Windows.Forms.Cursors.No;
            this.Livro.Location = new System.Drawing.Point(9, 158);
            this.Livro.MaxLength = 64;
            this.Livro.Name = "Livro";
            this.Livro.ReadOnly = true;
            this.Livro.Size = new System.Drawing.Size(341, 20);
            this.Livro.TabIndex = 6;
            this.Livro.TabStop = false;
            // 
            // Turma
            // 
            this.Turma.BackColor = System.Drawing.Color.White;
            this.Turma.Cursor = System.Windows.Forms.Cursors.No;
            this.Turma.Location = new System.Drawing.Point(9, 199);
            this.Turma.MaxLength = 16;
            this.Turma.Name = "Turma";
            this.Turma.ReadOnly = true;
            this.Turma.Size = new System.Drawing.Size(154, 20);
            this.Turma.TabIndex = 7;
            this.Turma.TabStop = false;
            // 
            // Devolvido
            // 
            this.Devolvido.AutoSize = true;
            this.Devolvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Devolvido.Location = new System.Drawing.Point(9, 240);
            this.Devolvido.Name = "Devolvido";
            this.Devolvido.Size = new System.Drawing.Size(74, 17);
            this.Devolvido.TabIndex = 2;
            this.Devolvido.Text = "Devolvido";
            this.Devolvido.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            this.Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirmar.Location = new System.Drawing.Point(729, 297);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 3;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.ConfirmClick);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(648, 297);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Voltar";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Cursor = System.Windows.Forms.Cursors.No;
            this.ID.Location = new System.Drawing.Point(286, 238);
            this.ID.MaxLength = 10000;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(64, 20);
            this.ID.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Matrícula";
            // 
            // tb_matricula
            // 
            this.tb_matricula.BackColor = System.Drawing.Color.White;
            this.tb_matricula.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_matricula.Location = new System.Drawing.Point(169, 199);
            this.tb_matricula.MaxLength = 8;
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.ReadOnly = true;
            this.tb_matricula.Size = new System.Drawing.Size(91, 20);
            this.tb_matricula.TabIndex = 8;
            this.tb_matricula.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Filtros (Escolha somente um método)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome do usuário ou livro";
            // 
            // FiltroNome
            // 
            this.FiltroNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltroNome.Location = new System.Drawing.Point(9, 29);
            this.FiltroNome.MaxLength = 16;
            this.FiltroNome.Name = "FiltroNome";
            this.FiltroNome.Size = new System.Drawing.Size(221, 20);
            this.FiltroNome.TabIndex = 0;
            this.FiltroNome.TextChanged += new System.EventHandler(this.FilterNameChenged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Matrícula ou tombo";
            // 
            // FiltroMatricula
            // 
            this.FiltroMatricula.Location = new System.Drawing.Point(236, 29);
            this.FiltroMatricula.MaxLength = 8;
            this.FiltroMatricula.Name = "FiltroMatricula";
            this.FiltroMatricula.Size = new System.Drawing.Size(98, 20);
            this.FiltroMatricula.TabIndex = 1;
            this.FiltroMatricula.TextChanged += new System.EventHandler(this.FilterMatriculaChenged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FiltroNome);
            this.panel1.Controls.Add(this.FiltroMatricula);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 59);
            this.panel1.TabIndex = 20;
            // 
            // Data
            // 
            this.Data.BackColor = System.Drawing.Color.White;
            this.Data.Location = new System.Drawing.Point(266, 199);
            this.Data.Mask = "00/00/0000";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Size = new System.Drawing.Size(84, 20);
            this.Data.TabIndex = 21;
            // 
            // F_DevolucaoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 332);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Devolvido);
            this.Controls.Add(this.Turma);
            this.Controls.Add(this.Livro);
            this.Controls.Add(this.NomeUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_livrosPdevol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_DevolucaoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução de Livros";
            this.Load += new System.EventHandler(this.F_DevolucaoLivro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosPdevol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_livrosPdevol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeUsuario;
        private System.Windows.Forms.TextBox Livro;
        private System.Windows.Forms.TextBox Turma;
        private System.Windows.Forms.CheckBox Devolvido;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FiltroNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FiltroMatricula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox Data;
    }
}