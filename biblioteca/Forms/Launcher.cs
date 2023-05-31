using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void StopOperatinon(string msg)
        {
            MessageBox.Show(msg, "Erro de processo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            tabControl1.SelectedIndex = 5;
            stop.Focus();
            stop.Show();
            Thread.Sleep(500);
            p_desc.Enabled = false;
            p_desc.BackColor = Color.White;

            //Mudar a cor de todas as Labels...
            //Primeiro bloco
            lb_vd_0.ForeColor = Color.Black;
            lb_vd_1.ForeColor = Color.Black;
            lb_vd_2.ForeColor = Color.Black;
            lb_vd_3.ForeColor = Color.Black;
            lb_vd_4.ForeColor = Color.Black;
            lb_vd_5.ForeColor = Color.Black;
            lb_vd_6.ForeColor = Color.Black;
            //Segundo bloco
            lb_nu_0.ForeColor = Color.Black;
            lb_nu_1.ForeColor = Color.Black;
            //Terceiro bloco
            lb_ss_0.ForeColor = Color.Black;
            lb_ss_1.ForeColor = Color.Black;
            lb_ss_2.ForeColor = Color.Black;
            lb_ss_3.ForeColor = Color.Black;
            //Quarto bloco
            lb_ga_0.ForeColor = Color.Black;
            lb_ga_1.ForeColor = Color.Black;
            lb_ga_2.ForeColor = Color.Black;
            lb_ga_3.ForeColor = Color.Black;
            //Quinto bloco
            lb_fim_et4.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            lb_f_0.ForeColor = Color.Black;
            lb_f_1.ForeColor = Color.Black;
            lb_f_2.ForeColor = Color.Black;
            lb_f_3.ForeColor = Color.Black;
            lb_f_4.ForeColor = Color.Black;

        }

        private string Atualizacoes(int nun)
        {
            string[] atualizacoes = new string[6];
            atualizacoes[0] = "0x000000";
            atualizacoes[1] = "0x000001";
            atualizacoes[2] = "0x000002";
            atualizacoes[3] = "0x000003";
            atualizacoes[4] = "0x000004";
            atualizacoes[5] = "0f000004";
            return atualizacoes[nun];
        }

        private void btn_vamosCoemcar_Click(object sender, EventArgs e)
        {
            const int pixels = 120;
            for (int i = 0; i < pixels; i++)
            {
                pb_logotipo.Left += i + 10;
                Thread.Sleep(2);
                lb_vamosCoemcar.Left += i + 5;
                Thread.Sleep(3);
                btn_vamosCoemcar.Left += i;
                Thread.Sleep(4);
            }

            pb_logotipo.Enabled = false;
            pb_logotipo.Visible = false;
            lb_vamosCoemcar.Enabled = false;
            lb_vamosCoemcar.Visible = false;
            btn_vamosCoemcar.Enabled = false;
            btn_vamosCoemcar.Visible = false;

            p_desc.Visible = true;
            tabControl1.Visible = true;
            Et1();
            this.Refresh();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            p_desc.Visible = false;
            tabControl1.Visible = false;
            pb_logotipo.Enabled = true;
            pb_logotipo.Visible = false;
            lb_vamosCoemcar.Enabled = true;
            lb_vamosCoemcar.Visible = false;
            btn_vamosCoemcar.Enabled = true;
            btn_vamosCoemcar.Visible = false;

            pb_logotipo.Left = 0;
            lb_vamosCoemcar.Left = -400;
            btn_vamosCoemcar.Left = 0;
            iniciarAnimacoes.Enabled = true;
        }

        private void iniciarAnimacoes_Tick(object sender, EventArgs e)
        {
            pb_logotipo.Visible = true;
            for (int i = 0; i < 380; i++)
            {
                pb_logotipo.Left = i;
                pb_logotipo.Refresh();
            }
            Thread.Sleep(10);
            lb_vamosCoemcar.Visible = true;
            for (int i = 0; i < 704; i++)
            {
                lb_vamosCoemcar.Left += 1;
                lb_vamosCoemcar.Refresh();
            }
            Thread.Sleep(2);
            btn_vamosCoemcar.Visible = true;
            for (int i = 0; i < 352; i++)
            {
                btn_vamosCoemcar.Left = i;
                btn_vamosCoemcar.Refresh();
            }

            iniciarAnimacoes.Enabled = false;
            iniciarAnimacoes.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void Et1()
        {
            this.Refresh();
            lb_op_et1.Text = "Verificando Banco de Dados Biblioteca Fácil...";
            lb_op_et1.Refresh();
            Thread.Sleep(1500);
            lb_vd_1.ForeColor = Color.White;
            if (File.Exists("C:\\Biblioteca Fácil\\EREMOL.db"))
            {
                lb_vd_1.ForeColor = Color.Chartreuse;
            }
            else
            {
                lb_vd_1.ForeColor = Color.Red;
                lb_op_et1.Text = "BANCO NÃO DETECTADO - OPERAÇÃO FINALIZADA";
                lb_op_et1.ForeColor = Color.Red;
                StopOperatinon("O Banco de Dados do Biblioteca Fácil não foi localizado ou está inacessível.");
                return;
            }

            this.Refresh();
            Thread.Sleep(1000);
            lb_op_et1.Text = "Verificando Banco de Dados Didáticos...";
            lb_op_et1.Refresh();
            lb_vd_2.ForeColor = Color.White;
            lb_vd_2.Refresh();
            Thread.Sleep(1500);
            if (File.Exists("C:\\Biblioteca Fácil\\Didáticos\\Didaticos.db"))
            {
                lb_vd_2.ForeColor = Color.Chartreuse;
            }
            else
            {
                lb_vd_2.ForeColor = Color.Red;
                lb_vd_2.Refresh();
                Thread.Sleep(1000);
            }

            this.Refresh();
            Thread.Sleep(1000);
            lb_op_et1.Text = "Tenado se comunicar com EREMOL.db e Didaticos.db...";
            lb_op_et1.Refresh();
            lb_vd_3.ForeColor = Color.White;
            lb_vd_3.Refresh();
            /*
            if (MGlobais.TryConnection(1) && MGlobais.TryConnection(2))
            {
                lb_op_et1.Text = "Bancos Responsívos";
                lb_op_et1.Refresh();
                lb_vd_3.ForeColor = Color.Chartreuse;
                lb_vd_3.Refresh();
                Thread.Sleep(1000);
            }
            else
            {
                lb_op_et1.Text = "Algum dos Bancos ou ambos não respondeu(eram)";
                lb_op_et1.ForeColor = Color.Red;
                lb_op_et1.Refresh();
                Thread.Sleep(1500);
                lb_op_et1.ForeColor = Color.White;
                lb_op_et1.Refresh();
            }*/

            this.Refresh();
            Thread.Sleep(1000);
            lb_op_et1.Text = "Verificando Atualizações do Banco de Dados...";
            lb_op_et1.Refresh();
            lb_vd_4.ForeColor = Color.White;
            lb_vd_4.Refresh();
            for (int i = 0; i < 6; i++)
            {
                DataTable dt = new DataTable();
                dt = Banco.DQL(String.Format("select * from tb_atualizacao where N_COD = '{0}'", Atualizacoes(i)));
                if (dt.Rows.Count > 0)
                {
                    lb_op_et1.Text = String.Format("Atualização {0} instalada.", Atualizacoes(i));
                    lb_op_et1.Refresh();
                    Thread.Sleep(500);
                }
                else
                {
                    lb_op_et1.Text = String.Format("Atualização {0} não instalada. Resolvendo dependências...", Atualizacoes(i));
                    lb_op_et1.Refresh();
                    Thread.Sleep(500);
                    string codec = Atualizacoes(i);
                    /*
                    if (codec.Contains("f"))
                    {
                        codec = codec.Replace("f", "x");
                    }
                    if (MGlobais.UseANSI(codec) == false)
                    {
                        lb_op_et1.Text = String.Format("Atualização {0} não instalada. Erro ao instalar. Processo Finalizado", Atualizacoes(i));
                        lb_op_et1.ForeColor = Color.Red;
                        lb_op_et1.Refresh();
                        Thread.Sleep(500);
                        StopOperatinon(String.Format("A atualização {0} não está presente e não foi possível efetuar sua instalação. Tente manualmente a instalação desta pendência.", Atualizacoes(i)));
                        return;
                    }
                    else
                    {
                        lb_op_et1.Text = String.Format("Atualização {0} instalada!", Atualizacoes(i));
                        lb_op_et1.Refresh();
                        Thread.Sleep(500);
                    }*/
                }
            }
            lb_op_et1.Text = "Concluído!";
            lb_op_et1.Refresh();
            Thread.Sleep(1000);
            lb_vd_4.ForeColor = Color.Chartreuse;
            lb_vd_4.Refresh();

            lb_op_et1.Text = "Configurando Sistemas (Caso exista configurações pendêntes)...";
            lb_op_et1.Refresh();
            lb_vd_5.ForeColor = Color.White;
            lb_vd_5.Refresh();
            //Código da Função...

            Thread.Sleep(1500);
            lb_vd_5.ForeColor = Color.Chartreuse;
            lb_vd_5.Refresh();
            lb_op_et1.Text = "Verificando Integridade Dos Arquivos...";
            lb_op_et1.Refresh();
            lb_vd_6.ForeColor = Color.White;
            lb_vd_6.Refresh();
            if (File.Exists("C:\\Biblioteca Fácil\\SetupServiceEremol v1.3.msi") == false)
            {
                lb_op_et1.Text = "Instalador SMS 1.X não encontrado!";
                lb_op_et1.ForeColor = Color.Red;
                lb_vd_6.ForeColor = Color.Red;
                lb_vd_6.Refresh();
                lb_op_et1.Refresh();
                Thread.Sleep(1500);
                StopOperatinon("Instalador SMS 1.X > 1.2 não encontrado. Este instalador é necessário para a instalação de uma das ferramentas do Biblioteca Fácil.");
                return;
            }
            else if (File.Exists("C:\\Biblioteca Fácil\\client_id.json") == false)
            {
                lb_op_et1.Text = "Autenticador client_id não encontrado!";
                lb_op_et1.ForeColor = Color.Red;
                lb_vd_6.ForeColor = Color.Red;
                lb_vd_6.Refresh();
                lb_op_et1.Refresh();
                Thread.Sleep(1500);
                StopOperatinon("Autenticador client_id não encontrado. Este arquivo json têm informações do Host Google Api. É necessário sua presença. Entre em contato com o suporte pelo UserEmail: suporte.bfacil@gmail.com e solicite o seu.");
                return;
            }
            Thread.Sleep(1500);
            lb_op_et1.Text = "Inicialização Completa!";
            lb_op_et1.ForeColor = Color.DarkGreen;
            lb_op_et1.Refresh();
            lb_vd_6.ForeColor = Color.Chartreuse;
            lb_vd_6.Refresh();
            lb_vd_0.ForeColor = Color.White;
            Thread.Sleep(1500);
            lb_op_et1.Visible = false;
            this.Refresh();
            Et2();
        }

        private void Et2()
        {
            tabControl1.SelectedIndex = 1;
            et2.Focus();
            et2.Show();
            Thread.Sleep(500);
            lb_nu_1.ForeColor = Color.White;
            lb_nu_1.Refresh();
            this.Refresh();
        }

        private void tb_serial_et2_TextChanged(object sender, EventArgs e)
        {
            if (tb_serial_et2.Text.Length == 10 && lb_tipo_et2.Visible == false)
            {
                int serialcode = MGlobais.TipoSerial(tb_serial_et2.Text);
                lb_tipo_et2.Visible = true;
                switch (serialcode)
                {
                    case 0:
                        lb_tipo_et2.Text = "Avançado";
                        lb_tipo_et2.ForeColor = Color.DarkGreen;
                        lb_tipo_et2.Refresh();
                        break;
                    case 1:
                        lb_tipo_et2.Text = "Básico";
                        lb_tipo_et2.ForeColor = Color.DarkBlue;
                        lb_tipo_et2.Refresh();
                        break;
                    case 3:
                        lb_tipo_et2.Text = "Inválido";
                        lb_tipo_et2.ForeColor = Color.DarkRed;
                        lb_tipo_et2.Refresh();
                        break;
                }
            }
            else if (tb_serial_et2.Text.Length < 10 && lb_tipo_et2.Visible == true)
            {
                lb_tipo_et2.Visible = false;
            }
        }

        private void tb_Rsenha_et2_TextChanged(object sender, EventArgs e)
        {
            if (tb_senha_et2.Text.Length == tb_Rsenha_et2.Text.Length)
            {
                if (tb_senha_et2.Text != tb_Rsenha_et2.Text)
                {
                    lb_senha_et2.Visible = true;
                    lb_senha_et2.Text = "Senha diferente!";
                    lb_senha_et2.ForeColor = Color.DarkRed;
                }
                else
                {
                    lb_senha_et2.Visible = false;
                    btn_avancar_et2.Enabled = true;
                    btn_avancar_et2.BackColor = Color.MediumTurquoise;
                }
            }
            else if (tb_senha_et2.Text.Length > tb_Rsenha_et2.Text.Length && lb_senha_et2.Visible == true)
            {
                lb_senha_et2.Visible = false;
            }
        }

        private void btn_avancar_et2_Click(object sender, EventArgs e)
        {
            if (tb_nomeCompleto_et2.Text == "" || tb_userName_et2.Text == "" || tb_serial_et2.Text == "" || tb_senha_et2.Text == "" || tb_Rsenha_et2.Text == "")
            {
                MessageBox.Show("Informe todos os campos corretamente", "Informações Requisitadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MGlobais.TipoSerial(tb_serial_et2.Text) != 3)
                {
                    bool sqlInjection1 = MGlobais.AntiSQLInjection(tb_nomeCompleto_et2.Text);
                    bool sqlInjection2 = MGlobais.AntiSQLInjection(tb_userName_et2.Text);
                    bool sqlInjection3 = MGlobais.AntiSQLInjection(tb_senha_et2.Text);
                    bool sqlInjection4 = MGlobais.AntiSQLInjection(tb_Rsenha_et2.Text);
                    if (sqlInjection1 == true || sqlInjection2 == true || sqlInjection3 == true || sqlInjection4 == true)
                    {
                        MessageBox.Show("Alguns caracteres de um de seus campos não é permitido. Evite usar (', , '', or, and, ; etc)", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        int valorAuth = 0;
                        if (MGlobais.TipoSerial(tb_serial_et2.Text) == 1)
                        {
                            valorAuth = 1;
                        }
                        Banco.DML(String.Format("insert into tb_login (T_USER, T_SENHA, T_NOMECOMPLETO, N_PRIV) values ('{0}', '{1}', '{2}', '{3}')", tb_userName_et2.Text, tb_Rsenha_et2.Text, tb_nomeCompleto_et2.Text, valorAuth));
                        lb_nu_1.ForeColor = Color.Chartreuse;
                        lb_nu_0.ForeColor = Color.White;
                        lb_nu_0.Refresh();
                        lb_nu_1.Refresh();
                        MessageBox.Show("Usuário criado com êito", "Novo Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        et3();
                    }
                }
                else
                {
                    MessageBox.Show("Serial inválido", "SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
        private void et3()
        {
            servico.Enabled = true;
            tabControl1.SelectedIndex = 2;
            etapa3.Focus();
            etapa3.Show();
            Thread.Sleep(500);
            lb_ss_1.ForeColor = Color.White;
            lb_ss_1.Refresh();
            if (File.Exists("C:\\Biblioteca Fácil\\Serviço\\ServicoEREMOL.exe"))
            {
                lb_ss_1.Text += " (Já instalado)";
                lb_ss_1.ForeColor = Color.Chartreuse;
                lb_ss_1.Refresh();
            }
            else
            {
                MessageBox.Show("Agora vamos instalar o serviço SMTP do Biblioteca Fácil!\nAperte sempre em avançar para instalar a ferramenta.", "Serviço SMTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("C:\\Biblioteca Fácil\\SetupServiceEremol v1.3.msi");
                if (File.Exists("C:\\Biblioteca Fácil\\Serviço\\ServicoEREMOL.exe"))
                {
                    MessageBox.Show("O serviço não foi instalado!", "Serviço SMTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lb_ss_1.ForeColor = Color.Red;
                    lb_ss_1.Refresh();
                    StopOperatinon("O serviço não foi instalado. Este serviço deve ser instalado na máquina para que o sistema funcione corretamente. Sua função é controlar as informações do Banco de Dados e gerenciar os E-mails.");
                    return;
                }
                else
                {
                    lb_ss_1.ForeColor = Color.Chartreuse;
                    lb_ss_1.Refresh();
                }
            }
            lb_ss_2.ForeColor = Color.White;
            lb_ss_2.Refresh();
            if (File.Exists("C:\\Biblioteca Fácil\\Filas\\#confi\\conf.CCS"))
            {
                lb_confFind_et3.Text = "• Confiçurações encontradas";
                lb_confFind_et3.ForeColor = Color.DarkGreen;
                lb_confFind_et3.Refresh();
                lb_ss_2.ForeColor = Color.White;
                lb_ss_2.Refresh();

                StreamReader cred = new StreamReader("C:\\Biblioteca Fácil\\Filas\\#confi\\conf.CCS");
                tb_email_et3.Text = Cryptography.Decrypt.DecryptData(biblioteca.Scripts.Bin_Char.BinToChar(Scripts.HexToBin.ConverToBin(cred.ReadLine())));
                tb_password_et3.Text = Cryptography.Decrypt.DecryptData(biblioteca.Scripts.Bin_Char.BinToChar(Scripts.HexToBin.ConverToBin(cred.ReadLine())));
                tb_porta_et3.Text = Cryptography.Decrypt.DecryptData(biblioteca.Scripts.Bin_Char.BinToChar(Scripts.HexToBin.ConverToBin(cred.ReadLine())));
                tb_host_et3.Text = Cryptography.Decrypt.DecryptData(biblioteca.Scripts.Bin_Char.BinToChar(Scripts.HexToBin.ConverToBin(cred.ReadLine())));
                tb_username_et3.Text = Cryptography.Decrypt.DecryptData(biblioteca.Scripts.Bin_Char.BinToChar(Scripts.HexToBin.ConverToBin(cred.ReadLine())));
               /*
                if (MGlobais.VerificarServico("eremol.smtp") == false)
                {
                    ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
                }
               */
                btn_avncar_et3.Enabled = true;
                cred.Close();
            }
            else
            {
                lb_confFind_et3.Text = "• Confiçurações não encontradas";
                lb_confFind_et3.ForeColor = Color.DarkBlue;
                lb_confFind_et3.Refresh();
            }
            lb_ss_2.ForeColor = Color.Chartreuse;
            lb_ss_2.Refresh();
        }

        private void btn_pular_et3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você tem certeza que deseja pular esta etapa?\nEssa configuração pode ser feita depois.", "Serviço SMTP", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                lb_ss_2.ForeColor = Color.Silver;
                lb_ss_3.ForeColor = Color.Silver;
                lb_ss_0.ForeColor = Color.White;
                lb_ss_2.Refresh();
                lb_ss_3.Refresh();
                lb_ss_0.Refresh();
                Et4();
            }
        }

        private void Et4()
        {
            tabControl1.SelectedIndex = 3;
            p_et4.Visible = false;
            btn_avancar_et4.Visible = false;
            etapa4.Focus();
            etapa4.Show();
            Thread.Sleep(500);

            if (MGlobais.Internet())
            {
                lb_ga_1.ForeColor = Color.White;
                lb_ga_1.Refresh();
                if (File.Exists("C:\\Biblioteca Fácil\\credential\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user"))
                {
                    lb_ga_1.Text += " (Existente)";
                    lb_ga_1.ForeColor = Color.Chartreuse;
                    lb_ga_1.Refresh();
                    lb_ga_2.ForeColor = Color.Chartreuse;
                    lb_ga_2.Refresh();
                    lb_ga_3.ForeColor = Color.White;
                    lb_ga_3.Refresh();
                    p_et4.Visible = true;
                    btn_avancar_et4.Visible = true;
                    etapa4.Refresh();
                }
                else
                {
                    MessageBox.Show("Vamos gerar seu token de chamada. Você será redirecionado para o navegador, entre no Gmail com a conta que deseja armazenar os Backups e concorde com os termos e avance.\n\nSuas informações pessoais não serão usadas em nenhum momento pelo programa.", "Redirecionamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Google_Drive.IniciarProtocolos();
                    for (int i = 0; i < 120; i++)
                    {
                        if (File.Exists("C:\\Biblioteca Fácil\\credential\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user"))
                        {
                            lb_ga_1.ForeColor = Color.Chartreuse;
                            lb_ga_1.Refresh();
                            lb_ga_2.ForeColor = Color.Chartreuse;
                            lb_ga_2.Refresh();
                            lb_ga_3.ForeColor = Color.White;
                            lb_ga_3.Refresh();
                            p_et4.Visible = true;
                            btn_avancar_et4.Visible = true;
                            etapa4.Refresh();
                            break;
                        }
                        else
                        {
                            Thread.Sleep(1000);
                        }
                    }
                    if (File.Exists("C:\\Biblioteca Fácil\\credential\\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user") == false)
                    {
                        StopOperatinon("Time out\nO tempo para gerar o token foi atingido sem êxito da sua geração.");
                        return;
                    }
                }
            }
            else
            {
                lb_ga_0.Text = "G. API - No Internet";
                lb_ga_0.ForeColor = Color.Silver;
                lb_ga_1.ForeColor = Color.Red;
                lb_ga_2.ForeColor = Color.Red;
                lb_ga_3.ForeColor = Color.Red;
                lb_ga_0.Refresh();
                lb_ga_1.Refresh();
                lb_ga_2.Refresh();
                lb_ga_3.Refresh();
                MessageBox.Show("Não conseguimos se conectar com a internet. Esta etapa foi pulada automaticamente.", "Configurações de Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Finalizar();
                return;
            }
        }

        private void servico_Tick(object sender, EventArgs e)
        {
            if (tb_email_et3.Text != "" && tb_host_et3.Text != "" && tb_username_et3.Text != "" && tb_password_et3.Text != "" && tb_porta_et3.Text != "")
            {
                btn_avncar_et3.Enabled = true;
                btn_avncar_et3.BackColor = Color.MediumTurquoise;
            }
            else
            {
                btn_avncar_et3.Enabled = false;
                btn_avncar_et3.BackColor = Color.Transparent;
            }
        }

        private void btn_avncar_et3_Click(object sender, EventArgs e)
        {
            btn_avncar_et3.Cursor = Cursors.WaitCursor;
            //MGlobais.GerarCCS(tb_email_et3.Text, tb_password_et3.Text, int.Parse(tb_porta_et3.Text), tb_host_et3.Text, tb_username_et3.Text);
            lb_ss_2.ForeColor = Color.Chartreuse;
            lb_ss_2.Refresh();
            if (MGlobais.Internet())
            {
                lb_ss_3.ForeColor = Color.White;
                lb_ss_3.Refresh();
                Thread.Sleep(200);
                //MGlobais.GerarACC("Teste de Startup", "Teste do SMTP no startp do Biblioteca Fácil.\n\nTech Team™", "suporte.bfacil@gmail.com");
                Thread.Sleep(2500);
                if (File.Exists(String.Format("C:\\Biblioteca Fácil\\Filas\\{0}", Globais.fileNameCreted)) == false)
                {
                    lb_ss_3.ForeColor = Color.Chartreuse;
                    lb_ss_0.ForeColor = Color.White;
                    lb_ss_0.Refresh();
                    lb_ss_3.Refresh();
                }
                else
                {
                    lb_ss_3.ForeColor = Color.Red;
                    lb_ss_0.ForeColor = Color.White;
                    lb_ss_0.Refresh();
                    lb_ss_3.Refresh();
                }
            }
            else
            {
                lb_ss_3.Text += " No Internet";
                lb_ss_3.ForeColor = Color.Silver;
                lb_ss_0.ForeColor = Color.White;
                lb_ss_0.Refresh();
                lb_ss_3.Refresh();
            }
            btn_avncar_et3.Cursor = Cursors.Default;
            servico.Enabled = false;
            servico.Stop();
            Et4();
        }

        private void Finalizar()
        {
            if (rb_op1_et4.Checked)
            {
                Banco.DML("update tb_controle set auto_backup = true");
            }
            else
            {
                Banco.DML("update tb_controle set auto_backup = false");
            }
            lb_ga_3.ForeColor = Color.Chartreuse;
            lb_ga_0.ForeColor = Color.White;
            lb_ga_3.Refresh();
            lb_ga_0.Refresh();
            Thread.Sleep(1500);

            p_et4.Hide();
            btn_avancar_et4.Hide();
            etapa4.Refresh();

            lb_fim_et4.Visible = true;
            lb_fim_et4.Text = "Salvando chaves de registros...";
            lb_f_1.ForeColor = Color.White;
            lb_fim_et4.Refresh();
            Properties.Settings.Default.Instalador = 1;
            Properties.Settings.Default.First = 1;
            Properties.Settings.Default.Save();
            lb_f_1.ForeColor = Color.Chartreuse;
            lb_f_2.ForeColor = Color.White;
            lb_f_1.Refresh(); lb_f_2.Refresh();
            Thread.Sleep(200);
            lb_fim_et4.Text = "Atualizações de variável...";

            Properties.Settings.Default.Email = tb_email_et3.Text;
            Properties.Settings.Default.Host = tb_host_et3.Text;
            Properties.Settings.Default.UserEmail = tb_username_et3.Text;
            Properties.Settings.Default.SenhaEmail = tb_password_et3.Text;
            Properties.Settings.Default.Porta = int.Parse(tb_porta_et3.Text);
            Properties.Settings.Default.Save();

            lb_fim_et4.Refresh();
            lb_f_2.ForeColor = Color.Chartreuse;
            Thread.Sleep(200);
            lb_f_3.ForeColor = Color.Chartreuse;
            lb_fim_et4.Text = "Concluindo...";
            lb_fim_et4.Refresh();
            lb_f_3.Refresh();
            lb_f_0.ForeColor = Color.White;
            lb_f_0.Refresh();
            lb_f_4.ForeColor = Color.White;
            lb_f_4.Refresh();
            button1.Enabled = false;

            tabControl1.SelectedIndex = 4;
            fim.Focus();
            fim.Show();
            Thread.Sleep(500);
            tabControl1.Refresh();
            this.Refresh();
        }

        private void btn_avancar_et4_Click(object sender, EventArgs e)
        {
            Finalizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Launcher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                StopOperatinon("Chamada de teste");
                return;
            }
        }

        private void btn_finalizarErro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
