using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Menu : Form
    {
        Thread GerarPdfExp;
        Thread Suporte;
        Thread Sair;
        Thread Notificar;
        Thread RA;
        private int ExitFlag = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja sair do aplicativo? Dados não salvos serão perdidos!", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                ExitFlag = 1;
                Thread Sair = new Thread(ExitThread);
                Sair.SetApartmentState(ApartmentState.STA);
                Sair.Start();
                Close();
            }
        }

        private void ExitThread()
        {
            Application.Run(new Login());
        }

        private void DisplayForm(object sender)
        {
            var MeForm = sender as Form;
            MeForm.ShowDialog();
            MeForm?.Dispose();
        }

        private void ReportPDF(Global.BookStatus Status, string Title, string Mode)
        {
            try
            {
                GerarPDF.CriarPDF(DatabaseController.DQL($"SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_DATA AS 'Data', T_TURMA AS 'Turma' FROM tb_dadosaluno WHERE T_STATUS='{Status}' ORDER BY T_TURMA, T_ALUNO"), Title, Mode);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha ao gerar o relatório. O sistema retornou: {e.Message}", "Relatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TakeoutBook(object sender, EventArgs e)
        {
            DisplayForm(new F_RegistroLivroSaindo());
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            //O serviço estará temporariamente indisponível nessa versão. (23/05/2023)
            /*
            if (MGlobais.VerificarServico("eremol.smtp") == false)
            {
                ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
            }
            */

            if (File.Exists($"{Application.StartupPath}\\img\\{Properties.Settings.Default.ImageName}"))
                pictureBox1.ImageLocation = $"{Application.StartupPath}\\img\\{Properties.Settings.Default.ImageName}";
            else
                if (File.Exists($"{Application.StartupPath}\\MainTheme.jpg"))
                pictureBox1.ImageLocation = $"{Application.StartupPath}\\MainTheme.jpg";

            /*
             * TODO: Remover a dinâmica de funcionamento a baixo
             */
            if (Properties.Settings.Default.First == 1)
            {
                Properties.Settings.Default.First = 2;
                Properties.Settings.Default.Save();
            }

            //Verificar o privilégio do usuário atual
            try { Global.CurrentUserPrivilege = (Global.UserPrivilege)int.Parse(DatabaseController.DQL($"SELECT * FROM tb_login WHERE T_USER = '{Global.CurrentUsername}'").Rows[0].Field<Int64>("N_PRIV").ToString()); } catch { Global.CurrentUserPrivilege = Global.UserPrivilege.Normal; }

            if (Global.CurrentUserPrivilege == Global.UserPrivilege.Normal)
                servidorToolStripMenuItem.Visible = false;

            Backup.Visible = false; //Sistema de backups não está funcionando na versão atual (23/05/2023)

            /*
                t_verificarServico.Start();
                if (MGlobais.Internet() == false)
                {
                    Google_Drive.IniciarProtocolos();
                }
            */
        }

        private void BookIn(object sender, EventArgs e)
        {
            DisplayForm(new F_DevolucaoLivro());
        }

        private void SearchStudent(object sender, EventArgs e)
        {
            DisplayForm(new F_BuscarAluno());
        }

        private void FixRecords(object sender, EventArgs e)
        {
            DisplayForm(new F_CorrecaoDados());
        }

        private void ProductInformation(object sender, EventArgs e)
        {
            DisplayForm(new F_InformacoesDoProduto());
        }

        private void PendingReturnsReport(object sender, EventArgs e)
        {
            ReportPDF(Global.BookStatus.Emprestado, "Livros pendentes para devolução", "Emprestados");
        }

        private void Losteport(object sender, EventArgs e)
        {
            ReportPDF(Global.BookStatus.Perdido, "Livros marcados como 'perdidos'", "Perdidos");
        }

        private void ClassCreate(object sender, EventArgs e)
        {
            DisplayForm(new F_NovaTurma());
        }

        private void ClassEdit(object sender, EventArgs e)
        {
            DisplayForm(new F_AlterarDadosTurma());
        }

        private void TakeoutBooks(object sender, EventArgs e)
        {
            DisplayForm(new F_LivrosEmMassa());
        }

        private void GenerateSpecialReport(object sender, EventArgs e)
        {
            DisplayForm(new F_CriarPDF());
        }

        private void F_Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.R)
            {
                registrarRetiradaToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.D)
            {
                registrarDevoluçãoToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.A)
            {
                buscarLivroToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.L)
            {
                buscarAlunoToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.E)
            {
                corrigirRegistrosToolStripMenuItem.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.S)
            {
                sairToolStripMenuItem.PerformClick();
            }
        }

        private void Support(object sender, EventArgs e)
        {
            DisplayForm(new F_Suporte());
        }

        private void F_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitFlag == 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja sair do aplicativo? Dados não salvos serão perdidos!", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    ExitFlag = 1;
                    Sair = new Thread(ExitThread);

                    Sair.SetApartmentState(ApartmentState.STA);
                    Sair.Start();
                    Close();
                }
                else
                    e.Cancel = true;

            }
        }

        private void SMTPService(object sender, EventArgs e)
        {
            DisplayForm(new F_ServidorEmail());
        }

        private void BackimageChenge(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os arquivos|*.*",
                Title = "Selecionar Imagem"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // O arquivo selecionado pode ser acessado através da propriedade OpenFileDialog.FileName
                string selectedFileName = openFileDialog.FileName;
                if (!Directory.Exists($"{Application.StartupPath}\\img\\"))
                    Directory.CreateDirectory($"{Application.StartupPath}\\img\\");

                try
                {
                    File.Copy(selectedFileName, $"{Application.StartupPath}\\img\\{Path.GetFileName(selectedFileName)}");
                    Properties.Settings.Default.ImageName = Path.GetFileName(selectedFileName);
                    Properties.Settings.Default.Save();
                }
                catch
                { MessageBox.Show("Não foi possível salvar a nova imagem", "Plano de fundo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void YearReport(object sender, EventArgs e)
        {
            DisplayForm(new F_RelatorioA());
        }

        private void BlockedUsers(object sender, EventArgs e)
        {
            DisplayForm(new F_GestaoBloqueados());
        }

        private void UserControl(object sender, EventArgs e)
        {
            DisplayForm(new F_ControleUsuarios());
        }

        private void ServiceCheck(object sender, EventArgs e)
        {
            /*
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
            */
        }

        private void F_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            Globais.tentativasFalhadas = 0;
            Globais.controleSaida = 0;
            Globais.notificacao = 0;
            Globais.id = 0;
            */

            Global.CurrentUserPrivilege = Global.UserPrivilege.Normal;

            /*
            this.Visible = false;
            this.Refresh();

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
            */
        }

        private void OutTimeBooks(object sender, EventArgs e)
        {
            DisplayForm(new F_Atrasados());
        }

        private void Backups(object sender, EventArgs e)
        {
            DisplayForm(new Backup());
        }

        private void RegistredBooksList(object sender, EventArgs e)
        {
            GerarPDF.ListaLivros();
        }

        private void FixBooks(object sender, EventArgs e)
        {
            DisplayForm(new CorrecaoLivros());
        }
    }
}
