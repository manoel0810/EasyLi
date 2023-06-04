using System;
using System.Windows.Forms;

namespace biblioteca.Forms
{
    public partial class BackupTool : Form
    {
        public BackupTool()
        {
            InitializeComponent();
        }

        private void Denifirconfiguracoes_Click(object sender, EventArgs e)
        {
            GitProperties Props = new GitProperties();
            Props.ShowDialog();
            Props.Dispose();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            if (!VerificarGitController())
            {
                MessageBox.Show("Não foi possível verificar as credenciais de acesso ao serviço", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!MGlobais.Internet())
            {
                MessageBox.Show("Não foi possível se conectar com a internet", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            /*
            StartAnimation();        
            Global.GitController.UploadFile($"{Application.StartupPath}\\{Global.DATABASE_NAME}", $"{Global.DATABASE_NAME}", "sha");
            AnimationStop();
            MessageBox.Show("Upload concluído com êxito", "Backups", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close(); 
            */
        }

        private void Download_Click(object sender, EventArgs e)
        {
            if (!VerificarGitController())
            {
                MessageBox.Show("Não foi possível verificar as credenciais de acesso ao serviço", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!MGlobais.Internet())
            {
                MessageBox.Show("Não foi possível se conectar com a internet", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private bool VerificarGitController()
        {
            if (Global.GitController == null)
            {
                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.GithubToken) ||
                    string.IsNullOrWhiteSpace(Properties.Settings.Default.GithubOwner) ||
                    string.IsNullOrWhiteSpace(Properties.Settings.Default.GithubRepos))
                {
                    return false;
                }
                else
                {
                    Global.GitController = new GithubController.GitOperations("writeanyvalueanything", Properties.Settings.Default.GithubToken, Properties.Settings.Default.GithubOwner, Properties.Settings.Default.GithubRepos);
                    return true;
                }
            }
            else
                return true;
        }

        private void StartAnimation()
        {
            Upload.Enabled = false;
            Download.Enabled = false;

            WaitLabel.Visible = true;
            Progress.Visible = true;
            Progress.Style = ProgressBarStyle.Marquee;
            Progress.MarqueeAnimationSpeed = 25;
        }

        private void AnimationStop()
        {
            Upload.Enabled = true;
            Download.Enabled = true;

            WaitLabel.Visible = false;
            Progress.Visible = false;
            Progress.Style = ProgressBarStyle.Continuous;
            Progress.MarqueeAnimationSpeed = 0;
        }
    }
}
