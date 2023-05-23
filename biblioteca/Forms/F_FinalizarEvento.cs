using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_FinalizarEvento : Form
    {
        public F_FinalizarEvento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_finalizarEventos.Rows.Count == 0)
            {
                MessageBox.Show("Não Há Registros Para Finalizar");
            }
            else
            {
                string vquery = "UPDATE tb_eventos SET T_ESTADO='" + Globais.estadof + "'";
                Banco.DML(vquery);
                dgv_finalizarEventos.Rows.Remove(dgv_finalizarEventos.CurrentRow);
                DialogResult res = MessageBox.Show("O Evento Foi Marcado Como Finalizado. Deseja Finalizar Outro Evento?", "Finalizado", MessageBoxButtons.YesNo);
                if (DialogResult.No == res)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_FinalizarEvento_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDEVENTO AS 'ID', N_NOMEEVENTO AS 'Nome do Evento' FROM tb_eventos WHERE T_ESTADO='" + Globais.estado + "'";
            dgv_finalizarEventos.DataSource = Banco.DQL(vquery);
            dgv_finalizarEventos.Columns[0].Width = 65;  //ID
            dgv_finalizarEventos.Columns[1].Width = 420; //Nome do Evento

            this.KeyPreview = true;
        }

        private void dgv_finalizarEventos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_finalizarEventos.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosEventos(valor);
                tb_nome.Text = dt.Rows[0].Field<string>("N_NOMEEVENTO").ToString();
                tb_informacoesEvento.Text = dt.Rows[0].Field<string>("T_INFORMACAO").ToString();
                tb_local.Text = dt.Rows[0].Field<string>("T_LOCAL").ToString();
                mas_comeca.Text = dt.Rows[0].Field<string>("T_INICIO").ToString();
                mas_termina.Text = dt.Rows[0].Field<string>("T_FIM").ToString();
                tb_estado.Text = dt.Rows[0].Field<string>("T_ESTADO").ToString();
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDEVENTO").ToString();

            }
        }

        private void F_FinalizarEvento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
