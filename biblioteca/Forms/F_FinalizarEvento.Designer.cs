namespace biblioteca
{
    partial class F_FinalizarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_FinalizarEvento));
            this.dgv_finalizarEventos = new System.Windows.Forms.DataGridView();
            this.tb_nomeEvento = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_informacoesEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mas_comeca = new System.Windows.Forms.MaskedTextBox();
            this.mas_termina = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_finalizarEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_finalizarEventos
            // 
            this.dgv_finalizarEventos.AllowUserToAddRows = false;
            this.dgv_finalizarEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_finalizarEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_finalizarEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_finalizarEventos.EnableHeadersVisualStyles = false;
            this.dgv_finalizarEventos.Location = new System.Drawing.Point(391, 2);
            this.dgv_finalizarEventos.MultiSelect = false;
            this.dgv_finalizarEventos.Name = "dgv_finalizarEventos";
            this.dgv_finalizarEventos.ReadOnly = true;
            this.dgv_finalizarEventos.RowHeadersVisible = false;
            this.dgv_finalizarEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_finalizarEventos.Size = new System.Drawing.Size(507, 534);
            this.dgv_finalizarEventos.TabIndex = 2;
            this.dgv_finalizarEventos.TabStop = false;
            this.dgv_finalizarEventos.SelectionChanged += new System.EventHandler(this.dgv_finalizarEventos_SelectionChanged);
            // 
            // tb_nomeEvento
            // 
            this.tb_nomeEvento.AutoSize = true;
            this.tb_nomeEvento.Location = new System.Drawing.Point(11, 59);
            this.tb_nomeEvento.Name = "tb_nomeEvento";
            this.tb_nomeEvento.Size = new System.Drawing.Size(87, 13);
            this.tb_nomeEvento.TabIndex = 3;
            this.tb_nomeEvento.Text = "Nome do Evento";
            // 
            // tb_nome
            // 
            this.tb_nome.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nome.Location = new System.Drawing.Point(14, 75);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            this.tb_nome.Size = new System.Drawing.Size(366, 20);
            this.tb_nome.TabIndex = 4;
            this.tb_nome.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Informações do Evento";
            // 
            // tb_informacoesEvento
            // 
            this.tb_informacoesEvento.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_informacoesEvento.Location = new System.Drawing.Point(12, 120);
            this.tb_informacoesEvento.Multiline = true;
            this.tb_informacoesEvento.Name = "tb_informacoesEvento";
            this.tb_informacoesEvento.ReadOnly = true;
            this.tb_informacoesEvento.Size = new System.Drawing.Size(366, 81);
            this.tb_informacoesEvento.TabIndex = 6;
            this.tb_informacoesEvento.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Local";
            // 
            // tb_local
            // 
            this.tb_local.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_local.Location = new System.Drawing.Point(14, 227);
            this.tb_local.Name = "tb_local";
            this.tb_local.ReadOnly = true;
            this.tb_local.Size = new System.Drawing.Size(366, 20);
            this.tb_local.TabIndex = 8;
            this.tb_local.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Começa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Termina";
            // 
            // mas_comeca
            // 
            this.mas_comeca.Cursor = System.Windows.Forms.Cursors.No;
            this.mas_comeca.Location = new System.Drawing.Point(14, 274);
            this.mas_comeca.Mask = "00/00/0000";
            this.mas_comeca.Name = "mas_comeca";
            this.mas_comeca.ReadOnly = true;
            this.mas_comeca.Size = new System.Drawing.Size(84, 20);
            this.mas_comeca.TabIndex = 11;
            this.mas_comeca.TabStop = false;
            this.mas_comeca.ValidatingType = typeof(System.DateTime);
            // 
            // mas_termina
            // 
            this.mas_termina.Cursor = System.Windows.Forms.Cursors.No;
            this.mas_termina.Location = new System.Drawing.Point(121, 274);
            this.mas_termina.Mask = "00/00/0000";
            this.mas_termina.Name = "mas_termina";
            this.mas_termina.ReadOnly = true;
            this.mas_termina.Size = new System.Drawing.Size(84, 20);
            this.mas_termina.TabIndex = 12;
            this.mas_termina.TabStop = false;
            this.mas_termina.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(310, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(224, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_estado
            // 
            this.tb_estado.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_estado.Location = new System.Drawing.Point(280, 274);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.ReadOnly = true;
            this.tb_estado.Size = new System.Drawing.Size(100, 20);
            this.tb_estado.TabIndex = 15;
            this.tb_estado.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(12, 507);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(58, 20);
            this.tb_id.TabIndex = 18;
            this.tb_id.TabStop = false;
            // 
            // F_FinalizarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 538);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mas_termina);
            this.Controls.Add(this.mas_comeca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_local);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_informacoesEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_nomeEvento);
            this.Controls.Add(this.dgv_finalizarEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_FinalizarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Eventos";
            this.Load += new System.EventHandler(this.F_FinalizarEvento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_FinalizarEvento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_finalizarEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_finalizarEventos;
        private System.Windows.Forms.Label tb_nomeEvento;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_informacoesEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mas_comeca;
        private System.Windows.Forms.MaskedTextBox mas_termina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_id;
    }
}