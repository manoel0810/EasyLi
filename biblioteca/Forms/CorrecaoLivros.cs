using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class CorrecaoLivros : Form
    {
        public CorrecaoLivros()
        {
            InitializeComponent();
        }

        private void FormatarDGV()
        {
            dgv_livros.Columns[0].Width = 70;
            dgv_livros.Columns[1].Width = 275;
            dgv_livros.Columns[2].Width = 80;
        }

        private void CorrecaoLivros_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            dgv_livros.DataSource = Banco.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros order by dt_datain");
            FormatarDGV();
        }

        private void dgv_livros_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                tb_nome.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                mask_data.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                tb_codigo.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void CorrecaoLivros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exluit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você tem certeza que deseja apagar este registros?", "Apagar livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) && dgv_livros.SelectedRows.Count > 0)
            {
                Banco.DML(String.Format("delete from tb_livros where id = '{0}'", dgv_livros.SelectedRows[0].Cells[0].Value.ToString()));
                dgv_livros.Rows.Remove(dgv_livros.CurrentRow);
                MessageBox.Show("O livro foi apagado", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (tb_codigo.Text != dgv_livros.SelectedRows[0].Cells[0].Value.ToString() && dgv_livros.SelectedRows.Count > 0)
            {
                MessageBox.Show("Você mudou o código do livro. Será feito uma varredura para verificar sua disponibilidade.", "Unique block", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable count = Banco.DQL(String.Format("select * from tb_livros where id = '{0}'", tb_codigo.Text));
                if (count.Rows.Count > 0)
                {
                    MessageBox.Show("Este tombo não está disponível. Troque para outro", "Unique block", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (dgv_livros.SelectedRows.Count <= 0)
            {
                return;
            }
            Banco.DML(String.Format("update tb_livros set id = '{0}', t_titulo = '{1}', dt_datain = '{2}' where id = '{3}'", tb_codigo.Text, MGlobais.ValidarString(tb_nome.Text), MGlobais.FormatarDataSQL(mask_data.Text), dgv_livros.SelectedRows[0].Cells[0].Value.ToString()));
            dgv_livros.SelectedRows[0].Cells[0].Value = tb_codigo.Text;
            dgv_livros.SelectedRows[0].Cells[1].Value = tb_nome.Text;
            dgv_livros.SelectedRows[0].Cells[2].Value = mask_data.Text;
            MessageBox.Show("Dados salvos com êxito", "Dados salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tb_nomef_TextChanged(object sender, EventArgs e)
        {
            if (tb_nomef.Text.Length > 2)
            {
                if (tb_nomef.Text.Contains("\'"))
                {
                    tb_nomef.Text.Replace("'", " ");
                    return;
                }
                dgv_livros.DataSource = Banco.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros where t_titulo like '" + tb_nomef.Text + "%'");
                FormatarDGV();
            }
            else if (tb_nomef.Text.Length == 0)
            {
                dgv_livros.DataSource = Banco.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros order by dt_datain");
                FormatarDGV();
            }
        }

        private void tb_codigof_TextChanged(object sender, EventArgs e)
        {
            if (tb_codigof.Text.Length > 2)
            {
                if (tb_codigof.Text.Contains("\'"))
                {
                    tb_codigof.Text.Replace("'", " ");
                    return;
                }
                dgv_livros.DataSource = Banco.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros where id like '" + tb_codigof.Text + "%'");
                FormatarDGV();
            }
            else if (tb_codigof.Text.Length == 0)
            {
                dgv_livros.DataSource = Banco.DQL("select id as 'ID', t_titulo as 'Titulo', dt_datain as 'Data' from tb_livros order by dt_datain");
                FormatarDGV();
            }
        }
    }
}
