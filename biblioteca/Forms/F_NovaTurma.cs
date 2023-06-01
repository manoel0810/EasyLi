using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_NovaTurma : Form
    {
        public F_NovaTurma()
        {
            InitializeComponent();
        }

        private void VoltarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AdicionarClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Turma.Text))
            {
                MessageBox.Show("Informe um nome para a nova turma", "Nova turma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MGlobais.AntiSQLInjection(Turma.Text))
            {
                MessageBox.Show("O nome informado para a turma é inválido. Por favor, use outro", "Nova turma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Turma.Clear();
                return;
            }
            else
            {
                DataTable dt = DatabaseController.DQL($"SELECT * FROM tb_turmas WHERE N_TURMA = '{Turma.Text}'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Já existe uma turma com este nome", "Nova turma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Turma.Clear();
                    return;
                }
                else
                {
                    DatabaseController.DML($"INSERT INTO tb_turmas (N_TURMA) VALUES ('{MGlobais.SanitizeString(Turma.Text)}')");
                    CarregarTurmas();

                    if (DialogResult.Yes == MessageBox.Show("A nova turma foi salva! Deseja realizar outra operação? ", "Salvo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Turma.Clear();
                        Turma.Focus();
                    }
                    else
                        Close();
                }
            }
        }

        private void CarregarTurmas()
        {
            Turmas.DataSource = DatabaseController.DQL("SELECT N_IDTURMA AS 'ID', N_TURMA AS 'Nome da Turma' FROM tb_turmas ORDER BY N_TURMA");
            Turmas.Columns[0].Width = 50;
            Turmas.Columns[1].Width = 190;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            CarregarTurmas();
            KeyPreview = true;
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
