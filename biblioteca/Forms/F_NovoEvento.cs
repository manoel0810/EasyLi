using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_NovoEvento : Form
    {
        public F_NovoEvento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeEvento = MGlobais.ValidarString(tb_nomeEvento.Text);
            string infoEvent = MGlobais.ValidarString(tb_informacoesEvento.Text);
            string localEvent = MGlobais.ValidarString(tb_localEvento.Text);

            string vquery = "INSERT INTO tb_eventos (N_NOMEEVENTO, T_INFORMACAO, T_LOCAL, T_INICIO, T_FIM, T_ESTADO) VALUES ('" + nomeEvento + "', '" + infoEvent + "', '" + localEvent + "', '" + mask_comeca.Text + "', '" + mas_termina.Text + "', '" + Globais.estado + "')";
            Banco.DML(vquery);
            DialogResult res = MessageBox.Show("O novo evento foi salvo! deseja criar outro? ", "Salvo", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == res)
            {
                tb_localEvento.Clear();
                tb_localEvento.Clear();
                tb_informacoesEvento.Clear();
                mask_comeca.Clear();
                mas_termina.Clear();
                tb_nomeEvento.Clear();
                tb_nomeEvento.Focus();
            }
            else
            {
                this.Close();
            }
        }

        private void F_NovoEvento_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void F_NovoEvento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
