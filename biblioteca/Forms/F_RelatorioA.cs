using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_RelatorioA : Form
    {
        public F_RelatorioA()
        {
            InitializeComponent();
        }

        private void F_RelatorioA_Load(object sender, EventArgs e)
        {
            rb_thiss.Checked = true;
            string vqueryTurmas = @"SELECT * FROM tb_turmas ORDER BY N_TURMA";
            cb_turma.Items.Clear();
            cb_turma.DataSource = Banco.ObterTurmas(vqueryTurmas);
            cb_turma.DisplayMember = "N_TURMA";
            cb_turma.ValueMember = "N_IDTURMA";

            cb_turma.Text = "";
            mask_ano.Enabled = false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            string vquery;
            int ano = 0;

            if (rb_thiss.Checked == true)
            {
                ano = DateTime.Today.Year;
                Globais.dataRelatorio = ano.ToString();
            }

            if (rb_exp.Checked == true && mask_ano.Text == "")
            {
                MessageBox.Show("Para continuar, você tem que fornecer um ano,", "Informação Requisitada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (rb_exp.Checked == true && mask_ano.Text != "")
            {
                ano = int.Parse(mask_ano.Text);
                Globais.dataRelatorio = ano.ToString(); ;
            }

            if (cb_avan.Checked)
            {
                if (cb_turma.Text == "" && cb_estado.Text == "")
                {
                    MessageBox.Show("Para utilizar a opção 'Avançado' você deve fornecer um dos parâmetros (Turma ou Estado).", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (cb_turma.Text != "" && cb_estado.Text != "")
                    {
                        vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_TURMA AS 'Turma' FROM tb_dadosaluno WHERE T_TURMA = '" + cb_turma.Text + "' AND T_STATUS = '" + cb_estado.Text + "' AND T_DATA LIKE '" + ano.ToString() + "%' ORDER BY T_TURMA, T_ALUNO";
                        GerarPDF.RelatorioAnual(vquery, false, false, ano.ToString());
                        return;
                    }

                    if (cb_turma.Text != "" && cb_estado.Text == "")
                    {
                        vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_TURMA AS 'Turma' FROM tb_dadosaluno WHERE T_TURMA = '" + cb_turma.Text + "' AND T_DATA LIKE '" + ano.ToString() + "%' ORDER BY T_ALUNO";
                        GerarPDF.RelatorioAnual(vquery, false, true, ano.ToString());
                        return;
                    }

                    if (cb_turma.Text == "" && cb_estado.Text != "")
                    {
                        vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_TURMA AS 'Turma' FROM tb_dadosaluno WHERE T_STATUS = '" + cb_estado.Text + "' AND T_DATA LIKE '" + ano.ToString() + "%' ORDER BY T_TURMA, T_ALUNO";
                        GerarPDF.RelatorioAnual(vquery, true, false, ano.ToString());
                        return;
                    }
                }
            }
            else
            {
                vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_TURMA AS 'Turma' FROM tb_dadosaluno WHERE T_DATA LIKE '" + ano.ToString() + "%' ORDER BY T_TURMA, T_ALUNO";
                GerarPDF.RelatorioAnual(vquery, true, true, ano.ToString());
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_avan.Checked && panel1.Enabled == false)
            {
                panel1.Enabled = true;
            }

            if (cb_avan.Checked == false && panel1.Enabled == true)
            {
                panel1.Enabled = false;
            }
        }

        private void rb_exp_CheckedChanged(object sender, EventArgs e)
        {
            if (mask_ano.Enabled == true && rb_exp.Checked == false)
            {
                mask_ano.Text = "";
                mask_ano.Enabled = false;
            }

            if (mask_ano.Enabled == false && rb_exp.Checked == true)
            {
                mask_ano.Enabled = true;
            }
        }
    }
}
