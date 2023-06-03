namespace biblioteca.Forms
{
    partial class GetDatabaseInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetDatabaseInformation));
            this.Dados = new System.Windows.Forms.DataGridView();
            this.Filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // Dados
            // 
            this.Dados.AllowUserToAddRows = false;
            this.Dados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dados.EnableHeadersVisualStyles = false;
            this.Dados.Location = new System.Drawing.Point(5, 57);
            this.Dados.MultiSelect = false;
            this.Dados.Name = "Dados";
            this.Dados.ReadOnly = true;
            this.Dados.RowHeadersVisible = false;
            this.Dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dados.Size = new System.Drawing.Size(471, 149);
            this.Dados.TabIndex = 4;
            this.Dados.TabStop = false;
            this.Dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dados_CellDoubleClick);
            this.Dados.SelectionChanged += new System.EventHandler(this.Dados_SelectionChanged);
            // 
            // Filtro
            // 
            this.Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Filtro.Location = new System.Drawing.Point(5, 25);
            this.Filtro.MaxLength = 24;
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(328, 20);
            this.Filtro.TabIndex = 0;
            this.Filtro.TextChanged += new System.EventHandler(this.Filtro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar resultados";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.ID.Location = new System.Drawing.Point(399, 25);
            this.ID.MaxLength = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(77, 20);
            this.ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "UID";
            // 
            // GetDatabaseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.Dados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetDatabaseInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "title";
            this.Load += new System.EventHandler(this.GetDatabaseInformation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GetDatabaseInformation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dados;
        private System.Windows.Forms.TextBox Filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
    }
}