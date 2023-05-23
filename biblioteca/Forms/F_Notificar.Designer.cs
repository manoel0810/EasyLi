namespace biblioteca
{
    partial class F_Notificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Notificar));
            this.label1 = new System.Windows.Forms.Label();
            this.pgb_notificando = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Tregistros = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Rnotificado = new System.Windows.Forms.Label();
            this.btn_notificar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "A notificação irá enviar E-mails para todos aqueles que tiverem um E-mail salvo e" +
    " pendências com mais de quinze dias.\r\nOBS (Este processo pode ser um pouco lento" +
    ")";
            // 
            // pgb_notificando
            // 
            this.pgb_notificando.Location = new System.Drawing.Point(15, 76);
            this.pgb_notificando.Name = "pgb_notificando";
            this.pgb_notificando.Size = new System.Drawing.Size(666, 23);
            this.pgb_notificando.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notificando: ";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(85, 60);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(16, 13);
            this.lb_nome.TabIndex = 3;
            this.lb_nome.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registros para Notificar: ";
            // 
            // lb_Tregistros
            // 
            this.lb_Tregistros.AutoSize = true;
            this.lb_Tregistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Tregistros.Location = new System.Drawing.Point(132, 122);
            this.lb_Tregistros.Name = "lb_Tregistros";
            this.lb_Tregistros.Size = new System.Drawing.Size(13, 13);
            this.lb_Tregistros.TabIndex = 5;
            this.lb_Tregistros.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Notificados: ";
            // 
            // lb_Rnotificado
            // 
            this.lb_Rnotificado.AutoSize = true;
            this.lb_Rnotificado.ForeColor = System.Drawing.Color.Green;
            this.lb_Rnotificado.Location = new System.Drawing.Point(75, 145);
            this.lb_Rnotificado.Name = "lb_Rnotificado";
            this.lb_Rnotificado.Size = new System.Drawing.Size(13, 13);
            this.lb_Rnotificado.TabIndex = 7;
            this.lb_Rnotificado.Text = "0";
            // 
            // btn_notificar
            // 
            this.btn_notificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_notificar.Location = new System.Drawing.Point(557, 154);
            this.btn_notificar.Name = "btn_notificar";
            this.btn_notificar.Size = new System.Drawing.Size(124, 23);
            this.btn_notificar.TabIndex = 8;
            this.btn_notificar.Text = "Notificar Pendências";
            this.btn_notificar.UseVisualStyleBackColor = true;
            this.btn_notificar.Click += new System.EventHandler(this.btn_notificar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(476, 154);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // F_Notificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 190);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_notificar);
            this.Controls.Add(this.lb_Rnotificado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Tregistros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgb_notificando);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Notificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgb_notificando;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Tregistros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Rnotificado;
        private System.Windows.Forms.Button btn_notificar;
        private System.Windows.Forms.Button btn_voltar;
    }
}