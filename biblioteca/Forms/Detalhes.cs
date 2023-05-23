using System;
using System.IO;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Detalhes : Form
    {
        public Detalhes()
        {
            InitializeComponent();
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {
            cb_versoes.Focus();
            StreamReader leitor = new StreamReader(@"C:\Biblioteca Fácil\att.properties");
            string clinha = leitor.ReadLine();
            leitor.ReadLine();
            while (clinha != "--/*-*")
            {
                clinha = leitor.ReadLine();
                cb_versoes.Items.Add(clinha);
            }
            cb_versoes.Items.RemoveAt(cb_versoes.Items.Count - 1);
            cb_versoes.Text = Globais.versao;
            label2.Text += Globais.versao;
            bool stop = false;
            while (stop == false)
            {
                clinha = leitor.ReadLine();
                if (clinha.Contains(Globais.versao.Substring(0, 3)))
                {
                    stop = true;
                }
            }
            while (clinha != "--/")
            {
                clinha = leitor.ReadLine().Trim();
                if (clinha.Contains("--/") == false)
                {
                    textBox1.Text += clinha + "\r\n";
                }
            }

            leitor.Close();
        }

        private void cb_versoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader leitor = new StreamReader(@"C:\Biblioteca Fácil\att.properties");
            string clinha = string.Empty;
            string formação = string.Empty;
            bool stop = false;
            textBox1.Clear();
            int lang = 158;
            int a = cb_versoes.Text.Length;
            int b = (lang - a) / 2;
            for (int i = 0; i < b * 2; i++)
            {
                if (i == b)
                {
                    formação += String.Format(" {0} ", cb_versoes.Text);
                }
                else if (i > b || i < b)
                {
                    formação += "-";
                }
            }
            textBox1.Text += formação + "\r\n";
            while (clinha != "--/*-*")
            {
                clinha = leitor.ReadLine();
            }
            while (clinha.Trim() != cb_versoes.Text)
            {
                clinha = leitor.ReadLine();
            }
            while (stop == false)
            {
                clinha = leitor.ReadLine().Trim();
                if (clinha != "--/")
                {
                    textBox1.Text += clinha + "\r\n";
                }
                else
                {
                    stop = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
