using System;
using System.Media;
using System.Windows.Forms;

namespace GestaoBanco
{
    public partial class F_EmailTeste : Form
    {
        public F_EmailTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                SystemSound son = SystemSounds.Exclamation;
                son.Play();
                return;
            }
            Globais.email = textBox1.Text;
            this.Close();
        }

        private void F_EmailTeste_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void F_EmailTeste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
