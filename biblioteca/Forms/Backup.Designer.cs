
namespace biblioteca
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_animacoes = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_lastB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_alterarAuto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.efetuarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_acao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_animacoes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pb_animacoes
            // 
            this.pb_animacoes.Image = global::biblioteca.Properties.Resources.gif_carregando;
            this.pb_animacoes.Location = new System.Drawing.Point(274, 63);
            this.pb_animacoes.Name = "pb_animacoes";
            this.pb_animacoes.Size = new System.Drawing.Size(136, 124);
            this.pb_animacoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_animacoes.TabIndex = 1;
            this.pb_animacoes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last backup: ";
            // 
            // lb_lastB
            // 
            this.lb_lastB.AutoSize = true;
            this.lb_lastB.Location = new System.Drawing.Point(157, 229);
            this.lb_lastB.Name = "lb_lastB";
            this.lb_lastB.Size = new System.Drawing.Size(16, 13);
            this.lb_lastB.TabIndex = 3;
            this.lb_lastB.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "O backup automático está:";
            // 
            // btn_alterarAuto
            // 
            this.btn_alterarAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterarAuto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_alterarAuto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_alterarAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarAuto.Location = new System.Drawing.Point(91, 46);
            this.btn_alterarAuto.Name = "btn_alterarAuto";
            this.btn_alterarAuto.Size = new System.Drawing.Size(60, 21);
            this.btn_alterarAuto.TabIndex = 5;
            this.btn_alterarAuto.Text = "...";
            this.btn_alterarAuto.UseVisualStyleBackColor = true;
            this.btn_alterarAuto.Click += new System.EventHandler(this.btn_alterarAuto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efetuarBackupToolStripMenuItem,
            this.restaurarBackupToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // efetuarBackupToolStripMenuItem
            // 
            this.efetuarBackupToolStripMenuItem.Name = "efetuarBackupToolStripMenuItem";
            this.efetuarBackupToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.efetuarBackupToolStripMenuItem.Text = "Efetuar Backup";
            this.efetuarBackupToolStripMenuItem.Click += new System.EventHandler(this.efetuarBackupToolStripMenuItem_Click);
            // 
            // restaurarBackupToolStripMenuItem
            // 
            this.restaurarBackupToolStripMenuItem.Name = "restaurarBackupToolStripMenuItem";
            this.restaurarBackupToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.restaurarBackupToolStripMenuItem.Text = "Restaurar Backup";
            this.restaurarBackupToolStripMenuItem.Click += new System.EventHandler(this.restaurarBackupToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Location = new System.Drawing.Point(227, 30);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(16, 13);
            this.lb_estado.TabIndex = 7;
            this.lb_estado.Text = "...";
            // 
            // lb_acao
            // 
            this.lb_acao.AutoSize = true;
            this.lb_acao.Location = new System.Drawing.Point(313, 230);
            this.lb_acao.Name = "lb_acao";
            this.lb_acao.Size = new System.Drawing.Size(0, 13);
            this.lb_acao.TabIndex = 8;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 246);
            this.Controls.Add(this.lb_acao);
            this.Controls.Add(this.lb_estado);
            this.Controls.Add(this.btn_alterarAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_lastB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_animacoes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Backup_FormClosed);
            this.Load += new System.EventHandler(this.Backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_animacoes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_animacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_lastB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_alterarAuto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem efetuarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_acao;
    }
}