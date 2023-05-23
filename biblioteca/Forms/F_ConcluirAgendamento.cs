using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_ConcluirAgendamento : Form
    {
        public F_ConcluirAgendamento()
        {
            InitializeComponent();
        }

        private void F_ConcluirAgendamento_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDEVENTO AS 'ID', T_SOLICITANTE AS 'Responsável', T_TIPOSOLICITANTE AS 'Tipo', T_DATA AS 'Data' FROM tb_agendamento WHERE T_ESTADO='" + Globais.estado + "' ORDER BY N_IDEVENTO DESC";
            dgv_agenda.DataSource = Banco.DQL(vquery);
            dgv_agenda.Columns[0].Width = 80; // ID
            dgv_agenda.Columns[1].Width = 250; // Solicitante
            dgv_agenda.Columns[2].Width = 80; // Tipo
            dgv_agenda.Columns[3].Width = 80; // Data

            this.KeyPreview = true;
        }

        private void dgv_agenda_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int numLinha = dgv.SelectedRows.Count;
            if (numLinha > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_agenda.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosAgenda(valor);
                tb_responsavel.Text = dt.Rows[0].Field<string>("T_SOLICITANTE").ToString();
                tb_tipo.Text = dt.Rows[0].Field<string>("T_TIPOSOLICITANTE").ToString();
                tb_periodo.Text = dt.Rows[0].Field<string>("T_PERIODO").ToString();
                tb_aula.Text = dt.Rows[0].Field<string>("T_AULA").ToString();
                tb_estado.Text = dt.Rows[0].Field<string>("T_ESTADO").ToString();
                tb_data.Text = dt.Rows[0].Field<string>("T_DATA").ToString();
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDEVENTO").ToString();
                tb_turma.Text = dt.Rows[0].Field<string>("T_TURMA").ToString();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_agenda.SelectedRows.Count == 0)
            {
                return;
            }
            string vquery = "UPDATE tb_agendamento SET T_ESTADO='" + Globais.estadof + "' WHERE N_IDEVENTO=" + tb_id.Text;
            Banco.DML(vquery);
            dgv_agenda.Rows.Remove(dgv_agenda.CurrentRow);
            if (DialogResult.No == MessageBox.Show("O agendamento foi finalizado com êxito. Deseja alterar outro agendamento?", "Alterado", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void F_ConcluirAgendamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
