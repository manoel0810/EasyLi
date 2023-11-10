using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_InformacoesDoProduto : Form
    {
        public F_InformacoesDoProduto()
        {
            InitializeComponent();
        }

        private void F_InformacoesDoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
