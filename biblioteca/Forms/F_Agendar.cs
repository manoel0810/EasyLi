using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Agendar : Form
    {
        public F_Agendar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Agendar_Load(object sender, EventArgs e)
        {
            //Popular ComboBox Turmas
            string vqueryTurmas = @"SELECT * FROM tb_turmas ORDER BY N_TURMA";
            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.ObterTurmas(vqueryTurmas);
            cb_turmas.DisplayMember = "N_TURMA";
            cb_turmas.ValueMember = "N_IDTURMA";
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = MGlobais.ValidarString(tb_soliciante.Text);

            if (tb_soliciante.Text == "" || tb_aulas.Text == "" || cb_periodo.SelectedIndex == -1 || cb_tipo.SelectedIndex == -1 || mask_data.MaskCompleted == false)
            {
                MessageBox.Show("INFORME TODOS OS CAMPOS!", "Informações necessárias", MessageBoxButtons.OK);
            }
            else
            {
                string vquery = "INSERT INTO tb_agendamento (T_SOLICITANTE, T_TIPOSOLICITANTE, T_PERIODO, T_AULA, T_ESTADO, T_DATA, T_TURMA) VALUES ('" + retorno + "', '" + cb_tipo.Text + "', '" + cb_periodo.Text + "', '" + tb_aulas.Text + "','" + Globais.estado + "', '" + mask_data.Text + "', '" + cb_turmas.Text + "')";
                Banco.DML(vquery);
                if (DialogResult.Yes == MessageBox.Show("Salvo! Deseja registrar um novo agendamento?", "Salvo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    tb_soliciante.Clear();
                    tb_aulas.Clear();
                    cb_periodo.Text = "";
                    cb_tipo.Text = "";
                    mask_data.Clear();
                    tb_soliciante.Focus();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void F_Agendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
