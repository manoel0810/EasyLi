using System;
using System.Data;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Menu : Form
    {
        Thread RetiradaLivro;
        Thread Devolucao;
        Thread BuscarLivro;
        Thread BuscarAluno;
        Thread TabelaEmprestados;
        Thread TabelaDevolvidos;
        Thread TabelaTodos;
        Thread CorrigirDados;
        Thread ExcluirDados;
        Thread Agendar;
        Thread ConcluirAgendamento;
        Thread AlterarDadosAgenda;
        Thread TabelaAgendamentoAtivo;
        Thread TabelaAgendamentoFinalizado;
        Thread NovoEvento;
        Thread ConcluirEvento;
        Thread AlterarEvento;
        Thread TabelaEventosAtivos;
        Thread InformacoesDoProduto;
        Thread LivrosPerdidos;
        Thread NovaTurma;
        Thread EditarTurma;
        Thread DadosLogin;
        Thread RegistroMassa;
        Thread GerarPdfExp;
        Thread Suporte;
        Thread Sair;
        Thread Notificar;
        Thread RA;
        int sairProc = 0;

        public F_Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja sair do aplicativo? Dados não salvos serão perdidos!", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == res)
            {
                sairProc = 1;
                Sair = new Thread(sair);
                Sair.SetApartmentState(ApartmentState.STA);
                Sair.Start();
                this.Close();
            }
        }

        private void sair()
        {
            Application.Run(new Form1());

        }

        private void registrarRetiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetiradaLivro = new Thread(retiradalivro);
            RetiradaLivro.SetApartmentState(ApartmentState.MTA);
            RetiradaLivro.Start();
        }

        private void retiradalivro()
        {
            Application.Run(new F_RegistroLivroSaindo());
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            //Verificar Datas;

            int retorno = MGlobais.ValidarDataDeLogin(); //Legenda - {-1} = Não é possível verificar; {1} = A data está correta?? S/N; {0} = A data está errada <break>;
            if (retorno == -1)
            {
                MessageBox.Show("Não foi possível verificar se a data atual está correta.\n\nOs registros podem ficar desorganizados caso as datas estejam erradas", "Erro de verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (retorno == 0)
            {
                MessageBox.Show("A data do cumputador está errada.\n\nPara usar o softwere, atualize as informações", "Data e Hora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sairProc = 1;
                Application.Exit();
            }

            //Fim da verificação


            this.KeyPreview = true;

            if (MGlobais.VerificarServico("eremol.smtp") == false)
            {
                ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
            }

            if (File.Exists(Properties.Settings.Default.CaminhoIMG))
            {
                pictureBox1.ImageLocation = Properties.Settings.Default.CaminhoIMG;
            }
            else
            {
                pictureBox1.ImageLocation = System.AppDomain.CurrentDomain.BaseDirectory + @"\MainTheme.jpg";
            }

            if (Properties.Settings.Default.First == 1)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\Documentação Biblioteca Fácil CM.pdf");
                MessageBox.Show("ATENÇÃO: O PROGRAMA ESTÁ SENDO LIBERADO SEM PASSAR POR TESTES A LONGO PRAZO, É POSSÍVEL A EXISTÊNCIA DE ERROS AINDA NÃO CORRIGIDOS. QUALQUER ERRO DEVE SER REPORTADO AO SUPORTE PARA POSTERIORMENTE SER LANÇADA UMA ATUALIZAÇÃO COM OS PACOTES DE CORREÇÕES DA VERSÃO.\nENTRE EM CONTATO COM O SUPORTE PELO EMAIL: \n\nsuporte.bfacil@gmail.com\n\n OU PELA TELA 'SUPORTE' NO APLICATIVO\n\nTech™ Inc.", "Nota Informativa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Properties.Settings.Default.First = 2;
                Properties.Settings.Default.Save();
            }
            //Agenda
            DataTable dt = new DataTable();
            DateTime hoje = DateTime.Today;
            string data = hoje.ToShortDateString();
            string vquery = "SELECT T_DATA FROM tb_agendamento WHERE T_DATA='" + data + "' AND T_ESTADO='" + Globais.estado + "'";
            dt = Banco.DQL(vquery);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Lembrete!\n\nVocê possue agenda para hoje!", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Eventos
            DataTable da = new DataTable();
            string query = "SELECT T_INICIO FROM tb_eventos WHERE T_INICIO='" + data + "' AND T_ESTADO='" + Globais.estado + "'";
            da = Banco.DQL(query);
            if (da.Rows.Count > 0)
            {
                MessageBox.Show("Evento(s) têm início(s) hoje!", "Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DataTable informacoesUser = new DataTable();
            informacoesUser = Banco.DQL("SELECT * FROM tb_login WHERE T_USER = '" + Globais.userLog + "'");
            Globais.priv = int.Parse(informacoesUser.Rows[0].Field<Int64>("N_PRIV").ToString());

            if (MGlobais.Credenciais() == false)
            {
                notificarToolStripMenuItem.Enabled = false;
            }

            t_verificarServico.Start();
            if (MGlobais.Internet() == false)
            {
                Google_Drive.IniciarProtocolos();
            }
        }

        private void registrarDevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucao = new Thread(devolucao);
            Devolucao.SetApartmentState(ApartmentState.MTA);
            Devolucao.Start();
        }

        private void devolucao()
        {
            Application.Run(new F_DevolucaoLivro());
        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarLivro = new Thread(buscarlivro);
            BuscarLivro.SetApartmentState(ApartmentState.MTA);
            BuscarLivro.Start();
        }

        private void buscarlivro()
        {
            Application.Run(new F_BuscarLivro());
        }

        private void buscarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAluno = new Thread(buscaraluno);
            BuscarAluno.SetApartmentState(ApartmentState.MTA);
            BuscarAluno.Start();
        }

        private void buscaraluno()
        {
            Application.Run(new F_BuscarAluno());
        }

        private void emprestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaEmprestados = new Thread(tabelaEmprestados);
            TabelaEmprestados.SetApartmentState(ApartmentState.MTA);
            TabelaEmprestados.Start();
        }

        private void tabelaEmprestados()
        {
            Application.Run(new F_Tabela());
        }

        private void devolvidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaDevolvidos = new Thread(tabelaDevolvidos);
            TabelaDevolvidos.SetApartmentState(ApartmentState.MTA);
            TabelaDevolvidos.Start();
        }

        private void tabelaDevolvidos()
        {
            Application.Run(new F_TabelaDevolvidos());
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaTodos = new Thread(tabelaTodos);
            TabelaTodos.SetApartmentState(ApartmentState.MTA);
            TabelaTodos.Start();
        }

        private void tabelaTodos()
        {
            Application.Run(new F_TabelaTodos());
        }

        private void corrigirRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorrigirDados = new Thread(corrigirdados);
            CorrigirDados.SetApartmentState(ApartmentState.MTA);
            CorrigirDados.Start();
        }

        private void corrigirdados()
        {
            Application.Run(new F_CorrecaoDados());
        }

        private void exluirRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirDados = new Thread(excluirdados);
            ExcluirDados.SetApartmentState(ApartmentState.MTA);
            ExcluirDados.Start();
        }

        private void excluirdados()
        {
            Application.Run(new F_ExcluirResistro());
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agendar = new Thread(agendar);
            Agendar.SetApartmentState(ApartmentState.MTA);
            Agendar.Start();
        }

        private void agendar()
        {
            Application.Run(new F_Agendar());
        }

        private void concluirAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConcluirAgendamento = new Thread(concluiragendamento);
            ConcluirAgendamento.SetApartmentState(ApartmentState.MTA);
            ConcluirAgendamento.Start();
        }

        private void concluiragendamento()
        {
            Application.Run(new F_ConcluirAgendamento());
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarDadosAgenda = new Thread(alterardadosagenda);
            AlterarDadosAgenda.SetApartmentState(ApartmentState.MTA);
            AlterarDadosAgenda.Start();
        }

        private void alterardadosagenda()
        {
            Application.Run(new F_AlterarDadosAgenda());
        }

        private void agendamentosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaAgendamentoAtivo = new Thread(tabelaAgendamentoAtivo);
            TabelaAgendamentoAtivo.SetApartmentState(ApartmentState.MTA);
            TabelaAgendamentoAtivo.Start();
        }

        private void tabelaAgendamentoAtivo()
        {
            Application.Run(new F_TabelaAgendamentosAtivos());
        }

        private void agendamentosFinalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaAgendamentoFinalizado = new Thread(tabelaAgendamentoFinalizado);
            TabelaAgendamentoFinalizado.SetApartmentState(ApartmentState.MTA);
            TabelaAgendamentoFinalizado.Start();
        }

        private void tabelaAgendamentoFinalizado()
        {
            Application.Run(new F_TabelaAgendamentoFinalizado());
        }

        private void novoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoEvento = new Thread(novoevento);
            NovoEvento.SetApartmentState(ApartmentState.MTA);
            NovoEvento.Start();
        }

        private void novoevento()
        {
            Application.Run(new F_NovoEvento());
        }

        private void concluirEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConcluirEvento = new Thread(concluirevento);
            ConcluirEvento.SetApartmentState(ApartmentState.MTA);
            ConcluirEvento.Start();
        }

        private void concluirevento()
        {
            Application.Run(new F_FinalizarEvento());
        }

        private void alterarDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlterarEvento = new Thread(alterarEvento);
            AlterarEvento.SetApartmentState(ApartmentState.MTA);
            AlterarEvento.Start();
        }

        private void alterarEvento()
        {
            Application.Run(new F_AlterarDadosEventos());
        }

        private void tabelaEventosAtivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaEventosAtivos = new Thread(tabelaeventosativos);
            TabelaEventosAtivos.SetApartmentState(ApartmentState.MTA);
            TabelaEventosAtivos.Start();
        }

        private void tabelaeventosativos()
        {
            Application.Run(new F_TabelaEventosAtivos());
        }

        private void informaçõesDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacoesDoProduto = new Thread(informacoesDoProduto);
            InformacoesDoProduto.SetApartmentState(ApartmentState.STA);
            InformacoesDoProduto.Start();
        }

        private void informacoesDoProduto()
        {
            Application.Run(new F_InformacoesDoProduto());
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = Banco.DQL("SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_TURMA AS 'Turma' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO");
            GerarPDF.CriarPDF(dt, "Livros Para Devolução.pdf", "EMPRESTADOS");
        }

        private void perdidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LivrosPerdidos = new Thread(livrosperdidos);
            LivrosPerdidos.SetApartmentState(ApartmentState.MTA);
            LivrosPerdidos.Start();
        }

        private void livrosperdidos()
        {
            Application.Run(new F_TabelaPerdidos());
        }

        private void livrosPerdidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = Banco.DQL("SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_TURMA AS 'Turma' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.perdido + "' OR T_STATUS='" + Globais.bloqueado + "' ORDER BY T_TURMA, T_ALUNO");
            GerarPDF.CriarPDF(dt, "Livros PERDIDOS.pdf", "PERDIDOS");
        }

        private void novaTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaTurma = new Thread(novaturma);
            NovaTurma.SetApartmentState(ApartmentState.MTA);
            NovaTurma.Start();
        }

        private void novaturma()
        {
            Application.Run(new F_NovaTurma());
        }

        private void gerenciarTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarTurma = new Thread(editarturma);
            EditarTurma.SetApartmentState(ApartmentState.MTA);
            EditarTurma.Start();
        }

        private void editarturma()
        {
            Application.Run(new F_AlterarDadosTurma());
        }

        private void dadosDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosLogin = new Thread(dadoslogin);
            DadosLogin.SetApartmentState(ApartmentState.MTA);
            DadosLogin.Start();
            //AQUI
        }

        private void dadoslogin()
        {
            Application.Run(new F_AlterarLogin());
        }

        private void registroEmMassaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMassa = new Thread(registromassa);
            RegistroMassa.SetApartmentState(ApartmentState.MTA);
            RegistroMassa.Start();
        }

        private void registromassa()
        {
            Application.Run(new F_LivrosEmMassa());
        }

        private void gerarPDFEspecíficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarPdfExp = new Thread(gerarpdf);
            GerarPdfExp.SetApartmentState(ApartmentState.STA);
            GerarPdfExp.Start();
        }

        private void gerarpdf()
        {
            Application.Run(new F_CriarPDF());
        }

        private void F_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                registrarRetiradaToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.D)
            {
                registrarDevoluçãoToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                buscarLivroToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                buscarAlunoToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                agendarToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                corrigirRegistrosToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.K)
            {
                exluirRegistrosToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                sairToolStripMenuItem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.F)
            {
                agendamentosAtivosToolStripMenuItem.PerformClick();
            }
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suporte = new Thread(suporte);
            Suporte.SetApartmentState(ApartmentState.STA);
            Suporte.Start();
        }

        private void suporte()
        {
            Application.Run(new F_Suporte());
        }

        private void notificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notificar = new Thread(notificar);
            Notificar.SetApartmentState(ApartmentState.MTA);
            Notificar.Start();
        }

        private void notificar()
        {
            Application.Run(new F_Notificar());
        }

        private void F_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sairProc == 0)
            {
                DialogResult res = MessageBox.Show("Deseja sair do aplicativo? Dados não salvos serão perdidos!", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    sairProc = 1;
                    Sair = new Thread(sair);
                    Sair.SetApartmentState(ApartmentState.STA);
                    Sair.Start();
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void servidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.priv == 1)
            {
                MessageBox.Show("Você não tem permições para esta ferramenta.", "Acesso Limitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            F_ServidorEmail f_ServidorEmail = new F_ServidorEmail();
            f_ServidorEmail.ShowDialog();
        }

        private void manutençãoSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.priv == 1)
            {
                MessageBox.Show("Você não tem permições para esta ferramenta.", "Acesso Limitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SystemSound son = SystemSounds.Exclamation;
            son.Play();
            if (DialogResult.Yes == MessageBox.Show("Para executar este utilitário, deve-se fechar o Biblioteca Fácil. Deseja encerrar a execução?", "Manutenção SQLite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                sairProc = 1;
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.BaseDirectory + @"\GB SQLite\GestaoBanco.exe");
                Application.Exit();
            }
        }

        private void alterarPladoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string origemCompleto = "";
            string foto = "";
            string pastaDestino = Globais.caminho + @"\img\";
            string DestinoCompleto = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog.FileName;
                foto = openFileDialog.SafeFileName;
                DestinoCompleto = pastaDestino + foto;
            }
            else
            {
                return;
            }
            if (File.Exists(DestinoCompleto))
            {
                if (MessageBox.Show("Já Existe um arquivo com este nome, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            System.IO.File.Copy(origemCompleto, DestinoCompleto, true);
            if (File.Exists(DestinoCompleto))
            {
                Properties.Settings.Default.CaminhoIMG = Globais.caminho + @"\img\" + foto;
                Properties.Settings.Default.Save();
                pictureBox1.ImageLocation = DestinoCompleto;
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Houve um erro na cópia do arquivo.");
            }
        }

        private void relatórioAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RA = new Thread(ra);
            RA.SetApartmentState(ApartmentState.STA);
            RA.Start();
        }

        private void ra()
        {
            Application.Run(new F_RelatorioA());
        }

        private void gestãoBloqueadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoBloqueados f_GestaoBloqueados = new F_GestaoBloqueados();
            f_GestaoBloqueados.ShowDialog();
        }

        private void controleDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ControleUsuarios f_ControleUsuarios = new F_ControleUsuarios();
            f_ControleUsuarios.ShowDialog();
        }

        private void t_verificarServico_Tick(object sender, EventArgs e)
        {
            bool status = MGlobais.VerificarServico("eremol.smtp");
            MGlobais.SincronizarRegistros();
            DialogResult res = DialogResult.None;
            if (status == false)
            {
                try
                {
                    ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
                    return;

                }
                catch (Exception Er)
                {
                    if (Globais.notificacao == 1)
                    {
                        return;
                    }
                    t_verificarServico.Stop();
                    res = MessageBox.Show("Foi detectado um erro com o serviço SMTP.\nTentamos reiniciar o serviço, mas a tentativa falhou. Deseja tentar iniciar o serviço novamente?\nErro: " + Er.Message, "Erro No Serviço SMTP", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

                if (DialogResult.Retry == res)
                {
                    try
                    {
                        ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
                        MessageBox.Show("Serviço iniciado com êxito.", "Serviço SMTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception Er)
                    {
                        res = MessageBox.Show("Falha ao tentar iniciar novamente o serviço. ERRO: " + Er.Message + "\nTentaremos iniciar o serviço novamente após 3 minutos.\nDeseja ser notificado novamente?", "Erro no SMTP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (DialogResult.No == res)
                        {
                            Globais.notificacao = 1;
                            t_verificarServico.Start();
                            return;
                        }
                    }
                }
                else if (DialogResult.Cancel == res)
                {
                    res = MessageBox.Show("Tentaremos iniciar o serviço após 3 minutos. Durante este intervalo, as operações de E-Mail não funcionarão.\nDeseja ser notificado novamente?", "Falha no SMTP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.No == res)
                    {
                        Globais.notificacao = 1;
                    }
                    t_verificarServico.Start();
                }
            }
        }

        private void F_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globais.tentativasFalhadas = 0;
            Globais.controleSaida = 0;
            Globais.notificacao = 0;
            Globais.priv = 0;
            Globais.id = 0;
            this.Visible = false;
            this.Refresh();
            //Atualização da tabela controle
            int retorno = MGlobais.ValidarDataDeLogin(); //Legenda - {-1} = Não é possível verificar; {1} = A data está correta?? S/N; {0} = A data está errada <break>;
            string data = MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString());
            if (retorno == 1)
            {
                Banco.DML("update tb_controle set dt_LL = '" + data + "', dt_TL = '" + data + "' where id = 1");
            }
            //Fim da atualização
            DataTable dt = new DataTable();
            dt = Banco.DQL("select auto_backup from tb_controle");
            if (dt.Rows[0].Field<Boolean>("auto_backup") && File.Exists(@"C:\Biblioteca Fácil\credential\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user") && MGlobais.Internet() == false)
            {
                Globais.uploading = 1;
                nota.Visible = true;
                try
                {
                    bool espera = true;
                    while (espera)
                    {
                    INICIO:;
                        try
                        {
                            Banco.KillConections();
                            if (MGlobais.VerificarServico("eremol.smtp"))
                            {
                                ServicosWin.ServicosWin.StopService("cliente.smtp.EREMOL");
                            }
                            Google_Drive.IniciarProtocolos(false, false, false, true, false, false, "", "", @"C:\Biblioteca Fácil\EREMOL.db", "", "", "");
                            Banco.DML(String.Format("update tb_controle set last_backup = '{0}'", MGlobais.FormatarDataSQL(DateTime.Now.ToString())));
                            if (MGlobais.VerificarServico("eremol.smtp") == false)
                            {
                                ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
                            }
                        }
                        catch
                        {
                            goto INICIO;
                        }
                        espera = false;
                    }

                    Globais.uploading = 0;
                }
                catch (Exception Ex)
                {
                    ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
                    MessageBox.Show("Ocorreu um erro ao efetuar o Backup automático. Tente novamente manualmente.\nERRO:" + Ex.Message, "Erro Desconhecido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Globais.uploading = 0;
                    return;
                }
                nota.Text = "Google API - Upload finalizado.";
            }
        }

        private void livrosAtrasadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Atrasados f_Atrasados = new F_Atrasados();
            f_Atrasados.Show();
        }

        private void DidaticosMenuItem4_Click(object sender, EventArgs e) //FUNÇÃO DESABILITADA NESTA VERSÃO DO BILBIOTECA FÁCIL!!!!! --- CÓDIFO FONTE NÃO ALTERADO
        {
            if (File.Exists(@"C:\Biblioteca Fácil\Didáticos\Didaticos.exe") == false)
            {
                MessageBox.Show("Parece que você não possue o pacote de extenção do Biblioteca Fácil.\nPara usar a ferramenta Didáticos você precisa instalar o complemento do Bibliteca Fácil.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                StreamWriter cred = new StreamWriter(@"C:\Biblioteca Fácil\user.cred");
                cred.WriteLine(Globais.userLog);
                cred.Flush();
                cred.Close();
                System.Diagnostics.Process.Start(@"C:\Biblioteca Fácil\Didáticos\Didaticos.exe");
            }
        }

        private void backpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void livrosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarPDF.ListaLivros();
        }

        private void corrigirLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorrecaoLivros correcaoLivros = new CorrecaoLivros();
            correcaoLivros.ShowDialog();
        }
    }
}
