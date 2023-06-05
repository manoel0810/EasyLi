using biblioteca.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class BookCheckout : Form
    {
        private readonly Global.BookStatus InitialBookState = Global.BookStatus.Emprestado;

        private int UserState = -1;
        private bool RegisteredUser = false;
        private bool RegisteredBooks = false;
        private string UserCode = string.Empty;

        public BookCheckout()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            foreach (Control c in Controls)
                if (c is TextBox obj)
                    obj.Clear();

            Tombo.Focus();
            Turma.SelectedIndex = 0;
            Save.Cursor = Cursors.Default;
            Save.Enabled = true;

            UserState = -1;
            UserCode = string.Empty;
        }

        private void RegistrarLivro()
        {
            if (!RegisteredBooks)
                DatabaseController.DML(String.Format("insert into tb_livros values ('{0}', '{1}', '{2}')", Tombo.Text, MGlobais.SanitizeString(Livro.Text), MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString())));
        }

        private void RegistrarUsuario()
        {
            if (!RegisteredUser)
                DatabaseController.DML($"insert into users values ('{UserCode}', '{MGlobais.SanitizeString(NomeUsuario.Text)}', '0')");
        }

        private void FormLoad(object sender, EventArgs e)
        {
            //Popular ComboBox Turmas
            Turma.DataSource = DatabaseController.DQL(@"SELECT * FROM tb_turmas ORDER BY N_TURMA");
            Turma.DisplayMember = "N_TURMA";
            Turma.ValueMember = "N_IDTURMA";

            DateTime hoje = DateTime.Today;
            string data = hoje.ToShortDateString();
            Data.Text = data;

            KeyPreview = true;

            Tombo.KeyPress += (_, Args) =>
            {
                if (!(Args.KeyChar >= 48 && Args.KeyChar <= 57))
                    if (Args.KeyChar != '\b')
                        Args.KeyChar = '\0';

                Args.Handled = false;
            };

            Matricula.KeyPress += (_, Args) =>
            {
                if (!(Args.KeyChar >= 48 && Args.KeyChar <= 57))
                    if (Args.KeyChar != '\b')
                        Args.KeyChar = '\0';

                Args.Handled = false;
            };
        }

        private void SaveClick(object sender, EventArgs e)
        {
            bool Validated = true;
            foreach (Control c in Controls)
                if (c is TextBox Box)
                    if (Box.Name != "Matricula" && Box.Name != "Email" && (string.IsNullOrWhiteSpace(Box.Text) || Box.Text.Trim().Length < 0x4))
                    {
                        Validated = false;
                        break;
                    }

            if (!Validated)
            {
                MessageBox.Show("Informe todos os campos corretamente", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (UserState == (int)Global.UserState.Blocked)
            {
                MessageBox.Show("Esta matrícula está bloqueada no sistema por alguma pendência. Para novos cadastros, retire o bloqueio do usuário.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearForm();
                return;
            }

            if (string.IsNullOrWhiteSpace(Matricula.Text))
            {
                var Answer = MessageBox.Show("A matrícula não foi informada. É obrigatório um usuário de referência. Se o solicitante atual é novo, você pode atribuir uma nova matrícula manualmente ou permitir que o sistema defina uma automaticamente.\n\nDeseja que a matrícula seja gerada pelo sistema?", "Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Answer == DialogResult.Yes)
                    UserCode = MGlobais.GenerateUserCode();
                else
                    return;
            }
            else
                UserCode = Matricula.Text;

            RegistrarLivro();
            RegistrarUsuario();

            Save.Enabled = false;
            Save.Cursor = Cursors.No;
            if (!string.IsNullOrWhiteSpace(Email.Text) && MGlobais.ValidateEmail(Email.Text) && MGlobais.CheckSMTPConfiguration())
                biblioteca.Email.EnviarEmail(string.Format("Olá {0}. Notamos que você realizou a retirada do livro '{1}'. Você possue 8(oito) dias para efetuar a devolução.", NomeUsuario.Text, Livro.Text), "EasyLi - Retirada de Livro", Email.Text);

            string vquery = @"INSERT INTO registry (T_USER, T_LIVRO, T_STATUS, T_DATA, T_DATAP, T_TURMA, T_MATRICULA, T_TOMBO, T_EMAIL) VALUES ('" + MGlobais.SanitizeString(NomeUsuario.Text) + "', '" + MGlobais.SanitizeString(Livro.Text) + "', '" + (int)InitialBookState + "', '" + MGlobais.FormatarDataSQL(Data.Text) + "', '" + MGlobais.FormatarDataSQL(Data.Text) + "', '" + Turma.Text + "', '" + UserCode + "', '" + Tombo.Text + "', '" + Email.Text + "')";
            DatabaseController.DML(vquery);

            if (DialogResult.Yes == MessageBox.Show("Salvo com êxito! Novo Cadastro?", "Banco de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                ClearForm();
            else
                Exit.PerformClick();

        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Exit.PerformClick();
            else if (e.KeyCode == Keys.Enter)
                Save.PerformClick();
            else if (e.Control && e.KeyCode == Keys.Q)
                ShowDialogSearch(GetDatabaseInformation.SearchMode.BookMode);
            else if (e.Control && e.KeyCode == Keys.W)
                ShowDialogSearch(GetDatabaseInformation.SearchMode.UserMode);
        }

        private void ShowDialogSearch(GetDatabaseInformation.SearchMode Mode)
        {
            GetDatabaseInformation GetInformation = new GetDatabaseInformation(Mode);
            GetInformation.ShowDialog();
            string[] Arguments = GetInformation.Arguments;
            GetInformation.Dispose();

            if (Arguments != null)
            {
                if (Mode == GetDatabaseInformation.SearchMode.BookMode)
                {
                    Tombo.Text = Arguments[0];
                    Livro.Text = Arguments[1];
                    RegisteredBooks = true;
                }
                else if (Mode == GetDatabaseInformation.SearchMode.UserMode)
                {
                    Matricula.Text = Arguments[0];
                    NomeUsuario.Text = Arguments[1];
                    RegisteredUser = true;
                }
            }
        }

        private void MatriculaLeave(object sender, EventArgs e)
        {
            if (Matricula.Text.Length < 0x3)
            {
                RegisteredUser = false;
                return;
            }

            DataTable Student;
            Student = DatabaseController.DQL($"select user_name, user_status from users where code = '{Matricula.Text}'");
            if (Student.Rows.Count > 0)
            {
                RegisteredUser = true;
                NomeUsuario.Text = Student.Rows[0].Field<string>("user_name");
                UserState = (int)Student.Rows[0].Field<Int64>("user_status");
                return;
            }
            else
            {
                RegisteredUser = false;
                return;
            }
        }

        private void TomboLeave(object sender, EventArgs e)
        {
            if (Tombo.Text.Length < 0x3)
            {
                RegisteredBooks = false;
                return;
            }

            DataTable Book;
            Book = DatabaseController.DQL($"select t_titulo from tb_livros where id = '{Tombo.Text}'");
            if (Book.Rows.Count > 0)
            {
                Livro.Text = Book.Rows[0].Field<string>("t_titulo");
                RegisteredBooks = true;
                return;
            }
            else
            {
                RegisteredBooks = false;
                return;
            }
        }
    }
}
