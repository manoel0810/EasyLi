namespace biblioteca
{
    partial class F_BuscarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BuscarAluno));
            this.dgv_buscaAlunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeAluno = new System.Windows.Forms.TextBox();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_devolvido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscaAlunos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_buscaAlunos
            // 
            this.dgv_buscaAlunos.AllowUserToAddRows = false;
            this.dgv_buscaAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buscaAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_buscaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscaAlunos.EnableHeadersVisualStyles = false;
            this.dgv_buscaAlunos.Location = new System.Drawing.Point(338, 30);
            this.dgv_buscaAlunos.MultiSelect = false;
            this.dgv_buscaAlunos.Name = "dgv_buscaAlunos";
            this.dgv_buscaAlunos.ReadOnly = true;
            this.dgv_buscaAlunos.RowHeadersVisible = false;
            this.dgv_buscaAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buscaAlunos.Size = new System.Drawing.Size(734, 501);
            this.dgv_buscaAlunos.TabIndex = 2;
            this.dgv_buscaAlunos.TabStop = false;
            this.dgv_buscaAlunos.SelectionChanged += new System.EventHandler(this.dgv_buscaAlunos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opções de filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matrícula";
            // 
            // tb_nomeAluno
            // 
            this.tb_nomeAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nomeAluno.Location = new System.Drawing.Point(9, 92);
            this.tb_nomeAluno.Name = "tb_nomeAluno";
            this.tb_nomeAluno.Size = new System.Drawing.Size(311, 20);
            this.tb_nomeAluno.TabIndex = 3;
            this.tb_nomeAluno.TextChanged += new System.EventHandler(this.tb_nomeAluno_TextChanged);
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(191, 48);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(129, 20);
            this.tb_matricula.TabIndex = 2;
            this.tb_matricula.TextChanged += new System.EventHandler(this.tb_matricula_TextChanged);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(185, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Emprestado",
            "Devolvido",
            "Todos",
            "PERDIDO"});
            this.cb_estado.Location = new System.Drawing.Point(9, 47);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(145, 21);
            this.cb_estado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(13, 502);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(52, 20);
            this.tb_id.TabIndex = 12;
            this.tb_id.TabStop = false;
            // 
            // btn_devolvido
            // 
            this.btn_devolvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devolvido.Location = new System.Drawing.Point(257, 501);
            this.btn_devolvido.Name = "btn_devolvido";
            this.btn_devolvido.Size = new System.Drawing.Size(66, 23);
            this.btn_devolvido.TabIndex = 4;
            this.btn_devolvido.Text = "Devolvido";
            this.btn_devolvido.UseVisualStyleBackColor = true;
            this.btn_devolvido.Click += new System.EventHandler(this.btn_devolvido_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(625, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "ATENÇÃO, ESTE DATAGRIDVIEW SÓ RETORNA OS ULTIMOS 1200 REGISTROS, PARA EVITAR TRAV" +
    "AMENTO DO SISTEMA\r\n     TODAVIA, OS FILTROS FAZEM A CONSULTA GERAL DO BANCO DE D" +
    "ADOS (PODE CAUSAR QUEDA DE DESEMPENHO)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.tb_matricula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nomeAluno);
            this.panel1.Controls.Add(this.cb_estado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 147);
            this.panel1.TabIndex = 14;
            // 
            // F_BuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_devolvido);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_buscaAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_BuscarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Aluno";
            this.Load += new System.EventHandler(this.F_BuscarAluno_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_BuscarAluno_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscaAlunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_buscaAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeAluno;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_devolvido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}