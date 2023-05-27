namespace biblioteca
{
    partial class F_CorrecaoDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CorrecaoDados));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NomeUsuario = new System.Windows.Forms.TextBox();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.Turmas = new System.Windows.Forms.ComboBox();
            this.DataSaida = new System.Windows.Forms.MaskedTextBox();
            this.Livro = new System.Windows.Forms.TextBox();
            this.Tombo = new System.Windows.Forms.TextBox();
            this.EstadosDoLivro = new System.Windows.Forms.ComboBox();
            this.Identificacao = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.dgv_dadosCorrecao = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.EstadoDoLivro = new System.Windows.Forms.TextBox();
            this.TurmaAtual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Notas = new System.Windows.Forms.TextBox();
            this.lb_caracteres = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltroNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dadosCorrecao)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtros de busca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar por tombo/matrícula";
            // 
            // FiltroMatricula
            // 
            this.FiltroMatricula.Location = new System.Drawing.Point(173, 25);
            this.FiltroMatricula.MaxLength = 16;
            this.FiltroMatricula.Name = "FiltroMatricula";
            this.FiltroMatricula.Size = new System.Drawing.Size(139, 20);
            this.FiltroMatricula.TabIndex = 1;
            this.FiltroMatricula.TextChanged += new System.EventHandler(this.FiltroMatricula_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matrícula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Turma Atual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Livro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tombo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Estado Atual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "ID";
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NomeUsuario.Location = new System.Drawing.Point(17, 30);
            this.NomeUsuario.MaxLength = 64;
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(199, 20);
            this.NomeUsuario.TabIndex = 2;
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(222, 30);
            this.Matricula.MaxLength = 8;
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(91, 20);
            this.Matricula.TabIndex = 3;
            // 
            // Turmas
            // 
            this.Turmas.FormattingEnabled = true;
            this.Turmas.Items.AddRange(new object[] {
            "Alterar Turma"});
            this.Turmas.Location = new System.Drawing.Point(17, 76);
            this.Turmas.Name = "Turmas";
            this.Turmas.Size = new System.Drawing.Size(149, 21);
            this.Turmas.TabIndex = 4;
            this.Turmas.Text = "Alterar Turma";
            // 
            // DataSaida
            // 
            this.DataSaida.Location = new System.Drawing.Point(10, 66);
            this.DataSaida.Mask = "00/00/0000";
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.Size = new System.Drawing.Size(87, 20);
            this.DataSaida.TabIndex = 9;
            this.DataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // Livro
            // 
            this.Livro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Livro.Location = new System.Drawing.Point(10, 27);
            this.Livro.MaxLength = 64;
            this.Livro.Name = "Livro";
            this.Livro.Size = new System.Drawing.Size(225, 20);
            this.Livro.TabIndex = 7;
            // 
            // Tombo
            // 
            this.Tombo.Location = new System.Drawing.Point(241, 27);
            this.Tombo.MaxLength = 8;
            this.Tombo.Name = "Tombo";
            this.Tombo.Size = new System.Drawing.Size(77, 20);
            this.Tombo.TabIndex = 8;
            // 
            // EstadosDoLivro
            // 
            this.EstadosDoLivro.FormattingEnabled = true;
            this.EstadosDoLivro.Items.AddRange(new object[] {
            "EMPRESTADO",
            "DEVOLVIDO",
            "PERDIDO"});
            this.EstadosDoLivro.Location = new System.Drawing.Point(10, 112);
            this.EstadosDoLivro.Name = "EstadosDoLivro";
            this.EstadosDoLivro.Size = new System.Drawing.Size(98, 21);
            this.EstadosDoLivro.TabIndex = 12;
            // 
            // Identificacao
            // 
            this.Identificacao.Cursor = System.Windows.Forms.Cursors.No;
            this.Identificacao.Location = new System.Drawing.Point(252, 112);
            this.Identificacao.Name = "Identificacao";
            this.Identificacao.ReadOnly = true;
            this.Identificacao.Size = new System.Drawing.Size(66, 20);
            this.Identificacao.TabIndex = 13;
            this.Identificacao.TabStop = false;
            // 
            // Salvar
            // 
            this.Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar.Location = new System.Drawing.Point(263, 513);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 15;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.SaveClick);
            // 
            // Sair
            // 
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.Location = new System.Drawing.Point(177, 513);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 16;
            this.Sair.Text = "Voltar";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.ExitClick);
            // 
            // dgv_dadosCorrecao
            // 
            this.dgv_dadosCorrecao.AllowUserToAddRows = false;
            this.dgv_dadosCorrecao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dadosCorrecao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dadosCorrecao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dadosCorrecao.EnableHeadersVisualStyles = false;
            this.dgv_dadosCorrecao.Location = new System.Drawing.Point(347, 7);
            this.dgv_dadosCorrecao.MultiSelect = false;
            this.dgv_dadosCorrecao.Name = "dgv_dadosCorrecao";
            this.dgv_dadosCorrecao.ReadOnly = true;
            this.dgv_dadosCorrecao.RowHeadersVisible = false;
            this.dgv_dadosCorrecao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dadosCorrecao.Size = new System.Drawing.Size(585, 500);
            this.dgv_dadosCorrecao.TabIndex = 23;
            this.dgv_dadosCorrecao.TabStop = false;
            this.dgv_dadosCorrecao.SelectionChanged += new System.EventHandler(this.DGVSelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Alterar Estado";
            // 
            // EstadoDoLivro
            // 
            this.EstadoDoLivro.Cursor = System.Windows.Forms.Cursors.No;
            this.EstadoDoLivro.Location = new System.Drawing.Point(218, 66);
            this.EstadoDoLivro.Name = "EstadoDoLivro";
            this.EstadoDoLivro.ReadOnly = true;
            this.EstadoDoLivro.Size = new System.Drawing.Size(100, 20);
            this.EstadoDoLivro.TabIndex = 11;
            this.EstadoDoLivro.TabStop = false;
            // 
            // TurmaAtual
            // 
            this.TurmaAtual.Cursor = System.Windows.Forms.Cursors.No;
            this.TurmaAtual.Location = new System.Drawing.Point(180, 76);
            this.TurmaAtual.Name = "TurmaAtual";
            this.TurmaAtual.ReadOnly = true;
            this.TurmaAtual.Size = new System.Drawing.Size(131, 20);
            this.TurmaAtual.TabIndex = 5;
            this.TurmaAtual.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Alterar Turma";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "E-Mail";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(17, 119);
            this.Email.MaxLength = 128;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(295, 20);
            this.Email.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Notas:";
            // 
            // Notas
            // 
            this.Notas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Notas.Location = new System.Drawing.Point(48, 148);
            this.Notas.MaxLength = 100;
            this.Notas.Multiline = true;
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(270, 58);
            this.Notas.TabIndex = 14;
            this.Notas.TextChanged += new System.EventHandler(this.NotasChenged);
            // 
            // lb_caracteres
            // 
            this.lb_caracteres.AutoSize = true;
            this.lb_caracteres.Location = new System.Drawing.Point(267, 209);
            this.lb_caracteres.Name = "lb_caracteres";
            this.lb_caracteres.Size = new System.Drawing.Size(36, 13);
            this.lb_caracteres.TabIndex = 31;
            this.lb_caracteres.Text = "0/100";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(103, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Data devolução";
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.Location = new System.Drawing.Point(103, 66);
            this.DataDevolucao.Mask = "00/00/0000";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.Size = new System.Drawing.Size(87, 20);
            this.DataDevolucao.TabIndex = 10;
            this.DataDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FiltroNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FiltroMatricula);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 71);
            this.panel1.TabIndex = 32;
            // 
            // FiltroNome
            // 
            this.FiltroNome.Location = new System.Drawing.Point(13, 25);
            this.FiltroNome.MaxLength = 16;
            this.FiltroNome.Name = "FiltroNome";
            this.FiltroNome.Size = new System.Drawing.Size(154, 20);
            this.FiltroNome.TabIndex = 0;
            this.FiltroNome.TextChanged += new System.EventHandler(this.FiltroNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar por nome/título";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NomeUsuario);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Matricula);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TurmaAtual);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Turmas);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 154);
            this.panel2.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Dados associados ao usuário";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Livro);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Tombo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.DataDevolucao);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lb_caracteres);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.Notas);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.DataSaida);
            this.panel3.Controls.Add(this.EstadosDoLivro);
            this.panel3.Controls.Add(this.EstadoDoLivro);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.Identificacao);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(12, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 239);
            this.panel3.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(23, 259);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Dados associados ao livro";
            // 
            // F_CorrecaoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 545);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_dadosCorrecao);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CorrecaoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correção de dados";
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_CorrecaoDados_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dadosCorrecao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FiltroMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NomeUsuario;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.ComboBox Turmas;
        private System.Windows.Forms.MaskedTextBox DataSaida;
        private System.Windows.Forms.TextBox Livro;
        private System.Windows.Forms.TextBox Tombo;
        private System.Windows.Forms.ComboBox EstadosDoLivro;
        private System.Windows.Forms.TextBox Identificacao;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.DataGridView dgv_dadosCorrecao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EstadoDoLivro;
        private System.Windows.Forms.TextBox TurmaAtual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Notas;
        private System.Windows.Forms.Label lb_caracteres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox DataDevolucao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FiltroNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
    }
}