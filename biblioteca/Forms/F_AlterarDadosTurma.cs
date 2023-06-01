using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_AlterarDadosTurma : Form
    {
        private const int MargemDGV = 20;

        public F_AlterarDadosTurma()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            Turmas.DataSource = DatabaseController.DQL("SELECT N_IDTURMA AS 'ID', N_TURMA AS 'Turma' FROM tb_turmas");
            Turmas.Columns[0].Width = 50; //ID
            Turmas.Columns[1].Width = Turmas.Width - (Turmas.Columns[0].Width + MargemDGV); //Turma

            KeyPreview = true;
        }

        private void TurmasSelectionChenged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                Turma.Text = Turmas.SelectedRows[0].Cells[1].Value.ToString();
                ID.Text = Turmas.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void VoltarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            if (Turmas.SelectedRows.Count == 0)
                return;

            DatabaseController.DML($"UPDATE tb_turmas SET N_TURMA='{Turma.Text}' WHERE N_IDTURMA='{ID.Text}'");
            Turmas.SelectedRows[0].Cells[1].Value = Turma.Text;
        }

        private void ExcluirClick(object sender, EventArgs e)
        {
            if (Turmas.SelectedRows.Count == 0)
                return;

            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir este item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DatabaseController.DML($"DELETE FROM tb_turmas WHERE N_IDTURMA='{ID.Text}'");
                Turmas.Rows.Remove(Turmas.CurrentRow);
            }
        }

        private void F_AlterarDadosTurma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
