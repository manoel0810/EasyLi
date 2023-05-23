namespace biblioteca
{
    partial class F_ConcluirAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ConcluirAgendamento));
            this.dgv_agenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.tb_responsavel = new System.Windows.Forms.TextBox();
            this.tb_periodo = new System.Windows.Forms.TextBox();
            this.tb_aula = new System.Windows.Forms.TextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_turma = new System.Windows.Forms.TextBox();
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
            this.dgv_agenda.Location = new System.Drawing.Point(414, 3);
            this.dgv_agenda.MultiSelect = false;
            this.dgv_agenda.Name = "dgv_agenda";
            this.dgv_agenda.ReadOnly = true;
            this.dgv_agenda.RowHeadersVisible = false;
            this.dgv_agenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_agenda.Size = new System.Drawing.Size(527, 543);
            this.dgv_agenda.TabIndex = 2;
            this.dgv_agenda.TabStop = false;
            this.dgv_agenda.SelectionChanged += new System.EventHandler(this.dgv_agenda_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Responsável";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Período";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aula(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmar.Location = new System.Drawing.Point(324, 516);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(81, 21);
            this.btn_confirmar.TabIndex = 1;
            this.btn_confirmar.Text = "Finalizar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(243, 516);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(81, 21);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data";
            // 
            // tb_data
            // 
            this.tb_data.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_data.Location = new System.Drawing.Point(152, 162);
            this.tb_data.Name = "tb_data";
            this.tb_data.ReadOnly = true;
            this.tb_data.Size = new System.Drawing.Size(100, 20);
            this.tb_data.TabIndex = 12;
            this.tb_data.TabStop = false;
            // 
            // tb_tipo
            // 
            this.tb_tipo.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_tipo.Location = new System.Drawing.Point(12, 114);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.ReadOnly = true;
            this.tb_tipo.Size = new System.Drawing.Size(123, 20);
            this.tb_tipo.TabIndex = 13;
            this.tb_tipo.TabStop = false;
            // 
            // tb_responsavel
            // 
            this.tb_responsavel.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_responsavel.Location = new System.Drawing.Point(12, 66);
            this.tb_responsavel.Name = "tb_responsavel";
            this.tb_responsavel.ReadOnly = true;
            this.tb_responsavel.Size = new System.Drawing.Size(393, 20);
            this.tb_responsavel.TabIndex = 14;
            this.tb_responsavel.TabStop = false;
            // 
            // tb_periodo
            // 
            this.tb_periodo.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_periodo.Location = new System.Drawing.Point(152, 114);
            this.tb_periodo.Name = "tb_periodo";
            this.tb_periodo.ReadOnly = true;
            this.tb_periodo.Size = new System.Drawing.Size(100, 20);
            this.tb_periodo.TabIndex = 15;
            this.tb_periodo.TabStop = false;
            // 
            // tb_aula
            // 
            this.tb_aula.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_aula.Location = new System.Drawing.Point(280, 114);
            this.tb_aula.Name = "tb_aula";
            this.tb_aula.ReadOnly = true;
            this.tb_aula.Size = new System.Drawing.Size(125, 20);
            this.tb_aula.TabIndex = 16;
            this.tb_aula.TabStop = false;
            // 
            // tb_estado
            // 
            this.tb_estado.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_estado.Location = new System.Drawing.Point(12, 162);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.ReadOnly = true;
            this.tb_estado.Size = new System.Drawing.Size(123, 20);
            this.tb_estado.TabIndex = 17;
            this.tb_estado.TabStop = false;
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(12, 516);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(69, 20);
            this.tb_id.TabIndex = 18;
            this.tb_id.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Turma";
            // 
            // tb_turma
            // 
            this.tb_turma.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_turma.Location = new System.Drawing.Point(280, 162);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(125, 20);
            this.tb_turma.TabIndex = 20;
            this.tb_turma.TabStop = false;
            // 
            // F_ConcluirAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 549);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.tb_aula);
            this.Controls.Add(this.tb_periodo);
            this.Controls.Add(this.tb_responsavel);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_agenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "F_ConcluirAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão De Agenda";
            this.Load += new System.EventHandler(this.F_ConcluirAgendamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_ConcluirAgendamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_agenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.TextBox tb_responsavel;
        private System.Windows.Forms.TextBox tb_periodo;
        private System.Windows.Forms.TextBox tb_aula;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_turma;
    }
}