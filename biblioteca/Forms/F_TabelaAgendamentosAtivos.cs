using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_TabelaAgendamentosAtivos : Form
    {
        public F_TabelaAgendamentosAtivos()
        {
            InitializeComponent();
        }

        private void F_TabelaAgendamentosAtivos_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDEVENTO AS 'ID', T_SOLICITANTE AS 'Responsável', T_TIPOSOLICITANTE AS 'Tipo', T_PERIODO AS 'Período', T_AULA AS 'Aula(s)', T_TURMA AS 'Turma', T_ESTADO AS 'Estado', T_DATA AS 'Data'FROM tb_agendamento WHERE T_ESTADO='" + Globais.estado + "'";
            dgv_eventosAtivos.DataSource = Banco.DQL(vquery);
            dgv_eventosAtivos.Columns[0].Width = 65; //Id
            dgv_eventosAtivos.Columns[1].Width = 265; //Responsável
            dgv_eventosAtivos.Columns[2].Width = 130; //Tipo
            dgv_eventosAtivos.Columns[3].Width = 110; //Período
            dgv_eventosAtivos.Columns[4].Width = 130; //Aula
            dgv_eventosAtivos.Columns[5].Width = 100; //Turma
            dgv_eventosAtivos.Columns[6].Width = 70; //Estado
            dgv_eventosAtivos.Columns[7].Width = 80; //Data

        }

        private void hojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Today;
            string hoje = data.ToShortDateString();
            string vquery = "SELECT N_IDEVENTO AS 'ID', T_SOLICITANTE AS 'Responsável', T_TIPOSOLICITANTE AS 'Tipo', T_PERIODO AS 'Período', T_AULA AS 'Aula(s)', T_TURMA AS 'Turma', T_ESTADO AS 'Estado', T_DATA AS 'Data'FROM tb_agendamento WHERE T_ESTADO='" + Globais.estado + "' AND T_DATA='" + hoje + "'";
            dgv_eventosAtivos.DataSource = Banco.DQL(vquery);
            dgv_eventosAtivos.Columns[0].Width = 65; //Id
            dgv_eventosAtivos.Columns[1].Width = 265; //Responsável
            dgv_eventosAtivos.Columns[2].Width = 130; //Tipo
            dgv_eventosAtivos.Columns[3].Width = 110; //Período
            dgv_eventosAtivos.Columns[4].Width = 130; //Aula
            dgv_eventosAtivos.Columns[5].Width = 100; //Turma
            dgv_eventosAtivos.Columns[6].Width = 70; //Estado
            dgv_eventosAtivos.Columns[7].Width = 80; //Data
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDEVENTO AS 'ID', T_SOLICITANTE AS 'Responsável', T_TIPOSOLICITANTE AS 'Tipo', T_PERIODO AS 'Período', T_AULA AS 'Aula(s)', T_TURMA AS 'Turma', T_ESTADO AS 'Estado', T_DATA AS 'Data'FROM tb_agendamento WHERE T_ESTADO='" + Globais.estado + "'";
            dgv_eventosAtivos.DataSource = Banco.DQL(vquery);
            dgv_eventosAtivos.Columns[0].Width = 65; //Id
            dgv_eventosAtivos.Columns[1].Width = 265; //Responsável
            dgv_eventosAtivos.Columns[2].Width = 130; //Tipo
            dgv_eventosAtivos.Columns[3].Width = 110; //Período
            dgv_eventosAtivos.Columns[4].Width = 130; //Aula
            dgv_eventosAtivos.Columns[5].Width = 100; //Turma
            dgv_eventosAtivos.Columns[6].Width = 70; //Estado
            dgv_eventosAtivos.Columns[7].Width = 80; //Data
        }
    }
}
