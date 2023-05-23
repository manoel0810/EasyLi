using System;
using System.Media;
using System.Windows.Forms;

namespace GestaoBanco
{
    public partial class F_LoginDev : Form
    {
        public F_LoginDev()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_user.Text == "DevOpsSystemSQLite" && tb_senha.Text == "0810")
            {
                Globais.username = tb_user.Text;
                this.Close();
            }
            else
            {
                SystemSound son = SystemSounds.Beep;
                son.Play();
                MessageBox.Show("Informações fornecidas inválidas");
                return;
            }
        }

        private void F_LoginDev_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void F_LoginDev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void F_LoginDev_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globais.username == "")
            {
                Application.Exit();
            }
        }
    }
}
