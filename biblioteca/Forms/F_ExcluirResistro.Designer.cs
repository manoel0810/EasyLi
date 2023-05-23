namespace biblioteca
{
    partial class F_ExcluirResistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ExcluirResistro));
            this.dgv_excluir = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nomeAluno = new System.Windows.Forms.TextBox();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_nomeLivro = new System.Windows.Forms.TextBox();
            this.tb_tombo = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_notas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Fnome = new System.Windows.Forms.TextBox();
            this.tb_Fmatricula = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excluir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_excluir
            // 
            this.dgv_excluir.AllowUserToAddRows = false;
            this.dgv_excluir.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_excluir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_excluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_excluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_excluir.EnableHeadersVisualStyles = false;
            this.dgv_excluir.Location = new System.Drawing.Point(360, 26);
            this.dgv_excluir.MultiSelect = false;
            this.dgv_excluir.Name = "dgv_excluir";
            this.dgv_excluir.ReadOnly = true;
            this.dgv_excluir.RowHeadersVisible = false;
            this.dgv_excluir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_excluir.Size = new System.Drawing.Size(756, 554);
            this.dgv_excluir.TabIndex = 1;
            this.dgv_excluir.SelectionChanged += new System.EventHandler(this.dgv_excluir_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do Livro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tombo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID";
            // 
            // tb_nomeAluno
            // 
            this.tb_nomeAluno.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nomeAluno.Location = new System.Drawing.Point(12, 165);
            this.tb_nomeAluno.Name = "tb_nomeAluno";
            this.tb_nomeAluno.ReadOnly = true;
            this.tb_nomeAluno.Size = new System.Drawing.Size(342, 20);
            this.tb_nomeAluno.TabIndex = 10;
            // 
            // tb_turma
            // 
            this.tb_turma.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_turma.Location = new System.Drawing.Point(119, 221);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(129, 20);
            this.tb_turma.TabIndex = 11;
            // 
            // tb_matricula
            // 
            this.tb_matricula.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_matricula.Location = new System.Drawing.Point(13, 221);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.ReadOnly = true;
            this.tb_matricula.Size = new System.Drawing.Size(100, 20);
            this.tb_matricula.TabIndex = 12;
            // 
            // tb_status
            // 
            this.tb_status.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_status.Location = new System.Drawing.Point(254, 221);
            this.tb_status.Name = "tb_status";
            this.tb_status.ReadOnly = true;
            this.tb_status.Size = new System.Drawing.Size(100, 20);
            this.tb_status.TabIndex = 13;
            // 
            // tb_nomeLivro
            // 
            this.tb_nomeLivro.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nomeLivro.Location = new System.Drawing.Point(12, 269);
            this.tb_nomeLivro.Name = "tb_nomeLivro";
            this.tb_nomeLivro.ReadOnly = true;
            this.tb_nomeLivro.Size = new System.Drawing.Size(342, 20);
            this.tb_nomeLivro.TabIndex = 14;
            // 
            // tb_tombo
            // 
            this.tb_tombo.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_tombo.Location = new System.Drawing.Point(13, 319);
            this.tb_tombo.Name = "tb_tombo";
            this.tb_tombo.ReadOnly = true;
            this.tb_tombo.Size = new System.Drawing.Size(100, 20);
            this.tb_tombo.TabIndex = 15;
            // 
            // tb_data
            // 
            this.tb_data.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_data.Location = new System.Drawing.Point(120, 319);
            this.tb_data.Name = "tb_data";
            this.tb_data.ReadOnly = true;
            this.tb_data.Size = new System.Drawing.Size(100, 20);
            this.tb_data.TabIndex = 16;
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(15, 541);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(73, 20);
            this.tb_id.TabIndex = 17;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(269, 557);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 18;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(188, 557);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 19;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(625, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "ATENÇÃO, ESTE DATAGRIDVIEW SÓ RETORNA OS ULTIMOS 1200 REGISTROS, PARA EVITAR TRAV" +
    "AMENTO DO SISTEMA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "E-Mail";
            // 
            // tb_email
            // 
            this.tb_email.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_email.Location = new System.Drawing.Point(12, 372);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(342, 20);
            this.tb_email.TabIndex = 22;
            this.tb_email.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Notas:";
            // 
            // tb_notas
            // 
            this.tb_notas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_notas.Location = new System.Drawing.Point(12, 421);
            this.tb_notas.Multiline = true;
            this.tb_notas.Name = "tb_notas";
            this.tb_notas.ReadOnly = true;
            this.tb_notas.Size = new System.Drawing.Size(342, 65);
            this.tb_notas.TabIndex = 24;
            this.tb_notas.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "FILTROS DE BUSCA:";
            // 
            // tb_Fnome
            // 
            this.tb_Fnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_Fnome.Location = new System.Drawing.Point(7, 66);
            this.tb_Fnome.Name = "tb_Fnome";
            this.tb_Fnome.Size = new System.Drawing.Size(241, 20);
            this.tb_Fnome.TabIndex = 26;
            this.tb_Fnome.TextChanged += new System.EventHandler(this.tb_Fnome_TextChanged);
            // 
            // tb_Fmatricula
            // 
            this.tb_Fmatricula.Location = new System.Drawing.Point(254, 66);
            this.tb_Fmatricula.Name = "tb_Fmatricula";
            this.tb_Fmatricula.Size = new System.Drawing.Size(100, 20);
            this.tb_Fmatricula.TabIndex = 27;
            this.tb_Fmatricula.TextChanged += new System.EventHandler(this.tb_Fmatricula_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Por Nome";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Por Matrícula";
            // 
            // F_ExcluirResistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 592);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_Fmatricula);
            this.Controls.Add(this.tb_Fnome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_notas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_tombo);
            this.Controls.Add(this.tb_nomeLivro);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.tb_nomeAluno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_excluir);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ExcluirResistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Dados";
            this.Load += new System.EventHandler(this.F_ExcluirResistro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_ExcluirResistro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_excluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_nomeAluno;
        private System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_nomeLivro;
        private System.Windows.Forms.TextBox tb_tombo;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_notas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Fnome;
        private System.Windows.Forms.TextBox tb_Fmatricula;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}