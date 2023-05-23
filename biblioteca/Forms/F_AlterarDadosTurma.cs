using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_AlterarDadosTurma : Form
    {
        public F_AlterarDadosTurma()
        {
            InitializeComponent();
        }

        private void F_AlterarDadosTurma_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDTURMA AS 'ID', N_TURMA AS 'Turma' FROM tb_turmas";
            dgv_turmas.DataSource = Banco.DQL(vquery);
            dgv_turmas.Columns[0].Width = 50; //ID
            dgv_turmas.Columns[1].Width = 300; //Turma

            this.KeyPreview = true;
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_turmas.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosTurma(valor);
                tb_turma.Text = dt.Rows[0].Field<string>("N_TURMA").ToString();
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDTURMA").ToString();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (dgv_turmas.SelectedRows.Count == 0)
            {
                return;
            }
            string vquery = "UPDATE tb_turmas SET N_TURMA='" + tb_turma.Text + "' WHERE N_IDTURMA='" + tb_id.Text + "'";
            Banco.DML(vquery);
            MessageBox.Show("Salvo! Atualize esta página para ver mudanças.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_turmas.SelectedRows.Count == 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir este item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string vquery = "DELETE FROM tb_turmas WHERE N_IDTURMA='" + tb_id.Text + "'";
                Banco.DML(vquery);
                MessageBox.Show("A turma foi deletada", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void F_AlterarDadosTurma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
