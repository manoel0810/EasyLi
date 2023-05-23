using System;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_ExcluirResistro : Form
    {
        public F_ExcluirResistro()
        {
            InitializeComponent();
        }

        private static string query = "";

        private void FormatarDGV()
        {
            dgv_excluir.Columns[0].Width = 60; //ID
            dgv_excluir.Columns[1].Width = 290; //ALUNO
            dgv_excluir.Columns[2].Width = 100; //TURMA
            dgv_excluir.Columns[3].Width = 280; //LIVRO
        }

        private void F_ExcluirResistro_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turmas', T_LIVRO AS 'Livro' FROM tb_dadosaluno ORDER BY N_IDLIVROALUNO DESC LIMIT 1200";
            dgv_excluir.DataSource = Banco.DQL(vquery);
            FormatarDGV();

            this.KeyPreview = true;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_excluir_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinha = dgv.SelectedRows.Count;
            if (contLinha > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_excluir.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(valor);
                tb_nomeAluno.Text = dt.Rows[0].Field<string>("T_ALUNO").ToString();
                tb_matricula.Text = dt.Rows[0].Field<string>("T_MATRICULA").ToString();
                tb_turma.Text = dt.Rows[0].Field<string>("T_TURMA").ToString();
                tb_status.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();
                tb_nomeLivro.Text = dt.Rows[0].Field<string>("T_LIVRO").ToString();
                tb_tombo.Text = dt.Rows[0].Field<string>("T_TOMBO").ToString();
                tb_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDLIVROALUNO").ToString();
                tb_email.Text = dt.Rows[0].Field<string>("T_EMAIL");
                tb_notas.Text = dt.Rows[0].Field<string>("T_NOTAS");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_excluir.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Deseja Realmente Excluir Este Registro? ", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == res)
                {
                    string vquery = "DELETE FROM tb_dadosaluno WHERE N_IDLIVROALUNO='" + tb_id.Text + "'";
                    Banco.DML(vquery);
                    MessageBox.Show("Deletado!");
                    dgv_excluir.Rows.Remove(dgv_excluir.CurrentRow);
                }
            }

        }

        private void tb_Fnome_TextChanged(object sender, EventArgs e)
        {
            if (tb_Fnome.Text.Contains("\'"))
            {
                tb_Fnome.Clear();
                SystemSound son = SystemSounds.Asterisk;
                son.Play();
                return;
            }

            if (tb_Fnome.Text == "")
            {
                query = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turmas', T_LIVRO AS 'Livro' FROM tb_dadosaluno ORDER BY N_IDLIVROALUNO DESC LIMIT 1200";
                dgv_excluir.DataSource = Banco.DQL(query);
                FormatarDGV();
            }
            else
            {
                if (tb_Fnome.Text.Length > 3)
                {
                    query = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turmas', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_ALUNO LIKE '" + tb_Fnome.Text + "%' ORDER BY N_IDLIVROALUNO DESC LIMIT 100";
                    dgv_excluir.DataSource = Banco.DQL(query);
                    FormatarDGV();
                }
                else
                {
                    return;
                }
            }
        }

        private void tb_Fmatricula_TextChanged(object sender, EventArgs e)
        {
            if (tb_Fmatricula.Text == "")
            {
                query = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turmas', T_LIVRO AS 'Livro' FROM tb_dadosaluno ORDER BY N_IDLIVROALUNO DESC LIMIT 1200";
                dgv_excluir.DataSource = Banco.DQL(query);
                FormatarDGV();
            }
            else
            {
                if (tb_Fmatricula.Text.Length > 3)
                {
                    query = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turmas', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_MATRICULA LIKE '" + tb_Fmatricula.Text + "%' ORDER BY N_IDLIVROALUNO DESC LIMIT 100";
                    dgv_excluir.DataSource = Banco.DQL(query);
                    FormatarDGV();
                }
                else
                {
                    return;
                }
            }
        }

        private void F_ExcluirResistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
