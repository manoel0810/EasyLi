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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_turma.Text == "")
            {
                MessageBox.Show("Informe um nome para a nova turma.", "Informação Obrigatória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string validacao = "SELECT * FROM tb_turmas WHERE N_TURMA = '" + tb_turma.Text + "'";
                DataTable dt = new DataTable();
                dt = Banco.DQL(validacao);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Já existe uma turma com este nome.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_turma.Clear();
                    return;
                }
                string vquery = "INSERT INTO tb_turmas (N_TURMA) VALUES ('" + MGlobais.ValidarString(tb_turma.Text) + "')";
                Banco.DML(vquery);
                CarregarTurmas();
                DialogResult Res = MessageBox.Show("A nova turma foi salva! Deseja realizar outra operação? ", "Salvo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == Res)
                {
                    tb_turma.Clear();
                    tb_turma.Focus();

                }
                else
                {
                    this.Close();
                }
            }
        }

        private void CarregarTurmas()
        {
            DataTable dt = new DataTable();
            string vquery = "SELECT N_IDTURMA AS 'ID', N_TURMA AS 'Nome da Turma' FROM tb_turmas ORDER BY N_TURMA";
            dt = Banco.DQL(vquery);

            dgv_turmas.DataSource = dt;
            dgv_turmas.Columns[0].Width = 50;
            dgv_turmas.Columns[1].Width = 190;
        }

        private void F_NovaTurma_Load(object sender, EventArgs e)
        {
            CarregarTurmas();

            this.KeyPreview = true;
        }

        private void F_NovaTurma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
