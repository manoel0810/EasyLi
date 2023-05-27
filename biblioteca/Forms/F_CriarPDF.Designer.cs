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
            this.Turmas = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.MaskedTextBox();
            this.End = new System.Windows.Forms.MaskedTextBox();
            this.TodasAsTurmas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Estados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Turmas
            // 
            this.Turmas.FormattingEnabled = true;
            this.Turmas.Location = new System.Drawing.Point(12, 28);
            this.Turmas.Name = "Turmas";
            this.Turmas.Size = new System.Drawing.Size(150, 21);
            this.Turmas.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(180, 76);
            this.Start.Mask = "00/00/0000";
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(64, 20);
            this.Start.TabIndex = 3;
            this.Start.ValidatingType = typeof(System.DateTime);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(260, 76);
            this.End.Mask = "00/00/0000";
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(64, 20);
            this.End.TabIndex = 4;
            this.End.ValidatingType = typeof(System.DateTime);
            // 
            // TodasAsTurmas
            // 
            this.TodasAsTurmas.AutoSize = true;
            this.TodasAsTurmas.Location = new System.Drawing.Point(12, 76);
            this.TodasAsTurmas.Name = "TodasAsTurmas";
            this.TodasAsTurmas.Size = new System.Drawing.Size(108, 17);
            this.TodasAsTurmas.TabIndex = 2;
            this.TodasAsTurmas.Text = "Todas as Turmas";
            this.TodasAsTurmas.UseVisualStyleBackColor = true;
            this.TodasAsTurmas.CheckedChanged += new System.EventHandler(this.AllClassesCheckCheged);
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
            this.label2.Location = new System.Drawing.Point(177, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entre as Datas: (Obrigatório)";
            // 
            // Generate
            // 
            this.Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate.Location = new System.Drawing.Point(249, 140);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Gerar";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.GenerateClick);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(170, 140);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Voltar";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(12, 111);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(312, 23);
            this.Progress.TabIndex = 8;
            // 
            // Estados
            // 
            this.Estados.FormattingEnabled = true;
            this.Estados.Items.AddRange(new object[] {
            "Emprestado",
            "Devolvido",
            "PERDIDO",
            "BLOQUEADO"});
            this.Estados.Location = new System.Drawing.Point(174, 28);
            this.Estados.Name = "Estados";
            this.Estados.Size = new System.Drawing.Size(150, 21);
            this.Estados.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 12);
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
            this.ClientSize = new System.Drawing.Size(335, 169);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Estados);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TodasAsTurmas);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_CriarPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar PDF";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Turmas;
        private System.Windows.Forms.MaskedTextBox Start;
        private System.Windows.Forms.MaskedTextBox End;
        private System.Windows.Forms.CheckBox TodasAsTurmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.ComboBox Estados;
        private System.Windows.Forms.Label label3;
    }
}