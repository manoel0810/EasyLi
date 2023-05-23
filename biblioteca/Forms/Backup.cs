using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void updateForm()
        {
            DataTable dt = new DataTable();
            dt = Banco.DQL("select auto_backup, last_backup from tb_controle");
            if (dt.Rows[0].Field<Boolean>("auto_backup"))
            {
                lb_estado.Text = "Ativado";
                lb_estado.ForeColor = Color.DarkGreen;
                btn_alterarAuto.Text = "Desativar";
                btn_alterarAuto.ForeColor = Color.DarkRed;
            }
            else
            {
                lb_estado.Text = "Desativado";
                lb_estado.ForeColor = Color.DarkRed;
                btn_alterarAuto.Text = "Ativar";
                btn_alterarAuto.ForeColor = Color.DarkGreen;
            }
            DateTime date = dt.Rows[0].Field<DateTime>("last_backup");
            lb_lastB.Text = date.ToString();
            if (date.Subtract(DateTime.Today).Days >= 8)
            {
                lb_lastB.ForeColor = Color.DarkRed;
            }
            else
            {
                lb_lastB.ForeColor = Color.DarkGreen;
            }
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            updateForm();
            pb_animacoes.Image = Properties.Resources.db;
            if (MGlobais.VerificarServico("eremol.smtp"))
            {
                ServicosWin.ServicosWin.StopService("cliente.smtp.EREMOL");
            }
        }

        private void btn_alterarAuto_Click(object sender, EventArgs e)
        {
            if (Globais.priv != 0)
            {
                MessageBox.Show("Você não tem o privilégio necessário para alterar esta configuração", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lb_estado.Text == "Ativado")
            {
                Banco.DML("update tb_controle set auto_backup = false");
                updateForm();
            }
            else
            {
                Banco.DML("update tb_controle set auto_backup = true");
                updateForm();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void efetuarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MGlobais.Internet())
            {
                MessageBox.Show("Oops. Parece que você não tem conexão com a internet. Esta função precisa de uma conexão", "Internet Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (File.Exists(@"C:\Biblioteca Fácil\credential\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user") == false)
            {
                MessageBox.Show("Oops. Não conseguimos achar suas configurações de comunicação com o servidor.", "Google Drive API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("Ao executar este utilitário, será feito um backup do Banco de Dados do Biblioteca Fácil e do Didáticos caso você tenha o pacote extra. Deseja continuar?", "Fazer Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                pb_animacoes.Image = Properties.Resources.gif_upload;
                try
                {
                    lb_acao.ForeColor = Color.DarkOrange;
                    lb_acao.Text = "INICIANDO PROTOCOLOS...";
                    this.Refresh();
                    lb_acao.Text = "EFETUANDO O BACKUP EREMOL.DB...";
                    this.Refresh();
                    Google_Drive.IniciarProtocolos(false, false, false, true, false, false, "", "", "EREMOL.db", "", "", "");
                    lb_acao.Text = "VERIFICANDO EXISTÊNCIA DO DIDÁTICOS.DB";
                    this.Refresh();
                    if (File.Exists(@"C:\Biblioteca Fácil\Didáticos\Didaticos.db"))
                    {
                        lb_acao.Text = "ARQUIVO EXISTENTE > TRASNFERINDO";
                        this.Refresh();
                        Google_Drive.IniciarProtocolos(false, false, false, true, false, false, "", "", @"C:\Biblioteca Fácil\Didáticos\Didaticos.db", "", "", "");
                        lb_acao.Text = "BACKUPS FINALIADOS.";
                        this.Refresh();
                    }
                    else
                    {
                        lb_acao.Text = "ARQUIVO NÃO EXISTENTE > FINALIZADO.";
                        this.Refresh();
                    }
                    Banco.DML(String.Format("update tb_controle set last_backup = '{0}'", MGlobais.FormatarDataSQL(DateTime.Now.ToString())));
                    pb_animacoes.Image = Properties.Resources.db;
                    updateForm();
                    this.Refresh();
                }
                catch (Exception Ex)
                {
                    pb_animacoes.Image = Properties.Resources.gif_carregando;
                    lb_acao.Text = "OCORREU UM ERRO";
                    lb_acao.ForeColor = Color.DarkRed;
                    this.Refresh();
                    MessageBox.Show(Ex.ToString());
                }

            }
        }

        private void restaurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MGlobais.Internet())
            {
                MessageBox.Show("Oops. Parece que você não tem conexão com a internet. Esta função precisa de uma conexão", "Internet Response", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (File.Exists(@"C:\Biblioteca Fácil\credential\Google.Apis.Auth.OAuth2.Responses.TokenResponse-user") == false)
            {
                MessageBox.Show("Oops. Não conseguimos achar suas configurações de comunicação com o servidor.", "Google Drive API", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Atenção! Tenha certeza que o backup na nuvem é mais recente comparado ao na máquina. Se o backup da nuvem for mais antigo, você pode perder os dados que deram entrada após esse backup. Deseja continuar?", "Restaurar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    pb_animacoes.Image = Properties.Resources.gif_donwloading;
                    lb_acao.ForeColor = Color.DarkOrange;
                    lb_acao.Text = "INICIANDO PROTOCOLOS...";
                    this.Refresh();
                    lb_acao.Text = "PROCURANDO BACKUPS E BAIXANDO";
                    Google_Drive.IniciarProtocolos(false, false, true, false, false, false, "", "", "", @"C:\Biblioteca Fácil\down\EREMOL.db", "EREMOL.db", "");
                    lb_acao.Text = "VERIFICANDO EXISTÊNCIA DO DIDÁTICOS.DB";
                    this.Refresh();
                    if (File.Exists(@"C:\Biblioteca Fácil\Didáticos\Didaticos.db"))
                    {
                        lb_acao.Text = "ARQUIVO EXISTENTE > TRASNFERINDO";
                        this.Refresh();
                        Google_Drive.IniciarProtocolos(false, false, true, false, false, false, "", "", "", @"C:\Biblioteca Fácil\down\Didaticos.db", "Didaticos.db", "");
                        lb_acao.Text = "RESTAURAÇÃO FINALIZADA.";
                        this.Refresh();
                    }
                    else
                    {
                        lb_acao.Text = "ARQUIVO NÃO EXISTENTE > FINALIZADO.";
                        this.Refresh();
                    }
                    try
                    {
                        pb_animacoes.Image = Properties.Resources.gif_carregando;
                        lb_acao.Text = "TENTANDO MOVER OS BACKUPS PARA O DESTINO > EREMOL/EREMOL.DB";
                        lb_acao.Refresh();

                        if (File.Exists(@"C:\Biblioteca Fácil\down\EREMOL.db"))
                        {
                            File.Copy(@"C:\Biblioteca Fácil\down\EREMOL.db", @"C:\Biblioteca Fácil\EREMOL.db", true);
                        }
                        if (File.Exists(@"C:\Biblioteca Fácil\down\Didaticos.db"))
                        {
                            lb_acao.Text = "TENTANDO MOVER OS BACKUPS PARA O DESTINO > DIDÁTICOS/Didáticos/Didaticos.DB";
                            lb_acao.Refresh();
                            File.Copy(@"C:\Biblioteca Fácil\down\Didaticos.db", @"C:\Biblioteca Fácil\Didáticos\Didaticos.db", true);
                        }

                        lb_acao.Text = "ARQUIVOS COPIADOS : ÊXITO.";
                    }
                    catch (Exception Ex)
                    {
                        lb_acao.Text = "OCORREU UM ERRO";
                        lb_acao.ForeColor = Color.DarkRed;
                        this.Refresh();
                        MessageBox.Show(Ex.ToString());
                        MessageBox.Show(@"Os arquivos de backup estão no diretório C:\Biblioteca Fácil\down\. Você pode substituir os arquivos manualmente.", "Tratamento de falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Banco.DML(String.Format("update tb_controle set last_backup = '{0}'", MGlobais.FormatarDataSQL(DateTime.Now.ToString())));
                    pb_animacoes.Image = Properties.Resources.db;
                    updateForm();
                    this.Refresh();
                }
                catch (Exception Ex)
                {
                    pb_animacoes.Image = Properties.Resources.gif_carregando;
                    lb_acao.Text = "OCORREU UM ERRO";
                    lb_acao.ForeColor = Color.DarkRed;
                    this.Refresh();
                    MessageBox.Show(Ex.ToString());
                }
            }
        }

        private void Backup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MGlobais.VerificarServico("eremol.smtp") == false)
            {
                ServicosWin.ServicosWin.StartService("cliente.smtp.EREMOL");
            }
        }
    }
}
