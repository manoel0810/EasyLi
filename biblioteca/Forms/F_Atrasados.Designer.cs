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
            this.Exit = new System.Windows.Forms.Button();
            this.OperationMode = new System.Windows.Forms.ComboBox();
            this.ReportList = new System.Windows.Forms.Button();
            this.lb_modo = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutdataDays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RenewRegistry = new System.Windows.Forms.Button();
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
            this.dgv_atrasados.Size = new System.Drawing.Size(796, 339);
            this.dgv_atrasados.TabIndex = 3;
            this.dgv_atrasados.TabStop = false;
            this.dgv_atrasados.SelectionChanged += new System.EventHandler(this.DGVSelectionChenged);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(709, 383);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(99, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Voltar";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // OperationMode
            // 
            this.OperationMode.AutoCompleteCustomSource.AddRange(new string[] {
            "Mais de 8(oito) dias",
            "Mais de 15(quinze) dias"});
            this.OperationMode.FormattingEnabled = true;
            this.OperationMode.Items.AddRange(new object[] {
            "Mais de 8(oito) dias",
            "Mais de 15(quinze) dias"});
            this.OperationMode.Location = new System.Drawing.Point(15, 356);
            this.OperationMode.Name = "OperationMode";
            this.OperationMode.Size = new System.Drawing.Size(160, 21);
            this.OperationMode.TabIndex = 3;
            this.OperationMode.Text = "Mais de 8(oito) dias";
            this.OperationMode.SelectedIndexChanged += new System.EventHandler(this.TimeSpace);
            // 
            // ReportList
            // 
            this.ReportList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportList.Location = new System.Drawing.Point(15, 383);
            this.ReportList.Name = "ReportList";
            this.ReportList.Size = new System.Drawing.Size(160, 23);
            this.ReportList.TabIndex = 4;
            this.ReportList.Text = "Gerar Lista";
            this.ReportList.UseVisualStyleBackColor = true;
            this.ReportList.Click += new System.EventHandler(this.Report);
            // 
            // lb_modo
            // 
            this.lb_modo.AutoSize = true;
            this.lb_modo.Location = new System.Drawing.Point(181, 359);
            this.lb_modo.Name = "lb_modo";
            this.lb_modo.Size = new System.Drawing.Size(43, 13);
            this.lb_modo.TabIndex = 5;
            this.lb_modo.Text = " Modo: ";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(387, 364);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(16, 13);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dias fora: ";
            // 
            // OutdataDays
            // 
            this.OutdataDays.AutoSize = true;
            this.OutdataDays.Location = new System.Drawing.Point(401, 384);
            this.OutdataDays.Name = "OutdataDays";
            this.OutdataDays.Size = new System.Drawing.Size(13, 13);
            this.OutdataDays.TabIndex = 8;
            this.OutdataDays.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // RenewRegistry
            // 
            this.RenewRegistry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenewRegistry.Location = new System.Drawing.Point(604, 383);
            this.RenewRegistry.Name = "RenewRegistry";
            this.RenewRegistry.Size = new System.Drawing.Size(99, 23);
            this.RenewRegistry.TabIndex = 2;
            this.RenewRegistry.Text = "Renovar";
            this.RenewRegistry.UseVisualStyleBackColor = true;
            this.RenewRegistry.Click += new System.EventHandler(this.RenewBook);
            // 
            // F_Atrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 413);
            this.Controls.Add(this.RenewRegistry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutdataDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.lb_modo);
            this.Controls.Add(this.ReportList);
            this.Controls.Add(this.OperationMode);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dgv_atrasados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Atrasados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atrasados";
            this.Load += new System.EventHandler(this.F_Atrasados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atrasados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_atrasados;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox OperationMode;
        private System.Windows.Forms.Button ReportList;
        private System.Windows.Forms.Label lb_modo;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OutdataDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RenewRegistry;
    }
}