using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_TabelaEventosAtivos : Form
    {
        public F_TabelaEventosAtivos()
        {
            InitializeComponent();
        }

        private void F_TabelaEventosAtivos_Load(object sender, EventArgs e)
        {
            string vquey = "SELECT N_NOMEEVENTO AS 'Nome do Evento', T_LOCAL AS 'Local', T_INICIO AS 'Inicia Em', T_FIM AS 'Termina Em' FROM tb_eventos WHERE T_ESTADO='" + Globais.estado + "'";
            dgv_eventosAtivos.DataSource = Banco.DQL(vquey);
            dgv_eventosAtivos.Columns[0].Width = 300; //Nome do Evento
            dgv_eventosAtivos.Columns[1].Width = 300; //Local do Evento
            dgv_eventosAtivos.Columns[2].Width = 90; //Inicio do Evento
            dgv_eventosAtivos.Columns[3].Width = 90; //Fim do Evento

        }
    }
}
