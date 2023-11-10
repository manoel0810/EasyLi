using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca.Forms
{
    public partial class GetDatabaseInformation : Form
    {
        private readonly SearchMode Mode;
        private const int DGVMargin = 20;

        public string[] Arguments { get; private set; }
        public GetDatabaseInformation(SearchMode Mode)
        {
            InitializeComponent();
            this.Mode = Mode;
        }

        private void GetDatabaseInformation_Load(object sender, EventArgs e)
        {
            InitialAction();
            KeyPreview = true;
        }

        [Flags]
        public enum SearchMode : int
        {
            UserMode = 0,
            BookMode = 1
        }

        private void Filtro_TextChanged(object sender, EventArgs e)
        {
            if (Filtro.Text.Trim().Length == 0)
                InitialAction();
            else if (Filtro.Text.Trim().Length >= 2)
            {
                string SearchArg = MGlobais.SanitizeString(Filtro.Text);
                if (Mode == SearchMode.UserMode)
                    Dados.DataSource = DatabaseController.DataQueryLanguage($"select code as 'Matricula', user_name as 'Nome completo' from users where user_status != '{(int)Global.UserState.Blocked}' and user_name like '%{SearchArg}%' order by user_name limit 100");
                else if (Mode == SearchMode.BookMode)
                    Dados.DataSource = DatabaseController.DataQueryLanguage($"select id as 'Tombo', t_titulo as 'Nome do exemplar' from tb_livros where t_titulo like '%{SearchArg}%' order by t_titulo limit 100");
            }
        }

        private void InitialAction()
        {
            if (Mode == SearchMode.UserMode)
                Dados.DataSource = DatabaseController.DataQueryLanguage($"select code as 'Matricula', user_name as 'Nome completo' from users where user_status != '{(int)Global.UserState.Blocked}' order by user_name limit 100");
            else if (Mode == SearchMode.BookMode)
                Dados.DataSource = DatabaseController.DataQueryLanguage($"select id as 'Tombo', t_titulo as 'Nome do exemplar' from tb_livros order by t_titulo limit 100");

            Dados.Columns[0].Width = 60;
            Dados.Columns[1].Width = Dados.Width - (Dados.Columns[0].Width + DGVMargin);
        }

        private void Verify()
        {
            if (Dados.SelectedRows.Count > 0)
            {
                if (Mode == SearchMode.BookMode)
                    Arguments = new string[] { Dados.SelectedRows[0].Cells[0].Value.ToString(), Dados.SelectedRows[0].Cells[1].Value.ToString() };
                else if (Mode == SearchMode.UserMode)
                {
                    DataTable AllUserInformation = DatabaseController.DataQueryLanguage($"select * from users where code = '{Dados.SelectedRows[0].Cells[0].Value}'");
                    Arguments = new string[]
                    {
                        AllUserInformation.Rows[0].Field<string>("code"),
                        AllUserInformation.Rows[0].Field<string>("user_name"),
                        AllUserInformation.Rows[0].Field<string>("user_email")
                    };

                    AllUserInformation.Dispose();
                }

                Close();
            }
        }

        private void Dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Verify();
        }

        private void Dados_SelectionChanged(object sender, EventArgs e)
        {
            if (Dados.SelectedRows.Count > 0)
                ID.Text = Dados.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void GetDatabaseInformation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Enter)
                Verify();
        }
    }
}
