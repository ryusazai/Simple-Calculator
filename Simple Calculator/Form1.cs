using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labeltitulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonSomar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = (float.Parse(textBoxNumeroUm.Text) + float.Parse(textBoxNumeroDois.Text)).ToString();
        }

        private void buttonsSubtracao_Click(object sender, EventArgs e)
        {
            labelResultado.Text = (float.Parse(textBoxNumeroUm.Text) - float.Parse(textBoxNumeroDois.Text)).ToString();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            labelResultado.Text = (float.Parse(textBoxNumeroUm.Text) * float.Parse(textBoxNumeroDois.Text)).ToString();
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            labelResultado.Text = (float.Parse(textBoxNumeroUm.Text) / float.Parse(textBoxNumeroDois.Text)).ToString();
        }
    }
}
