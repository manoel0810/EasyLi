using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.ServiceProcess;
using System.Windows.Forms;

namespace GestaoBanco
{
    public partial class Form1 : Form
    {
        private static string erros = string.Empty;
        private static string output = string.Empty;
        private static bool selecionado1 = false;
        private static bool selecionado2 = false;
        private static int total = 0;
        private static int totalVolatil = 0;
        private static string log = string.Empty;
        private static string hj = DateTime.Today.ToShortDateString();
        private static string caminho = string.Empty;

        //DATATABLES QUE PODERÃO SER USADOS PARA ARMAZENAR DADOS MOMENTÂNEOS
        DataTable DataStore0 = new DataTable();
        DataTable DataStore1 = new DataTable();
        DataTable DataStore2 = new DataTable();
        DataTable DataStore3 = new DataTable();

        //VARIÁVEIS DE CONTROLE DOS DATATABLES
        bool is0U = false;
        bool is1U = false;
        bool is2U = false;
        bool is3U = false;

        public static object ECP_ENCRI01 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private static void Log()
        {
            Random num = new Random();
            int id = num.Next(11111, 99999);
            log = log.Replace("\'", "\\");
            File.WriteAllText("C:\\Biblioteca Fácil\\GB SQLite\\logs\\log-" + id + ".LBF", log + "\r\nTech™ Inc. - Sistema de Diagnósticos Tech. <" + hj + "/>");
            log = string.Empty;
        }

        private bool IFs(string content)
        {
            bool res;
            if (content.Contains("<end/>"))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }

        private bool DependencesOn(string depedences)
        {
            bool depedencia = false;
            DataTable info = new DataTable();
            string[] codecs = depedences.Split(':');
            foreach(string stg in codecs)
            {
                info = Banco.Consultas(String.Format("select * from tb_atualizacao where N_COD = '{0}'", stg));
                if(info.Rows.Count == 0)
                {
                    output += String.Format("DEPENDENCIA DO PACOTE {0};\r\n", stg);
                    depedencia = true;
                }
            }
            log += output;
            return depedencia;
        }

