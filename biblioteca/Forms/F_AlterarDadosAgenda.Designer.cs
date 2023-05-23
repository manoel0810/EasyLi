namespace biblioteca
{
    partial class F_AlterarDadosAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AlterarDadosAgenda));
            this.dgv_agenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_responsavel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_alterarTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.cb_alterarPeriodo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_aula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_alterarEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_agenda
            // 
            this.dgv_agenda.AllowUserToAddRows = false;
            this.dgv_agenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_agenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agenda.EnableHeadersVisualStyles = false;
            this.dgv_agenda.Location = new System.Drawing.Point(417, 23);
            this.dgv_agenda.MultiSelect = false;
            this.dgv_agenda.Name = "dgv_agenda";
            this.dgv_agenda.ReadOnly = true;
            this.dgv_agenda.RowHeadersVisible = false;
            this.dgv_agenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_agenda.Size = new System.Drawing.Size(529, 521);
            this.dgv_agenda.TabIndex = 3;
            this.dgv_agenda.TabStop = false;
            this.dgv_agenda.SelectionChanged += new System.EventHandler(this.dgv_agenda_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Responsável";
            // 
            // tb_responsavel
            // 
            this.tb_responsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_responsavel.Location = new System.Drawing.Point(9, 96);
            this.tb_responsavel.Name = "tb_responsavel";
            this.tb_responsavel.Size = new System.Drawing.Size(399, 20);
            this.tb_responsavel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alterar Tipo";
            // 
            // cb_alterarTipo
            // 
            this.cb_alterarTipo.FormattingEnabled = true;
            this.cb_alterarTipo.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Gestão"});
            this.cb_alterarTipo.Location = new System.Drawing.Point(15, 201);
            this.cb_alterarTipo.Name = "cb_alterarTipo";
            this.cb_alterarTipo.Size = new System.Drawing.Size(172, 21);
            this.cb_alterarTipo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // mask_data
            // 
            this.mask_data.Location = new System.Drawing.Point(244, 203);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(100, 20);
            this.mask_data.TabIndex = 3;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // cb_alterarPeriodo
            // 
            this.cb_alterarPeriodo.FormattingEnabled = true;
            this.cb_alterarPeriodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cb_alterarPeriodo.Location = new System.Drawing.Point(15, 256);
            this.cb_alterarPeriodo.Name = "cb_alterarPeriodo";
            this.cb_alterarPeriodo.Size = new System.Drawing.Size(172, 21);
            this.cb_alterarPeriodo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Alterar Período";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Aula(s)";
            // 
            // tb_aula
            // 
            this.tb_aula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_aula.Location = new System.Drawing.Point(244, 257);
            this.tb_aula.Name = "tb_aula";
            this.tb_aula.Size = new System.Drawing.Size(164, 20);
            this.tb_aula.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Alterar Estado";
            // 
            // cb_alterarEstado
            // 
            this.cb_alterarEstado.FormattingEnabled = true;
            this.cb_alterarEstado.Items.AddRange(new object[] {
            "Ativo",
            "Finalizado"});
            this.cb_alterarEstado.Location = new System.Drawing.Point(15, 307);
            this.cb_alterarEstado.Name = "cb_alterarEstado";
            this.cb_alterarEstado.Size = new System.Drawing.Size(172, 21);
            this.cb_alterarEstado.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(6, 515);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(67, 20);
            this.tb_id.TabIndex = 23;
            this.tb_id.TabStop = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Location = new System.Drawing.Point(346, 513);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(65, 22);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(275, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(206, 513);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 22);
            this.button3.TabIndex = 9;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(244, 308);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(164, 21);
            this.cb_turmas.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Turma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(434, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(501, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "Este DataGridView Só Retorna Os Últimos 300 Registros Para Evitar Perda De Desemp" +
    "enho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Altere os dados:";
            // 
            // F_AlterarDadosAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_alterarEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_aula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_alterarPeriodo);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_alterarTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_responsavel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_agenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_AlterarDadosAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Alterar Dados";
            this.Load += new System.EventHandler(this.F_AlterarDadosAgenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_AlterarDadosAgenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_agenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_responsavel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_alterarTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.ComboBox cb_alterarPeriodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_aula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_alterarEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}