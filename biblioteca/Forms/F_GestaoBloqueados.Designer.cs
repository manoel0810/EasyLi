﻿namespace biblioteca
{
    partial class F_GestaoBloqueados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestaoBloqueados));
            this.tb_nota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_notificar = new System.Windows.Forms.Button();
            this.btn_desbloquear = new System.Windows.Forms.Button();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_livro = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Livros = new System.Windows.Forms.DataGridView();
            this.Usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Livros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nota
            // 
            this.tb_nota.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nota.Location = new System.Drawing.Point(15, 110);
            this.tb_nota.Multiline = true;
            this.tb_nota.Name = "tb_nota";
            this.tb_nota.ReadOnly = true;
            this.tb_nota.Size = new System.Drawing.Size(457, 47);
            this.tb_nota.TabIndex = 28;
            this.tb_nota.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "NOTAS:";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(493, 485);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 26;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.ExitClick);
            // 
            // btn_notificar
            // 
            this.btn_notificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_notificar.Location = new System.Drawing.Point(574, 485);
            this.btn_notificar.Name = "btn_notificar";
            this.btn_notificar.Size = new System.Drawing.Size(75, 23);
            this.btn_notificar.TabIndex = 25;
            this.btn_notificar.Text = "Notificar";
            this.btn_notificar.UseVisualStyleBackColor = true;
            this.btn_notificar.Click += new System.EventHandler(this.Notification);
            // 
            // btn_desbloquear
            // 
            this.btn_desbloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desbloquear.Location = new System.Drawing.Point(655, 485);
            this.btn_desbloquear.Name = "btn_desbloquear";
            this.btn_desbloquear.Size = new System.Drawing.Size(75, 23);
            this.btn_desbloquear.TabIndex = 24;
            this.btn_desbloquear.Text = "Desbloquear";
            this.btn_desbloquear.UseVisualStyleBackColor = true;
            this.btn_desbloquear.Click += new System.EventHandler(this.UnblockCkick);
            // 
            // mask_data
            // 
            this.mask_data.Cursor = System.Windows.Forms.Cursors.No;
            this.mask_data.Location = new System.Drawing.Point(637, 33);
            this.mask_data.Name = "mask_data";
            this.mask_data.ReadOnly = true;
            this.mask_data.Size = new System.Drawing.Size(93, 20);
            this.mask_data.TabIndex = 23;
            // 
            // tb_id
            // 
            this.tb_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(574, 33);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(57, 20);
            this.tb_id.TabIndex = 22;
            this.tb_id.TabStop = false;
            // 
            // tb_livro
            // 
            this.tb_livro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_livro.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_livro.Location = new System.Drawing.Point(15, 71);
            this.tb_livro.Name = "tb_livro";
            this.tb_livro.ReadOnly = true;
            this.tb_livro.Size = new System.Drawing.Size(553, 20);
            this.tb_livro.TabIndex = 21;
            this.tb_livro.TabStop = false;
            // 
            // tb_nome
            // 
            this.tb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nome.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_nome.Location = new System.Drawing.Point(15, 33);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            this.tb_nome.Size = new System.Drawing.Size(553, 20);
            this.tb_nome.TabIndex = 20;
            this.tb_nome.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "DATA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "LIVRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NOME";
            // 
            // Livros
            // 
            this.Livros.AllowUserToAddRows = false;
            this.Livros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Livros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Livros.DefaultCellStyle = dataGridViewCellStyle2;
            this.Livros.Location = new System.Drawing.Point(15, 345);
            this.Livros.MultiSelect = false;
            this.Livros.Name = "Livros";
            this.Livros.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Livros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Livros.RowHeadersVisible = false;
            this.Livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Livros.Size = new System.Drawing.Size(718, 133);
            this.Livros.TabIndex = 15;
            this.Livros.SelectionChanged += new System.EventHandler(this.DGVSelectionChenged);
            // 
            // Usuarios
            // 
            this.Usuarios.AllowUserToAddRows = false;
            this.Usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.Usuarios.Location = new System.Drawing.Point(15, 186);
            this.Usuarios.MultiSelect = false;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Usuarios.RowHeadersVisible = false;
            this.Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuarios.Size = new System.Drawing.Size(718, 133);
            this.Usuarios.TabIndex = 15;
            this.Usuarios.SelectionChanged += new System.EventHandler(this.Usuarios_SelectionChanged);
            // 
            // F_GestaoBloqueados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 518);
            this.Controls.Add(this.tb_nota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_notificar);
            this.Controls.Add(this.btn_desbloquear);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_livro);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.Livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoBloqueados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Bloqueados";
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Livros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_notificar;
        private System.Windows.Forms.Button btn_desbloquear;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_livro;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Livros;
        private System.Windows.Forms.DataGridView Usuarios;
    }
}