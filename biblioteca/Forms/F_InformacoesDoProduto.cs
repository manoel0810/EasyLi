using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_InformacoesDoProduto : Form
    {
        public F_InformacoesDoProduto()
        {
            InitializeComponent();
        }

        private void lb_detalhes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Detalhes detalhes = new Detalhes();
            detalhes.ShowDialog();
        }
    }
}
