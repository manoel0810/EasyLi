﻿namespace biblioteca
{
    partial class F_TabelaEventosAtivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TabelaEventosAtivos));
            this.dgv_eventosAtivos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eventosAtivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_eventosAtivos
            // 
            this.dgv_eventosAtivos.AllowUserToAddRows = false;
            this.dgv_eventosAtivos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_eventosAtivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_eventosAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eventosAtivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_eventosAtivos.EnableHeadersVisualStyles = false;
            this.dgv_eventosAtivos.Location = new System.Drawing.Point(0, 0);
            this.dgv_eventosAtivos.MultiSelect = false;
            this.dgv_eventosAtivos.Name = "dgv_eventosAtivos";
            this.dgv_eventosAtivos.ReadOnly = true;
            this.dgv_eventosAtivos.RowHeadersVisible = false;
            this.dgv_eventosAtivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_eventosAtivos.Size = new System.Drawing.Size(795, 478);
            this.dgv_eventosAtivos.TabIndex = 3;
            this.dgv_eventosAtivos.TabStop = false;
            // 
            // F_TabelaEventosAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 478);
            this.Controls.Add(this.dgv_eventosAtivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_TabelaEventosAtivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela - Eventos Ativos";
            this.Load += new System.EventHandler(this.F_TabelaEventosAtivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eventosAtivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_eventosAtivos;
    }
}