        private void DML()
        {
            string data = DateTime.Today.ToString();
            string valoratual = string.Empty;
            string codigo = string.Empty;
            string info = string.Empty;
            string query = string.Empty;
            int controle = 0;
            int fist = 0;
            int last = 0;
            int resu = 0;
            int no_cod = 0;
            log += "<Variáveis declaradas/>\r\n";
            StreamReader ler = new StreamReader(caminho);
            valoratual = ler.ReadLine();
            log += "<Objeto StreamReader ler = new StreamReader('" + caminho + "')/>\r\n";

            tb_processo.Text += "Processo Iniciado - DML";
            log += "<Processo inciado.../>\r\n";

            if (valoratual.Contains("<no_cod><no_cod/>"))
            {
                log += "<Argumento primário - <no_cod><no_cod/>/>\r\n";
                no_cod = 1;
            }

            while (controle == 0)
            {
                valoratual = ler.ReadLine();
                log += "<Entrando no loop While/>\r\n";
                if (IFs(valoratual) == false)
                {
                    controle = 1;
                    log += "<Argumento {<end/>} achado || Finalizando operação/>\r\n";
                    ler.Close();
                    log += "<Objeto ler finalizado || ler.close()/>\r\n";
                    log += "<ExitCode(0)/>\r\n";
                    Log();
                    break;
                }
                else
                {
                    log += "<Efetuando leitura/>\r\n";
                    codigo = valoratual.Substring(0, 8);
                    log += "<Código da atualização {'" + codigo + "'}/>\r\n";
                    DataTable dt = new DataTable();

                    if (no_cod == 0)
                    {
                        dt = Intermediario.Consultas("SELECT * FROM tb_atualizacao WHERE N_COD = '" + codigo + "'");
                    }

                    

                    log += "<Efetuando a validação da atualização {'" + codigo + "'}/>\r\n";
                    if (dt.Rows.Count == 0)
                    {
                        log += "<Não instalada - Preparando-se para criar argumentos/>\r\n";
                        log += "<Procurando Árvore de Dependências.../>\r\n";                     
                        if(no_cod == 0)
                        {
                            int n1 = valoratual.IndexOf("~") + 1, n2 = (valoratual.Length - n1) - 1;
                            string dep = valoratual.Substring(n1, n2);
                            bool ret = DependencesOn(dep);
                            if (ret == true)
                            {
                                tb_processo.Text = string.Empty;
                                tb_processo.Text = String.Format("Dependências encontradas sem instalação - A atualização {0} não será instalada.\r\nPENDENCIAS:\r\n", codigo);
                                tb_processo.Text += output;
                                tb_processo.Text += "Seguindo para próxima atualização";
                                goto FIMELSE;
                            }
                            else
                            {
                                tb_processo.Text += "Pendências confirmadas e válidas - Instalando...";
                            }
                        }      
                        
                        fist = valoratual.IndexOf("|") + 1;
                        last = valoratual.LastIndexOf("|");
                        resu = last - 10;
                        info = valoratual.Substring(fist, resu);
                        log += "<Argumento Descrição montado {'" + info + "'}/>\r\n";

                        fist = valoratual.IndexOf("§") + 2;
                        resu = (valoratual.Length - fist) - 2;
                        query = valoratual.Substring(fist, resu);
                        log += "<Argumento Query montado {'" + query + "'}/>\r\n";

                        try
                        {
                            log += "<Entrando no Try/>\r\n";
                            try
                            {
                                Banco.Manipular(query);
                                log += "<Query executada/>\r\n";
                                Banco.Manipular("INSERT INTO tb_atualizacao (N_COD, T_INFO, T_DATA) VALUES ('" + codigo + "', '" + info + "', '" + data + "')");
                                log += "<Registro alterado/>\r\n";
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show("Houve um erro na leitura das atualizações: " + er.Message, "SQL Sintax Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                log += "<Query não executada - Motivo: '" + er.Message + "'/>\r\n";
                                log += "<Registro não alterado/>\r\n";
                            }
                        }
                        catch (Exception er)
                        {
                            Log();
                            controle = 1;
                            tb_processo.Clear();
                            tb_processo.Text += "HOUVE UM ERRO NO PROCESSO";
                            MessageBox.Show(er.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                    }
                    else
                    {
                        log += "<Atualização {'" + codigo + " já instalada - Prosseguindo'}/>\r\n";
                    }

                    no_cod = 0;
                }
            FIMELSE:;
            }
            controle = 0;
            SystemSound son = SystemSounds.Asterisk;
            son.Play();
            MessageBox.Show("Operação Finalizada", "SQLite Manutence Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void GravarAtuali()
        {
            try
            {
                DataTable dt = new DataTable();
                DataTable RES = new DataTable();
                dt = Banco.ConsultasRss("SELECT * FROM tb_atualizacao");
                int rows = dt.Rows.Count;
                int rowsR;
                log += "<Método iniciado.../>\r\n";
                for (int i = 0; i < rows; i++)
                {
                    log += "<Efetuado validação da atualização (" + dt.Rows[i].Field<string>("N_COD") + ")/>\r\n";
                    RES = Banco.Consultas("SELECT * FROM tb_atualizacao WHERE N_COD = '" + dt.Rows[i].Field<string>("N_COD") + "'");
                    rowsR = RES.Rows.Count;
                    if (rowsR < 1)
                    {
                        log += "<Atualização Não Cadastrada - Copiando.../>\r\n";
                        string vquery = String.Format("INSERT INTO tb_atualizacao (N_COD, T_INFO, T_DATA) VALUES ('{0}', '{1}', '{2}')", dt.Rows[i].Field<string>("N_COD"), dt.Rows[i].Field<string>("T_INFO"), dt.Rows[i].Field<string>("T_DATA"));
                        Banco.Manipular(vquery);
                        log += "<Copiada;/>\r\n";
                    }
                    else
                    {
                        log += "<Atualização Registrada - Ignorando/>\r\n";
                    }
                }
            }
            catch (Exception Er)
            {
                MessageBox.Show("ERRO: " + Er.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log();
                return;
            }
        }

        private bool Incluir(string tabela, string where, string chave)
        {
            bool resposta;
            string vquery = String.Format("SELECT * FROM {0} WHERE {1} = '{2}'", tabela, where, chave);
            DataTable dt = new DataTable();
            dt = Banco.Consultas(vquery);
            int resu = dt.Rows.Count;

            if (resu > 0)
            {
                resposta = false;
            }
            else
            {
                resposta = true;
            }

            return resposta;
        }
        private void Servico()
        {
            if (Globais.ServInst("eremol.smtp"))
            {
                lb_servicoIns.Text = "SERVIÇO INSTALADO";
                lb_servicoIns.ForeColor = Color.DarkGreen;
                lb_servicoIns.Refresh();

                ServiceControllerStatus estado = Globais.VerificarServico("eremol.smtp");
                if (estado == System.ServiceProcess.ServiceControllerStatus.Running)
                {
                    lb_servicoSta.Text = estado.ToString();
                    lb_servicoSta.ForeColor = Color.DarkGreen;
                    lb_servicoSta.Refresh();
                }
                if (estado == System.ServiceProcess.ServiceControllerStatus.Stopped)
                {
                    lb_servicoSta.Text = estado.ToString();
                    lb_servicoSta.ForeColor = Color.DarkRed;
                    lb_servicoSta.Refresh();

                }
                if (estado == System.ServiceProcess.ServiceControllerStatus.Paused)
                {
                    lb_servicoSta.Text = estado.ToString();
                    lb_servicoSta.ForeColor = Color.Purple;
                    lb_servicoSta.Refresh();
                }
                if (lb_servicoSta.Text == "...")
                {
                    lb_servicoSta.Text = "Indefinido - " + estado.ToString(); ;
                    lb_servicoSta.ForeColor = Color.DarkRed;
                    lb_servicoSta.Refresh();
                }

                lb_nomeServ.Text = "eremol.smtp";
                lb_nomeServ.ForeColor = Color.DarkGreen;
                lb_nomeServ.Refresh();
                //Versão não disponível no atual nível lógico

                //Verificar as Credenciais;
                if (File.Exists(@"C:\Biblioteca Fácil\Filas\#confi\conf.ccs"))
                {
                    lb_credCadas.Text = "ARQUIVO CCS ENCONTRADO";
                    lb_credCadas.ForeColor = Color.DarkGreen;
                    lb_credCadas.Refresh();

                    StreamReader CRED = new StreamReader(@"C:\Biblioteca Fácil\Filas\#confi\conf.ccs");
                    lb_email.Text = DecripInfo(CRED.ReadLine());
                    lb_pass.Text  = DecripInfo(CRED.ReadLine());
                    lb_porta.Text = DecripInfo(CRED.ReadLine());
                    lb_smtp.Text  = DecripInfo(CRED.ReadLine());
                    lb_uname.Text = DecripInfo(CRED.ReadLine());
                    CRED.Close();
                    btn_eT.Enabled = true;
                }
                else
                {
                    lb_credCadas.Text = "ARQUIVO CCS NÃO ENCONTRADO";
                    lb_credCadas.ForeColor = Color.DarkRed;
                    lb_credCadas.Refresh();
                    btn_eT.Enabled = false;
                    lb_email.Text = "...";
                    lb_pass.Text = "...";
                    lb_porta.Text = "...";
                    lb_smtp.Text = "...";
                    lb_uname.Text = "...";
                }

            }
            else
            {
                lb_servicoIns.Text = "NÃO INSTALADO";
                lb_servicoIns.ForeColor = Color.DarkRed;
                lb_servicoIns.Refresh();
                btn_sI.Enabled = false;
                btn_sP.Enabled = false;
                btn_sR.Enabled = false;
                btn_eT.Enabled = false;
                return;
            }
        }

        private void LerDB()
        {
            if (File.Exists(@"C:\Biblioteca Fácil\EREMOL.db"))
            {
                lb_estado.Text = "BANCO ACESSÍVEL";
                lb_estado.ForeColor = Color.DarkGreen;
                lb_estado.Refresh();
            }
            else
            {
                lb_estado.Text = "BANCO NÃO ACESSÍVEL";
                lb_conexao.Text = "FALHA NA CONEXÃO";
                erros += "BANCO NÃO ENCONTRADO NA PASTA DE DIRETÓRIO - ";
                lb_estado.ForeColor = Color.Red;
                lb_conexao.ForeColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                btn_restoreIn.Enabled = false;
                btn_alterar.Enabled = false;
                tb_erros.Text = erros;
                return;
            }
            string retornocon = Intermediario.Chamada();
            if (retornocon == "CONECTADO COM ÊXITO")
            {
                Globais.con = 1;
                lb_conexao.ForeColor = Color.DarkGreen;
                lb_conexao.Text = retornocon;
            }
            else if (retornocon == "FALHA NA CONEXÃO")
            {
                lb_conexao.ForeColor = Color.Red;
                lb_conexao.Text = retornocon;
            }
            else
            {
                lb_conexao.Text = "ERRO SEM TRATAMENTO";
                lb_conexao.ForeColor = Color.Purple;
            }

            Labels();

            lb_nTotal.Text = total.ToString();

            if (erros == "")
            {
                tb_erros.Text = "-SEM ERROS-";
            }
            else
            {
                tb_erros.Text = erros;
            }
        }

        public void Labels()
        {
            totalVolatil = Consultas("tb_dadosaluno");
            total += totalVolatil;
            lb_tMov.Text = totalVolatil.ToString();

            totalVolatil = Consultas("tb_turmas");
            total += totalVolatil;
            lb_tTur.Text = totalVolatil.ToString();

            totalVolatil = Consultas("tb_agendamento");
            total += totalVolatil;
            lb_tAge.Text = totalVolatil.ToString();

            totalVolatil = Consultas("tb_eventos");
            total += totalVolatil;
            lb_tLiv.Text = totalVolatil.ToString();

            try
            {
                totalVolatil = Consultas("tb_login");
                total += totalVolatil;
                lb_login.Text = totalVolatil.ToString();

                totalVolatil = Consultas("tb_matriculas");
                total += totalVolatil;
                lb_matriculas.Text = totalVolatil.ToString();

                totalVolatil = Consultas("tb_atualizacao");
                total += totalVolatil;
                lb_atualizacoes.Text = totalVolatil.ToString();
            }
            catch
            {
                MessageBox.Show("Houve erros na leitura das tabelas. O processo não foi concluído", "Banco de Dados - Incompatibilidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int Consultas(string tabela)
        {
            int total = 0;
            DataTable dt = new DataTable();
            dt = Intermediario.Consultas(String.Format("SELECT * FROM {0}", tabela));
            total = dt.Rows.Count;
            return total;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            F_LoginDev f_LoginDev = new F_LoginDev();
            f_LoginDev.ShowDialog();

            t_atualizarInformacoes.Start();

            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tp_administrativas);
            LerDB();
            Servico();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Biblioteca Fácil\EREMOL.db"))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Escolha onde deseja salvar seu backup";
                fbd.ShowDialog();
                string caminhodirec = fbd.SelectedPath;
                if (string.IsNullOrEmpty(caminhodirec))
                {
                    tb_processo.Text += "Nenhum caminho selecionado; " + "\r\n";
                    return;
                }
                else
                {
                    tb_processo.Text += "Caminho selecionado; " + "\r\n";
                    string caminho = fbd.SelectedPath + @"\" + "EREMOL.db";
                    System.IO.File.Copy(@"C:\Biblioteca Fácil\EREMOL.db", caminho, true);
                    tb_processo.Text += "Backup - finalizado; " + "\r\n";
                    MessageBox.Show("Backup feito");
                }
            }
            else
            {
                SystemSound son = SystemSounds.Beep;
                son.Play();
                MessageBox.Show("Não é possível localizar o banco raiz.");
                tb_processo.Text += "NÃO FOI POSSÍVEL LOCALIZAR O BANCO DE DADOS NA PASTA RAIZ; " + "\r\n";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog pfd = new OpenFileDialog();
            pfd.Filter = "(.DB).db|*.db";
            pfd.Title = "Selecione o arquivo DATA de backup";
            pfd.ShowDialog();
            string filename = pfd.SafeFileName;
            string caminhoSelc = pfd.FileName;
            if (caminhoSelc == "")
            {
                tb_processo.Text += "Nenhum caminho selecionado; " + "\r\n";
                return;
            }
            else
            {
                tb_processo.Text += "Arquivo selecionado: " + caminhoSelc + "\r\n";
                SystemSound son = SystemSounds.Exclamation;
                son.Play();
                DialogResult res = MessageBox.Show("Atenção: Se você prosseguir, o banco de dados atual do sistema será substituído pelo backup selecionado. Dados existentes no banco de dados atual, serão perdidos.\nDeseja continuar?", "Banco de Dados", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == res)
                {
                    try
                    {
                        tb_processo.Text += "Processo inicializado;" + "\r\n";
                        System.IO.File.Copy(caminhoSelc, @"C:\Biblioteca Fácil\EREMOL.db", true);
                        tb_processo.Text += "A operação terminou; \r\n";
                    }
                    catch (Exception)
                    {
                        tb_processo.Text += "HOUVERAM ERROS DURANTE O PROCESSO" + "\r\n";
                    }

                }
                else
                {
                    return;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_LBanco f_LBanco = new F_LBanco();
            f_LBanco.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(@"C:\Biblioteca Fácil\biblioteca.exe"))
            {
                DialogResult res = MessageBox.Show("Deseja abrir o 'Biblioteca Fácil?'", "Banco de Dados", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == res)
                {
                    System.Diagnostics.Process.Start(@"C:\Biblioteca Fácil\biblioteca.exe");
                }
                else
                {
                    return;
                }

            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //Função não compatível com a versão do BF Fácil :: Compatível com o BF Fácil CM
        }
        private static void For(DataTable dt, int rows, int tabela)
        {
            try
            {
                if (tabela == 0) //tb_dadosaluno
                {
                    for (int i = 0; i < rows; i++)
                    {
                        log += "<Copiando Registro No Ponto " + i + ".../>\r\n";
                        string vquery = String.Format("INSERT INTO tb_dadosaluno (T_ALUNO, T_LIVRO, T_STATUS, T_DATA, T_TURMA, T_MATRICULA, T_TOMBO, T_EMAIL, T_NOTAS) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", Globais.FormatarTxt(dt.Rows[i].Field<string>("T_ALUNO")), Globais.FormatarTxt(dt.Rows[i].Field<string>("T_LIVRO")), dt.Rows[i].Field<string>("T_STATUS"), Globais.FormatarDataSQL(dt.Rows[i].Field<DateTime>("T_DATA").ToShortDateString()), dt.Rows[i].Field<string>("T_TURMA"), dt.Rows[i].Field<string>("T_MATRICULA"), dt.Rows[i].Field<string>("T_TOMBO"), dt.Rows[i].Field<string>("T_EMAIL"), dt.Rows[i].Field<string>("T_NOTAS"));
                        Banco.Manipular(vquery);
                        log += "<Copiado;/>\r\n";
                    }
                }
                if (tabela == 2) //tb_eventos
                {
                    for (int i = 0; i < rows; i++)
                    {
                        log += "<Copiando Registro No Ponto " + i + "/>\r\n";
                        string vquery = String.Format("INSERT INTO tb_eventos (N_NOMEEVENTO, T_INFORMACAO, T_LOCAL, T_INICIO, T_FIM, T_ESTADO) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", Globais.FormatarTxt(dt.Rows[i].Field<string>("N_NOMEEVENTO")), Globais.FormatarTxt(dt.Rows[i].Field<string>("T_INFORMACAO")), Globais.FormatarTxt(dt.Rows[i].Field<string>("T_LOCAL")), dt.Rows[i].Field<string>("T_INICIO"), dt.Rows[i].Field<string>("T_FIM"), dt.Rows[i].Field<string>("T_ESTADO"));
                        Banco.Manipular(vquery);
                        log += "<Copiado;/>\r\n";
                    }
                }
                if (tabela == 3) //tb_agendamento
                {
                    for (int i = 0; i < rows; i++)
                    {
                        log += "<Copiando Registro No Ponto " + i + "/>\r\n";
                        string vquery = String.Format("INSERT INTO tb_agendamento (T_SOLICITANTE, T_TIPOSOLICITANTE, T_PERIODO, T_AULA, T_ESTADO, T_DATA, T_TURMA, T_EMAIL) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", Globais.FormatarTxt(dt.Rows[i].Field<string>("T_SOLICITANTE")), dt.Rows[i].Field<string>("T_TIPOSOLICITANTE"), dt.Rows[i].Field<string>("T_PERIODO"), dt.Rows[i].Field<string>("T_AULA"), dt.Rows[i].Field<string>("T_ESTADO"), dt.Rows[i].Field<string>("T_DATA"), dt.Rows[i].Field<string>("T_TURMA"), dt.Rows[i].Field<string>("T_EMAIL"));
                        Banco.Manipular(vquery);
                        log += "<Copiado;/>\r\n";
                    }
                }
                if (tabela == 4) //tb_turmas
                {
                    for (int i = 0; i < rows; i++)
                    {
                        log += "<Copiando Registro No Ponto " + i + "/>\r\n";
                        string vquery = String.Format("INSERT INTO tb_turmas (N_TURMA) VALUES ('{0}')", dt.Rows[i].Field<string>("N_TURMA"));
                        Banco.Manipular(vquery);
                        log += "<Copiado;/>\r\n";
                    }
                }
                if (tabela == 5) //tb_login
                {
                    for (int i = 0; i < rows; i++)
                    {
                        log += "<Verificando Registro No Ponto (" + i + ")/>\r\n";
                        bool resposta;
                        string vquery = String.Format("SELECT * FROM tb_login WHERE T_USER = '{0}'", dt.Rows[i].Field<string>("T_USER"));
                        DataTable ressu = new DataTable();
                        ressu = Banco.Consultas(vquery);
                        int resu = ressu.Rows.Count;

                        if (resu > 0)
                        {
                            log += "<Registro (" + i + ") Existente - Pulando/>\r\n";
                            resposta = false;
                        }
                        else
                        {
                            log += "<Registro (" + i + ") Não Encontrado No Banco Destino - Copiando/>\r\n";
                            resposta = true;
                        }

                        if (resposta)
                        {
                            string query = String.Format("INSERT INTO tb_login (T_USER, T_SENHA, T_NOMECOMPLETO, N_PRIV) VALUES ('{0}', '{1}', '{2}', '{3}')", dt.Rows[i].Field<string>("T_USER"), dt.Rows[i].Field<string>("T_SENHA"), dt.Rows[i].Field<string>("T_NOMECOMPLETO"), dt.Rows[i].Field<Int64>("N_PRIV"));
                            Banco.Manipular(query);
                            log += "<Copiado;/>\r\n";
                        }
                    }
                }
                if (tabela == 6) //tb_matriculas
                {
                    for (int i = 0; i < rows; i++)
                    {
                        log += "<Verificando Registro No Ponto (" + i + ")/>\r\n";
                        bool resposta;
                        string vquery = String.Format("SELECT * FROM tb_matriculas WHERE T_MATRICULA = '{0}'", dt.Rows[i].Field<string>("T_MATRICULA"));
                        DataTable ressu = new DataTable();
                        ressu = Banco.Consultas(vquery);
                        int resu = ressu.Rows.Count;

                        if (resu > 0)
                        {
                            log += "<Registro (" + i + ") Existente - Pulando/>\r\n";
                            resposta = false;
                        }
                        else
                        {
                            log += "<Registro (" + i + ") Não Encontrado No Banco Destino - Copiando/>\r\n";
                            resposta = true;
                        }

                        if (resposta)
                        {
                            string query = String.Format("INSERT INTO tb_matriculas (T_MATRICULA, T_ESTADO, T_ALUNO) VALUES ('{0}', '{1}', '{2}')", dt.Rows[i].Field<string>("T_MATRICULA"), dt.Rows[i].Field<string>("T_ESTADO"), dt.Rows[i].Field<string>("T_ALUNO"));
                            Banco.Manipular(query);
                            log += "<Copiado;/>\r\n";
                        }
                    }
                }
            }
            catch (Exception Er)
            {
                Log();
                MessageBox.Show("ERRO: " + Er.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btn_restoreIn_Click(object sender, EventArgs e)
        {
            try
            {
                log += "<Solicitação Restore-In requisitada/>\r\n";
                OpenFileDialog pfd = new OpenFileDialog();
                pfd.Filter = "(.DB).db|*.db";
                pfd.Title = "Selecione o arquivo EREMOL de backup";
                pfd.ShowDialog();
                string filename = pfd.SafeFileName;
                string caminhoSelc = pfd.FileName;
                if (caminhoSelc == "")
                {
                    tb_processo.Text += "Nenhum caminho selecionado; " + "\r\n";
                    return;
                }
                else
                {
                    log += "<Arquivo de Backup selecionado no path (" + caminhoSelc + ")/>\r\n";
                    DialogResult res = MessageBox.Show("Esta operação importará todos os dados de um local para o outro. Caso existam registros iguais, eles serão duplicados.\nDeseja continuar?", "Restore-In", MessageBoxButtons.YesNo);
                    if (DialogResult.No == res)
                    {
                        log += "<Requisiçao negada/>\r\n";
                        Log();
                        return;
                    }

                    log += "<Requisição aceita/>\r\n";
                    this.Cursor = Cursors.WaitCursor;

                    //Declarações gerais
                    string vquery = string.Empty;
                    int rows = 0;
                    Globais.caminhoSel = caminhoSelc;
                    DataTable dt = new DataTable();
                    log += "<Variáveis declaradas e preparadas/>\r\n\n";

                    //Manipulando dados tb_dadosaluno;
                    log += "<Iniciando processo para tb_dadosaluno/>\r\n";
                    vquery = "SELECT * FROM tb_dadosaluno";
                    dt = Banco.ConsultasRss(vquery);
                    rows = dt.Rows.Count;
                    log += "<Informações sobre a tabela/>\r\n";
                    log += "<Número de registros (" + rows + ")/>\r\n";
                    tb_processo.Text += "Importando tb_dadosaluno...\r\n";
                    log += "<Executanto método de Restore-In.../>\r\n";
                    tb_processo.Refresh();
                    For(dt, rows, 0);
                    log += "<Método executado.../>\r\n";
                    tb_processo.Text += "Concluído;\r\n";
                    tb_processo.Refresh();
                    log += "<tb_dadosaluno concluído - Prosseguindo.../>\r\n\n";

                    //Manipulando dados tb_eventos
                    log += "<Iniciando processo para tb_eventos/>\r\n";
                    vquery = "SELECT * FROM tb_eventos";
                    dt = Banco.ConsultasRss(vquery);
                    rows = dt.Rows.Count;
                    log += "<Informações sobre a tabela/>\r\n";
                    log += "<Número de registros (" + rows + ")/>\r\n";
                    tb_processo.Text += "Importando tb_eventos...\r\n";
                    log += "<Executanto método Restore-In.../>\r\n";
                    tb_processo.Refresh();
                    For(dt, rows, 2);
                    log += "<Método executado.../>\r\n";
                    tb_processo.Text += "Concluído;\r\n";
                    log += "<tb_eventos concluído - Prosseguindo.../>\r\n\n";
                    tb_processo.Refresh();

                    //Manipulando dados tb_agendamentos
                    log += "<Iniciando processo para tb_agendamentos/>\r\n";
                    vquery = "SELECT * FROM tb_agendamento";
                    dt = Banco.ConsultasRss(vquery);
                    rows = dt.Rows.Count;
                    log += "<Informações sobre a tabela/>\r\n";
                    log += "<Número de registros (" + rows + ")/>\r\n";
                    tb_processo.Text += "Importando tb_agendamento...\r\n";
                    log += "<Executanto método Restore-In.../>\r\n";
                    tb_processo.Refresh();
                    For(dt, rows, 3);
                    log += "<Método executado.../>\r\n";
                    tb_processo.Text += "Concluído;\r\n";
                    log += "<tb_agendamentos concluído - Prosseguindo.../>\r\n\n";
                    tb_processo.Refresh();

                    //Manipulando dados tb_turmas
                    log += "<Iniciando processo para tb_turmas/>\r\n";
                    vquery = "SELECT * FROM tb_turmas";
                    dt = Banco.ConsultasRss(vquery);
                    rows = dt.Rows.Count;
                    log += "<Informações sobre a tabela/>\r\n";
                    tb_processo.Text += "Importando tb_turmas...\r\n";
                    log += "<Número de registros (" + rows + ")/>\r\n";
                    log += "<Executanto método Restore-In.../>\r\n";
                    tb_processo.Refresh();
                    For(dt, rows, 4);
                    log += "<Método executado.../>\r\n";
                    tb_processo.Text += "Concluído;\r\n";
                    log += "<tb_turmas concluído - Prosseguindo.../>\r\n\n";
                    tb_processo.Refresh();

                    //Manipulando dados tb_login
                    log += "<Iniciando processo para tb_login/>\r\n";
                    log += "<Tabela Unique = true/>\r\n";
                    log += "<Análise de saída habilitada/>\r\n";
                    vquery = "SELECT * FROM tb_login";
                    dt = Banco.ConsultasRss(vquery);
                    rows = dt.Rows.Count;
                    log += "<Informações sobre a tabela_login/>\r\n";
                    log += "<Número de registros (" + rows + ")/>\r\n";
                    tb_processo.Text += "Importando tb_login...\r\n";
                    log += "<Executando método Restore-In.../>\r\n";
                    tb_processo.Refresh();
                    For(dt, rows, 5);
                    log += "<Método executado.../>\r\n";
                    tb_processo.Text += "Concluído;\r\n";
                    log += "<tb_login concluído - Prosseguindo/>\r\n\n";
                    tb_processo.Refresh();

                    //Manipulando dados tb_matriculas
                    log += "<Iniciando processo para tb_matriculas/>\r\n";
                    log += "<Tabela Unique = true/>\r\n";
                    log += "<Análise de saída habilitada/>\r\n";
                    vquery = "SELECT * FROM tb_matriculas";
                    dt = Banco.ConsultasRss(vquery);
                    rows = dt.Rows.Count;
                    log += "<Informações sobre a tabela tb_matriculas/>\r\n";
                    log += "<Número de Registros (" + rows + ")/>\r\n";
                    tb_processo.Text += "Importando tb_matriculas...\r\n";
                    log += "<Executanto método Restore-In.../>\r\n";
                    tb_processo.Refresh();
                    For(dt, rows, 6);
                    log += "<Método executado.../>\r\n";
                    tb_processo.Text += "Concluído;\r\n";
                    log += "<tb_matriculas concluído - Prosseguindo/>\r\n\n";
                    tb_processo.Refresh();

                    //Tabela Atualizações || Perguntar sobre ato
                    log += "<Restore Quest.../>\r\n";
                    log += "<Solicitanto permissão para importar tb_atualização/>\r\n";
                    DialogResult dialog = MessageBox.Show("Deseja importar os dados da tabela de atualizações?\n\nO ideal é fazer a transferência de data.", "SQLite Manutence Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == res)
                    {
                        log += "<Solicitação aceita - Iniciando prepatativos.../>\r\n";
                        tb_processo.Text += "Importanto tb_atualizacao...\r\n";
                        log += "<Chamando o Método GravarAtuali.../>\r\n";
                        GravarAtuali();
                        log += "<Método executado.../>\r\n\n";
                        tb_processo.Text += "Concluído;\r\n";
                    }
                    else
                    {
                        log += "<Solicitação Negada - Finalizando Operações.../>\r\n";
                    }

                    log += "<=======Operação de Restore-In Finalizada=======/>\r\n";
                    Log();
                    tb_processo.Text += "=======Operação de Restore-In Finalizada=======\r\n";

                    //Fim do Restore in
                    SystemSound son = SystemSounds.Exclamation;
                    son.Play();
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Restore-in Finalizado.");
                }
            }
            catch (Exception Er)
            {
                Log();
                MessageBox.Show("ERRO: " + Er.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total = 0;
            LerDB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Servico();
        }

        private void btn_sP_Click(object sender, EventArgs e)
        {
            if (Globais.VerificarServico("eremol.smtp") != System.ServiceProcess.ServiceControllerStatus.Stopped)
            {
                ServicosWin.ServicosWin.StopService("eremol.smtp");
                Servico();
            }
            else
            {
                MessageBox.Show("O serviço já está parado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sI_Click(object sender, EventArgs e)
        {
            if (Globais.VerificarServico("eremol.smtp") != System.ServiceProcess.ServiceControllerStatus.Running)
            {
                ServicosWin.ServicosWin.StartService("eremol.smtp");
                Servico();
            }
            else
            {
                MessageBox.Show("O serviço já está em execução!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sR_Click(object sender, EventArgs e)
        {
            if (Globais.VerificarServico("eremol.smtp") != System.ServiceProcess.ServiceControllerStatus.Stopped)
            {
                ServicosWin.ServicosWin.RestartService("eremol.smtp");
                Servico();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string DecripInfo(string Line_Hex)
        {
            string Return = string.Empty;
            Return = Cryptography.HexToBin.ConverToBin(Line_Hex);
            Return = Cryptography.Bin_Char.BinToChar(Return);
            Return = Cryptography.Decrypt.DecryptData(Return);
            return Return;
        }

        private void btn_eT_Click(object sender, EventArgs e)
        {
            F_EmailTeste f_EmailTeste = new F_EmailTeste();
            f_EmailTeste.ShowDialog();
            if (Globais.email == "")
            {
                return;
            }
            string subject = "E-MAIL DE TESTE DO SQLITE MANUTENCE SERVICE";
            string body = "E-MAIL PARA TESTE DO SERVIÇO DE E-MAILS DO BIBLITECA FÁCIL - EREMOL. ESTE E-MAIL ESTÁ SENDO ENVIADO PELO BACK-END DO SQLITE MANUTENCE SERVICE.\rTech™ Inc.";
            string email = Globais.email;

            //Criptografia;
            email = Cryptography.Bin_Char.CharToBin(Cryptography.Encrypt.EncryptData(email));
            email = Cryptography.Binary_Hex.ConverToHex(email);
            subject = Cryptography.Bin_Char.CharToBin(Cryptography.Encrypt.EncryptData(subject));
            subject = Cryptography.Binary_Hex.ConverToHex(subject);
            body = Cryptography.Bin_Char.CharToBin(Cryptography.Encrypt.EncryptData(body));
            body = Cryptography.Binary_Hex.ConverToHex(body);

            StreamWriter ESC = new StreamWriter(@"C:\Biblioteca Fácil\Filas\ARC-000000.acc");
            ESC.WriteLine(email);
            ESC.WriteLine(subject);
            ESC.WriteLine("<smtp_body>");
            ESC.WriteLine(body);
            ESC.WriteLine("<smtp_body/>");
            ESC.Flush();
            ESC.Close();

            MessageBox.Show("Arquivo ACC Gerado com as informações de teste", "Êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_rMatriz_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Atenção: Esta função altera a matriz do inicializável, tenha certeza que sabe o que está fazendo.\nDeseja continuar?", "System Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == res)
            {
                OpenFileDialog pfd = new OpenFileDialog();
                pfd.Filter = "(.ANSI).ansi|*.ansi";
                pfd.Title = "Selecione o arquivo ANSI de matriz";
                pfd.ShowDialog();
                string filename = pfd.SafeFileName;
                string caminhoSelc = pfd.FileName;
                if (caminhoSelc == "")
                {
                    tb_processo.Text += "Nenhum caminho selecionado; " + "\n";
                    return;
                }
                else
                {
                    tb_processo.Text += "Arquivo selecionado: " + caminhoSelc + "\r\n";
                    tb_processo.Refresh();
                    try
                    {
                        string voll = string.Empty;
                        tb_processo.Text += "Processo inicializado;" + "\r\n";
                        tb_processo.Refresh();
                        log += "<Variáveis Declaradas/>\r\n";
                        StreamReader let = new StreamReader(caminhoSelc);
                        log += "<StreamReader let = new StreamReader('" + caminhoSelc + "') || Objeto Declarado/>\r\n";
                        voll = let.ReadLine();
                        if (voll.Contains("<tipagem_SML><tipagem_SML/>"))  // SML - SQLite Manipulation Languege
                        {
                            tb_processo.Text += "Script de SML - Trocando Processo\r\n";
                            log += "<Script de SML - Trocando Processo/>";
                            let.Close();
                            log += "<Objeto let finalizado || let.close()/>";
                            log += "<Chamando Método DML(caminho = '" + caminhoSelc + "')/>";
                            caminho = caminhoSelc;
                            DML();
                            log += "<Método Executado - ExitCode(0) || retun;/>";
                            return;
                        }
                    }
                    catch
                    {


                    }
                }
            }
        }

        private void llb_limpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tb_processo.Clear();
        }

        private void tb_processo_TextChanged(object sender, EventArgs e)
        {
            if (tb_processo.Text != "")
            {
                llb_limpar.Visible = true;
            }
            else
            {
                llb_limpar.Visible = false;
            }
        }

        private void t_atualizarInformacoes_Tick(object sender, EventArgs e)
        {
            Servico();

            bool resposta = Intermediario.StatusDB();
            if (resposta == false)
            {
                MessageBox.Show("Detectamos um erro no Banco de Dados.\nA conexão não pode ser testada.\n\nA aplicação será encerrada.", "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btn_select1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.db)|*.db";
            ofd.Title = "Selecione o db.BANCO";
            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                return;
            }
            else
            {
                tb_L1.Text = ofd.FileName;
                Globais.LB1 = ofd.FileName;
                lb_CB1.Text = "CONECTADO";
                lb_CB1.ForeColor = Color.DarkGreen;
                selecionado1 = true;

                if (Intermediario.StatusDBX(1) == true)
                {
                    lb_SB1.Text = "ACESSÍVEL";
                    lb_SB1.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void btn_select2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.db)|*.db";
            ofd.Title = "Selecione o db.BANCO";
            ofd.ShowDialog();
            if (ofd.FileName == "")
            {
                return;
            }
            else
            {
                tb_L2.Text = ofd.FileName;
                Globais.LB2 = ofd.FileName;
                lb_CB2.Text = "CONECTADO";
                lb_CB2.ForeColor = Color.DarkGreen;
                selecionado2 = true;

                if (Intermediario.StatusDBX(2) == true)
                {
                    lb_SB2.Text = "ACESSÍVEL";
                    lb_SB2.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void tb_L1_TextChanged(object sender, EventArgs e)
        {
            if (tb_L1.Text != "" && lk_L1.Visible == false)
            {
                lk_L1.Visible = true;
            }
            else
            {
                lk_L1.Visible = false;
            }
        }

        private void tb_L2_TextChanged(object sender, EventArgs e)
        {
            if (tb_L2.Text != "" && lk_L2.Visible == false)
            {
                lk_L2.Visible = true;
            }
            else
            {
                lk_L2.Visible = false;
            }
        }

        private void lk_L1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tb_L1.Clear();
            selecionado1 = false;

            lb_CB1.Text = "DESCONECTADO";
            lb_CB1.ForeColor = Color.DarkRed;
            lb_SB1.Text = "SEM CONEXÃO";
            lb_SB1.ForeColor = Color.DarkRed;
        }

        private void lk_L2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tb_L2.Clear();
            selecionado2 = false;

            lb_CB2.Text = "DESCONECTADO";
            lb_CB2.ForeColor = Color.DarkRed;
            lb_SB2.Text = "SEM CONEXÃO";
            lb_SB2.ForeColor = Color.DarkRed;
        }

        private void rb_TCE_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_TCE.Enabled == true && p_subconfig.Enabled == false)
            {
                p_subconfig.Enabled = true;
            }
            else
            {
                p_subconfig.Enabled = false;
                rb_EBE.Checked = false;
                rb_EI.Checked = false;
            }

            if (btn_executarquery.Enabled == false)
            {
                btn_executarquery.Enabled = true;
                btn_limpar.Enabled = true;
            }

            lb_modoOp.Text = "MODO NÃO SELECIONADO";
        }

        private void rb_SI_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_executarquery.Enabled == false)
            {
                btn_executarquery.Enabled = true;
                btn_limpar.Enabled = true;
            }

            lb_modoOp.Text = rb_SI.Text;
        }

        private void rb_EBE_CheckedChanged(object sender, EventArgs e)
        {
            lb_modoOp.Text = rb_EBE.Text;
        }

        private void rb_EI_CheckedChanged(object sender, EventArgs e)
        {
            lb_modoOp.Text = rb_EI.Text;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_commandText.Clear();
        }

        private void ForeachCommand(DataTable DataStored, string Destino, string Table)
        {
            if (DataStored.Rows.Count == 0)
            {
                tb_depuracaoBancos.Text += ">-O DataStorege selecionado está vazil.\r\n";
                return;
            }
            else
            {
                tb_depuracaoBancos.Text += ">-Executando ForeachCommand;\r\n";
                int CollumnsCount = 0;
                CollumnsCount = DataStored.Columns.Count;
                string[] valores = new string[CollumnsCount];
                string valoresCortidos = string.Empty;
                for (int a = 0; a < DataStored.Rows.Count; a++)
                {
                    tb_depuracaoBancos.Text += ">-Processando Linha 0X" + a + "\r\n";
                    object[] itemArray = DataStored.Rows[a].ItemArray;
                    valores = (string[])itemArray;

                    foreach (string stg in valores)
                    {
                        valoresCortidos += String.Format("'{0}', ", stg);
                    }
                    valoresCortidos = valoresCortidos.Remove(valoresCortidos.LastIndexOf(","), 1);

                    string command = String.Format("insert into {0} values ({1})", Table, valoresCortidos);
                    if (Destino == "BI")
                    {
                        Banco.Manipular(command);
                    }
                    else if (Destino == "BX1")
                    {
                        Banco.ManipularBX1(command);
                    }
                    else if (Destino == "BX2")
                    {
                        Banco.ManipularBX2(command);
                    }

                    valoresCortidos = string.Empty;
                }
                tb_depuracaoBancos.Text += ">-Comando Executado(0);\r\n";
            }
        }
        private string GetCommand()
        {
            string resul = string.Empty;
            string conteudo = tb_commandText.Text;
            conteudo = conteudo.Substring(conteudo.IndexOf("@") + 1, ((conteudo.LastIndexOf("@") - conteudo.IndexOf("@")) -1));
            resul = conteudo;
            return resul;
        }

        private void ExecBanco(int BancoID, string Command, string Store)
        {
            DataTable dt = new DataTable();
            MessageBox.Show(Command);
            if (BancoID == 1)
            {
                dt = Banco.ConsultasBX1(Command);
            }
            else if (BancoID == 2)
            {
                dt = Banco.ConsultasBX2(Command);
            }
            else if (BancoID == -1)
            {
                dt = Banco.Consultas(Command);
            }
            
            if(Store == "DATASTORE1")
            {
                DataStore0 = dt;
                tb_depuracaoBancos.Text += ">-DS0 Carregado com "+dt.Rows.Count+" linhas\r\n";
            }else if(Store == "DATASTORE2")
            {
                DataStore1 = dt;
                tb_depuracaoBancos.Text += ">-DS1 Carregado com " + dt.Rows.Count + " linhas\r\n";
            }
            else if (Store == "DATASTORE3")
            {
                DataStore2 = dt;
                tb_depuracaoBancos.Text += ">-DS2 Carregado com " + dt.Rows.Count + " linhas\r\n";
            }
            else if (Store == "DATASTORE4")
            {
                DataStore3 = dt;
                tb_depuracaoBancos.Text += ">-DS3 Carregado com " + dt.Rows.Count + " linhas\r\n";
            }
        }

        private void btn_executarquery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_commandText.Text))
            {
                return;
            }

            int QualBD = 0;
            if (tb_commandText.Text.Contains("$1"))
            {
                QualBD = 1;
            }
            else if (tb_commandText.Text.Contains("$2"))
            {
                QualBD = 2;
            }
            else if (tb_commandText.Text.Contains("#1"))
            {
                QualBD = -1;
            }
            else
            {
                tb_depuracaoBancos.Text += ">-Para seguir, você deve especificar um Banco de Dados;\r\n>-Valores em $ & #;\r\n";
                return;
            }

            tb_depuracaoBancos.Text += ">-Banco " + QualBD + " selecionado\r\n";

            bool UsaDataStore = false;
            bool UsaForeach = false;

            if (tb_commandText.Text.Contains("DATASTORE"))
            {
                UsaDataStore = true;
            }

            if (tb_commandText.Text.Contains("FOREACHE"))
            {
                UsaForeach = true;
            }

            if (UsaDataStore)
            {
                if (tb_commandText.Text.Contains("DATASTORE1"))
                {
                    if (is0U == true)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Você ja carregou esse DataStore.\n\nDeseja substituir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ExecBanco(QualBD, GetCommand(), "DATASTORE1");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        ExecBanco(QualBD, GetCommand(), "DATASTORE1");
                        is0U = true;
                    }               
                    
                }
                else if (tb_commandText.Text.Contains("DATASTORE2"))
                {
                    if (is1U == true)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Você ja carregou esse DataStore.\n\nDeseja substituir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ExecBanco(QualBD, GetCommand(), "DATASTORE2");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        ExecBanco(QualBD, GetCommand(), "DATASTORE2");
                        is0U = true;
                    }
                }
                else if (tb_commandText.Text.Contains("DATASTORE3"))
                {
                    if (is2U == true)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Você ja carregou esse DataStore.\n\nDeseja substituir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ExecBanco(QualBD, GetCommand(), "DATASTORE3");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        ExecBanco(QualBD, GetCommand(), "DATASTORE3");
                        is0U = true;
                    }
                }
                else if (tb_commandText.Text.Contains("DATASTORE4"))
                {
                    if (is3U == true)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Você ja carregou esse DataStore.\n\nDeseja substituir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ExecBanco(QualBD, GetCommand(), "DATASTORE4");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        ExecBanco(QualBD, GetCommand(), "DATASTORE4");
                        is0U = true;
                    }
                }
            }

            if (UsaForeach)
            {
                ForeachCommand(DataStore0, "BX1", "tb_turmas");
            }
        }
    }
}
