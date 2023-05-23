using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_AlterarDadosEventos : Form
    {
        public F_AlterarDadosEventos()
        {
            InitializeComponent();
        }

        private void F_AlterarDadosEventos_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDEVENTO AS 'ID', N_NOMEEVENTO AS 'Nome do Evento' FROM tb_eventos ORDER BY N_IDEVENTO DESC";
            dgv_alterarEventos.DataSource = Banco.DQL(vquery);
            dgv_alterarEventos.Columns[0].Width = 65;  //ID
            dgv_alterarEventos.Columns[1].Width = 420; //Nome do Evento

            this.KeyPreview = true;
        }

        private bool TemLinha()
        {
            bool res;
            if (dgv_alterarEventos.Rows.Count == 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_alterarEventos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_alterarEventos.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosEventos(valor);
                tb_nome.Text = dt.Rows[0].Field<string>("N_NOMEEVENTO").ToString();
                tb_informacoesEvento.Text = dt.Rows[0].Field<string>("T_INFORMACAO").ToString();
                tb_local.Text = dt.Rows[0].Field<string>("T_LOCAL").ToString();
                mas_comeca.Text = dt.Rows[0].Field<string>("T_INICIO").ToString();
                mas_termina.Text = dt.Rows[0].Field<string>("T_FIM").ToString();
                cb_estado.Text = dt.Rows[0].Field<string>("T_ESTADO").ToString();
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDEVENTO").ToString();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (TemLinha())
            {
                return;
            }

            string nome = MGlobais.ValidarString(tb_nome.Text);
            string info = MGlobais.ValidarString(tb_informacoesEvento.Text);
            string local = MGlobais.ValidarString(tb_local.Text);

            string vquery = "UPDATE tb_eventos SET N_NOMEEVENTO='" + nome + "', T_INFORMACAO='" + info + "', T_LOCAL='" + local + "', T_INICIO='" + mas_comeca.Text + "', T_FIM='" + mas_termina.Text + "', T_ESTADO='" + cb_estado.Text + "' WHERE N_IDEVENTO='" + tb_id.Text + "'";
            Banco.DML(vquery);
            if (TemLinha() == false)
            {
                if (DialogResult.No == MessageBox.Show("Informações alteradas. Feche e abra esta janela para ver mudanças. Deseja efeturar nova edição?", "Alterado", MessageBoxButtons.YesNo))
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Informações alteradas", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (TemLinha())
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string vquery = "DELETE FROM tb_eventos WHERE N_IDEVENTO='" + tb_id.Text + "'";
                Banco.DML(vquery);
                dgv_alterarEventos.Rows.Remove(dgv_alterarEventos.CurrentRow);
                if (TemLinha() == false)
                {
                    if (DialogResult.No == MessageBox.Show("Informação apagada. Deseja apagar outro registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Informação apagada.", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
            }
        }

        private void F_AlterarDadosEventos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
