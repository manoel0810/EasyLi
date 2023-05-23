namespace biblioteca
{
    partial class F_CriarPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CriarPDF));
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.mask_data1 = new System.Windows.Forms.MaskedTextBox();
            this.mask_data2 = new System.Windows.Forms.MaskedTextBox();
            this.cb_todasTurmas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pgb_pdf = new System.Windows.Forms.ProgressBar();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(12, 28);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(150, 21);
            this.cb_turma.TabIndex = 1;
            // 
            // mask_data1
            // 
            this.mask_data1.Location = new System.Drawing.Point(251, 29);
            this.mask_data1.Mask = "00/00/0000";
            this.mask_data1.Name = "mask_data1";
            this.mask_data1.Size = new System.Drawing.Size(64, 20);
            this.mask_data1.TabIndex = 3;
            this.mask_data1.ValidatingType = typeof(System.DateTime);
            // 
            // mask_data2
            // 
            this.mask_data2.Location = new System.Drawing.Point(331, 29);
            this.mask_data2.Mask = "00/00/0000";
            this.mask_data2.Name = "mask_data2";
            this.mask_data2.Size = new System.Drawing.Size(64, 20);
            this.mask_data2.TabIndex = 4;
            this.mask_data2.ValidatingType = typeof(System.DateTime);
            // 
            // cb_todasTurmas
            // 
            this.cb_todasTurmas.AutoSize = true;
            this.cb_todasTurmas.Location = new System.Drawing.Point(12, 55);
            this.cb_todasTurmas.Name = "cb_todasTurmas";
            this.cb_todasTurmas.Size = new System.Drawing.Size(108, 17);
            this.cb_todasTurmas.TabIndex = 2;
            this.cb_todasTurmas.Text = "Todas as Turmas";
            this.cb_todasTurmas.UseVisualStyleBackColor = true;
            this.cb_todasTurmas.CheckedChanged += new System.EventHandler(this.cb_todasTurmas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entre as Datas: (Obrigatório)";
            // 
            // btn_gerar
            // 
            this.btn_gerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerar.Location = new System.Drawing.Point(339, 183);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(75, 23);
            this.btn_gerar.TabIndex = 6;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(260, 183);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pgb_pdf
            // 
            this.pgb_pdf.Location = new System.Drawing.Point(12, 145);
            this.pgb_pdf.Name = "pgb_pdf";
            this.pgb_pdf.Size = new System.Drawing.Size(402, 23);
            this.pgb_pdf.TabIndex = 8;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Emprestado",
            "Devolvido",
            "PERDIDO",
            "BLOQUEADO"});
            this.cb_estado.Location = new System.Drawing.Point(12, 105);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(150, 21);
            this.cb_estado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado (Obrigatório)";
            // 
            // F_CriarPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.pgb_pdf);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_gerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_todasTurmas);
            this.Controls.Add(this.mask_data2);
            this.Controls.Add(this.mask_data1);
            this.Controls.Add(this.cb_turma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_CriarPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar PDF";
            this.Load += new System.EventHandler(this.F_CriarPDF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.MaskedTextBox mask_data1;
        private System.Windows.Forms.MaskedTextBox mask_data2;
        private System.Windows.Forms.CheckBox cb_todasTurmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ProgressBar pgb_pdf;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label3;
    }
}