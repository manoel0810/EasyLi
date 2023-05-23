namespace biblioteca
{
    partial class F_Atrasados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Atrasados));
            this.dgv_atrasados = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.cb_tempo = new System.Windows.Forms.ComboBox();
            this.btn_GLista = new System.Windows.Forms.Button();
            this.lb_modo = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_dias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_renovar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atrasados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_atrasados
            // 
            this.dgv_atrasados.AllowUserToAddRows = false;
            this.dgv_atrasados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_atrasados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_atrasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atrasados.EnableHeadersVisualStyles = false;
            this.dgv_atrasados.Location = new System.Drawing.Point(12, 12);
            this.dgv_atrasados.MultiSelect = false;
            this.dgv_atrasados.Name = "dgv_atrasados";
            this.dgv_atrasados.ReadOnly = true;
            this.dgv_atrasados.RowHeadersVisible = false;
            this.dgv_atrasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_atrasados.Size = new System.Drawing.Size(901, 475);
            this.dgv_atrasados.TabIndex = 3;
            this.dgv_atrasados.TabStop = false;
            this.dgv_atrasados.SelectionChanged += new System.EventHandler(this.dgv_atrasados_SelectionChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(814, 516);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(99, 23);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // cb_tempo
            // 
            this.cb_tempo.AutoCompleteCustomSource.AddRange(new string[] {
            "Mais de 8(oito) dias",
            "Mais de 15(quinze) dias"});
            this.cb_tempo.FormattingEnabled = true;
            this.cb_tempo.Items.AddRange(new object[] {
            "Mais de 8(oito) dias",
            "Mais de 15(quinze) dias"});
            this.cb_tempo.Location = new System.Drawing.Point(12, 493);
            this.cb_tempo.Name = "cb_tempo";
            this.cb_tempo.Size = new System.Drawing.Size(160, 21);
            this.cb_tempo.TabIndex = 3;
            this.cb_tempo.Text = "Mais de 8(oito) dias";
            this.cb_tempo.SelectedIndexChanged += new System.EventHandler(this.cb_tempo_SelectedIndexChanged);
            // 
            // btn_GLista
            // 
            this.btn_GLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GLista.Location = new System.Drawing.Point(12, 520);
            this.btn_GLista.Name = "btn_GLista";
            this.btn_GLista.Size = new System.Drawing.Size(160, 23);
            this.btn_GLista.TabIndex = 4;
            this.btn_GLista.Text = "Gerar Lista";
            this.btn_GLista.UseVisualStyleBackColor = true;
            this.btn_GLista.Click += new System.EventHandler(this.btn_GLista_Click);
            // 
            // lb_modo
            // 
            this.lb_modo.AutoSize = true;
            this.lb_modo.Location = new System.Drawing.Point(178, 496);
            this.lb_modo.Name = "lb_modo";
            this.lb_modo.Size = new System.Drawing.Size(43, 13);
            this.lb_modo.TabIndex = 5;
            this.lb_modo.Text = " Modo: ";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(384, 501);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(16, 13);
            this.lb_nome.TabIndex = 6;
            this.lb_nome.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dias fora: ";
            // 
            // lb_dias
            // 
            this.lb_dias.AutoSize = true;
            this.lb_dias.Location = new System.Drawing.Point(398, 521);
            this.lb_dias.Name = "lb_dias";
            this.lb_dias.Size = new System.Drawing.Size(13, 13);
            this.lb_dias.TabIndex = 8;
            this.lb_dias.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // btn_renovar
            // 
            this.btn_renovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_renovar.Location = new System.Drawing.Point(709, 516);
            this.btn_renovar.Name = "btn_renovar";
            this.btn_renovar.Size = new System.Drawing.Size(99, 23);
            this.btn_renovar.TabIndex = 2;
            this.btn_renovar.Text = "Renovar";
            this.btn_renovar.UseVisualStyleBackColor = true;
            this.btn_renovar.Click += new System.EventHandler(this.btn_renovar_Click);
            // 
            // F_Atrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 551);
            this.Controls.Add(this.btn_renovar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_dias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_modo);
            this.Controls.Add(this.btn_GLista);
            this.Controls.Add(this.cb_tempo);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv_atrasados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Atrasados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atrasados";
            this.Load += new System.EventHandler(this.F_Atrasados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Atrasados_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atrasados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_atrasados;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ComboBox cb_tempo;
        private System.Windows.Forms.Button btn_GLista;
        private System.Windows.Forms.Label lb_modo;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_dias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_renovar;
    }
}