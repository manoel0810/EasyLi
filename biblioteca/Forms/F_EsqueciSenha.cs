using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_EsqueciSenha : Form
    {
        public F_EsqueciSenha()
        {
            InitializeComponent();
        }

        private static int controleGeral = 0;
        private static int tamanhoChar = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controleGeral == 1)
            {
                if (tb_senha.Text == "" || tb_Rsenha.Text == "")
                {
                    lb_senhas.Text = "Informe corretamente os campos.";
                    lb_senhas.Visible = true;
                    lb_senhas.Refresh();
                    lb_senhas.ForeColor = Color.DarkRed;
                    return;
                }
                else
                {
                    if (tb_senha.Text != tb_Rsenha.Text)
                    {
                        lb_senhas.Text = "Suas senhas estão diferentes.";
                        lb_senhas.Visible = true;
                        lb_senhas.Refresh();
                        lb_senhas.ForeColor = Color.DarkRed;
                        return;
                    }
                    else
                    {
                        if (MGlobais.AntiSQLInjection(tb_username.Text) == true || MGlobais.AntiSQLInjection(tb_senha.Text) == true)
                        {
                            MessageBox.Show("Atenção! Sua senha e/ou username utilizam caracteres especiais do sistema(, ' ; and or, etc). Para efeturar a atualização, pedimos que modifique seus campos.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string query = String.Format("UPDATE tb_login SET T_SENHA = '{0}' WHERE T_USER = '{1}'", tb_Rsenha.Text, tb_username.Text);
                        Banco.DML(query);
                        MessageBox.Show("Seu cadastro foi atualizado", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                }
            }

            DataTable dt = new DataTable();
            int controle = 0;

            if (rb_basico.Checked)
            {
                controle = 1;
            }
            if (rb_avancado.Checked)
            {
                controle = 0;
            }
            if (rb_basico.Checked == false && rb_avancado.Checked == false)
            {
                lb_tipo.Text = "Obrigatório";
                lb_tipo.ForeColor = Color.DarkRed;
                lb_tipo.Visible = true;
                lb_tipo.Refresh();
                return;
            }

            string vquery = "SELECT * FROM tb_login WHERE T_USER = '" + tb_username.Text + "' AND N_PRIV = '" + controle + "'";
            dt = Banco.DQL(vquery);

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Não achamos nenhum registro com as informações fornecidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string nome = dt.Rows[0].Field<string>("T_NOMECOMPLETO");
                string nomeTXTDT = nome.ToUpper();
                string nomeTXT = tb_nome.Text.ToUpper();
                if (nomeTXTDT == nomeTXT)
                {
                    tb_senha.Visible = true;
                    tb_Rsenha.Visible = true;
                    lb_senha.Visible = true;
                    lb_Rsenha.Visible = true;
                    tb_nome.Enabled = false;
                    tb_username.Enabled = false;
                    rb_avancado.Enabled = false;
                    rb_basico.Enabled = false;
                    btn_vari.Text = "Salvar";
                    controleGeral = 1;
                    return;
                }
                else
                {
                    MessageBox.Show("O nome fornecido está divergente do registrado.", "Divergência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O serial é um código que você recebe ao adquirir este produto. A função do serial é evitar fraudes. Caso tenha perdido o seu, entre em contato com o desenvolvedor do programa.");
        }

        private void rb_basico_CheckedChanged(object sender, EventArgs e)
        {
            if (lb_tipo.Visible == true)
            {
                lb_tipo.Visible = false;
            }
        }

        private void rb_avancado_CheckedChanged(object sender, EventArgs e)
        {
            if (lb_tipo.Visible == true)
            {
                lb_tipo.Visible = false;
            }
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {
            tamanhoChar = tb_senha.Text.Length;
        }

        private void tb_Rsenha_TextChanged(object sender, EventArgs e)
        {
            if (tb_Rsenha.Text.Length < tamanhoChar && lb_senhas.Visible == true)
            {
                lb_senhas.Visible = false;
                lb_senhas.Refresh();
            }

            if (tb_Rsenha.Text.Length >= tamanhoChar)
            {
                if (tb_senha.Text != tb_Rsenha.Text)
                {
                    lb_senhas.Text = "Suas senhas estão diferentes.";
                    lb_senhas.Visible = true;
                    lb_senhas.ForeColor = Color.DarkRed;
                    lb_senhas.Refresh();
                }
                else if (lb_tipo.Visible == true && tb_senha.Text == tb_Rsenha.Text)
                {
                    lb_senhas.Visible = false;
                }
            }
        }
    }
}
