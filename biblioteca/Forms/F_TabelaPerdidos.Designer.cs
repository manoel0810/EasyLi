namespace biblioteca
{
    partial class F_TabelaPerdidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TabelaPerdidos));
            this.dgv_LivrosPerdidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LivrosPerdidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LivrosPerdidos
            // 
            this.dgv_LivrosPerdidos.AllowUserToAddRows = false;
            this.dgv_LivrosPerdidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LivrosPerdidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LivrosPerdidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LivrosPerdidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LivrosPerdidos.EnableHeadersVisualStyles = false;
            this.dgv_LivrosPerdidos.Location = new System.Drawing.Point(0, 0);
            this.dgv_LivrosPerdidos.MultiSelect = false;
            this.dgv_LivrosPerdidos.Name = "dgv_LivrosPerdidos";
            this.dgv_LivrosPerdidos.ReadOnly = true;
            this.dgv_LivrosPerdidos.RowHeadersVisible = false;
            this.dgv_LivrosPerdidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LivrosPerdidos.Size = new System.Drawing.Size(996, 556);
            this.dgv_LivrosPerdidos.TabIndex = 4;
            this.dgv_LivrosPerdidos.TabStop = false;
            // 
            // F_TabelaPerdidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 556);
            this.Controls.Add(this.dgv_LivrosPerdidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_TabelaPerdidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros Perdidos";
            this.Load += new System.EventHandler(this.F_TabelaPerdidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LivrosPerdidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LivrosPerdidos;
    }
}