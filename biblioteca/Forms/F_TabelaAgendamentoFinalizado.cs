using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_TabelaAgendamentoFinalizado : Form
    {
        public F_TabelaAgendamentoFinalizado()
        {
            InitializeComponent();
        }

        private void F_TabelaAgendamentoFinalizado_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDEVENTO AS 'ID', T_SOLICITANTE AS 'Responsável', T_TIPOSOLICITANTE AS 'Tipo', T_PERIODO AS 'Período', T_AULA AS 'Aula(s)', T_ESTADO AS 'Estado', T_DATA AS 'Data'FROM tb_agendamento WHERE T_ESTADO='" + Globais.estadof + "'";
            dgv_eventosFinalizados.DataSource = Banco.DQL(vquery);
            dgv_eventosFinalizados.DataSource = Banco.DQL(vquery);
            dgv_eventosFinalizados.Columns[0].Width = 65; //Id
            dgv_eventosFinalizados.Columns[1].Width = 300; //Responsável
            dgv_eventosFinalizados.Columns[2].Width = 130; //Tipo
            dgv_eventosFinalizados.Columns[3].Width = 130; //Período
            dgv_eventosFinalizados.Columns[4].Width = 130; //Aula
            dgv_eventosFinalizados.Columns[5].Width = 100; //Estado
            dgv_eventosFinalizados.Columns[6].Width = 100; //Data

        }
    }
}
