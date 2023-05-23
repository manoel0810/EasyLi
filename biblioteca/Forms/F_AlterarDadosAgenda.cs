using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_AlterarDadosAgenda : Form
    {
        public F_AlterarDadosAgenda()
        {
            InitializeComponent();
        }

        private void F_AlterarDadosAgenda_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDEVENTO AS 'ID', T_SOLICITANTE AS 'Responsável', T_ESTADO AS 'Estado', T_DATA AS 'Data' FROM tb_agendamento ORDER BY N_IDEVENTO DESC LIMIT 300";
            dgv_agenda.DataSource = Banco.DQL(vquery);
            dgv_agenda.Columns[0].Width = 65; //ID
            dgv_agenda.Columns[1].Width = 285; //Responsável
            dgv_agenda.Columns[2].Width = 80; //Estado
            dgv_agenda.Columns[3].Width = 80; //Data

            //Popular ComboBox Turmas
            string vqueryTurmas = @"SELECT * FROM tb_turmas ORDER BY N_TURMA";
            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.ObterTurmas(vqueryTurmas);
            cb_turmas.DisplayMember = "N_TURMA";
            cb_turmas.ValueMember = "N_IDTURMA";

            this.KeyPreview = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_agenda_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_agenda.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosAgenda(valor);
                tb_responsavel.Text = dt.Rows[0].Field<string>("T_SOLICITANTE").ToString();
                cb_alterarTipo.Text = dt.Rows[0].Field<string>("T_TIPOSOLICITANTE").ToString();
                mask_data.Text = dt.Rows[0].Field<string>("T_DATA").ToString();
                cb_alterarPeriodo.Text = dt.Rows[0].Field<string>("T_PERIODO").ToString();
                tb_aula.Text = dt.Rows[0].Field<string>("T_AULA").ToString();
                cb_alterarEstado.Text = dt.Rows[0].Field<string>("T_ESTADO").ToString();
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDEVENTO").ToString();
                cb_turmas.Text = dt.Rows[0].Field<string>("T_TURMA").ToString();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (dgv_agenda.SelectedRows.Count == 0)
            {
                return;
            }

            string retorno = MGlobais.ValidarString(tb_responsavel.Text);
            string vquery = "UPDATE tb_agendamento SET T_SOLICITANTE='" + retorno + "', T_TIPOSOLICITANTE='" + cb_alterarTipo.Text + "', T_PERIODO='" + cb_alterarPeriodo.Text + "', T_AULA='" + tb_aula.Text + "', T_ESTADO='" + cb_alterarEstado.Text + "',T_DATA='" + mask_data.Text + "', T_TURMA='" + cb_turmas.Text + "' WHERE N_IDEVENTO=" + tb_id.Text;
            Banco.DML(vquery);
            MessageBox.Show("Os dados foram atualizados. Feche e abra esta janela para ver mudanças.", "Dados Alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_agenda.SelectedRows.Count == 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir este registro?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string vquery = "DELETE FROM tb_agendamento WHERE N_IDEVENTO=" + tb_id.Text;
                Banco.DML(vquery);
                dgv_agenda.Rows.Remove(dgv_agenda.CurrentRow);
                MessageBox.Show("Registro apagado", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void F_AlterarDadosAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
