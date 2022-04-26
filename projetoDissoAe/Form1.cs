using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDissoAe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txtBase.Text);
            double v2 = Convert.ToDouble(txtAltura.Text);

            double resultado = v1 * v2 / 2;

            Resu.Text = Convert.ToString(resultado);
        }
    }
}
