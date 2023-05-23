namespace biblioteca
{
    partial class F_AlterarDadosEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AlterarDadosEventos));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.mas_termina = new System.Windows.Forms.MaskedTextBox();
            this.mas_comeca = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_informacoesEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_nomeEvento = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.dgv_alterarEventos = new System.Windows.Forms.DataGridView();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alterarEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(2, 503);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(58, 20);
            this.tb_id.TabIndex = 34;
            this.tb_id.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Estado";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(141, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.Location = new System.Drawing.Point(303, 503);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 29;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // mas_termina
            // 
            this.mas_termina.Location = new System.Drawing.Point(119, 302);
            this.mas_termina.Mask = "00/00/0000";
            this.mas_termina.Name = "mas_termina";
            this.mas_termina.Size = new System.Drawing.Size(84, 20);
            this.mas_termina.TabIndex = 28;
            this.mas_termina.TabStop = false;
            this.mas_termina.ValidatingType = typeof(System.DateTime);
            // 
            // mas_comeca
            // 
            this.mas_comeca.Location = new System.Drawing.Point(12, 302);
            this.mas_comeca.Mask = "00/00/0000";
            this.mas_comeca.Name = "mas_comeca";
            this.mas_comeca.Size = new System.Drawing.Size(84, 20);
            this.mas_comeca.TabIndex = 27;
            this.mas_comeca.TabStop = false;
            this.mas_comeca.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Termina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Começa";
            // 
            // tb_local
            // 
            this.tb_local.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_local.Location = new System.Drawing.Point(12, 221);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(366, 20);
            this.tb_local.TabIndex = 24;
            this.tb_local.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Local";
            // 
            // tb_informacoesEvento
            // 
            this.tb_informacoesEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_informacoesEvento.Location = new System.Drawing.Point(12, 97);
            this.tb_informacoesEvento.Multiline = true;
            this.tb_informacoesEvento.Name = "tb_informacoesEvento";
            this.tb_informacoesEvento.Size = new System.Drawing.Size(366, 81);
            this.tb_informacoesEvento.TabIndex = 22;
            this.tb_informacoesEvento.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Informações do Evento";
            // 
            // tb_nome
            // 
            this.tb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nome.Location = new System.Drawing.Point(12, 34);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(366, 20);
            this.tb_nome.TabIndex = 20;
            this.tb_nome.TabStop = false;
            // 
            // tb_nomeEvento
            // 
            this.tb_nomeEvento.AutoSize = true;
            this.tb_nomeEvento.Location = new System.Drawing.Point(9, 18);
            this.tb_nomeEvento.Name = "tb_nomeEvento";
            this.tb_nomeEvento.Size = new System.Drawing.Size(87, 13);
            this.tb_nomeEvento.TabIndex = 19;
            this.tb_nomeEvento.Text = "Nome do Evento";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Ativo",
            "Finalizado"});
            this.cb_estado.Location = new System.Drawing.Point(257, 302);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 21);
            this.cb_estado.TabIndex = 35;
            // 
            // dgv_alterarEventos
            // 
            this.dgv_alterarEventos.AllowUserToAddRows = false;
            this.dgv_alterarEventos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alterarEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alterarEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alterarEventos.EnableHeadersVisualStyles = false;
            this.dgv_alterarEventos.Location = new System.Drawing.Point(389, 2);
            this.dgv_alterarEventos.MultiSelect = false;
            this.dgv_alterarEventos.Name = "dgv_alterarEventos";
            this.dgv_alterarEventos.ReadOnly = true;
            this.dgv_alterarEventos.RowHeadersVisible = false;
            this.dgv_alterarEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alterarEventos.Size = new System.Drawing.Size(507, 534);
            this.dgv_alterarEventos.TabIndex = 36;
            this.dgv_alterarEventos.TabStop = false;
            this.dgv_alterarEventos.SelectionChanged += new System.EventHandler(this.dgv_alterarEventos_SelectionChanged);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(222, 503);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 37;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // F_AlterarDadosEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 538);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.dgv_alterarEventos);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_alterar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_AlterarDadosEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Eventos";
            this.Load += new System.EventHandler(this.F_AlterarDadosEventos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_AlterarDadosEventos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alterarEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.MaskedTextBox mas_termina;
        private System.Windows.Forms.MaskedTextBox mas_comeca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_informacoesEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label tb_nomeEvento;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.DataGridView dgv_alterarEventos;
        private System.Windows.Forms.Button btn_excluir;
    }
}