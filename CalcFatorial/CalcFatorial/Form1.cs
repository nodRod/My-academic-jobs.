using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcFatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int recebeN = int.Parse(txtNumero.Text);
            int resultado = calcFat(recebeN);

            lbResultado.Text = "O fatorial de " + recebeN + " é " + resultado;
        }
        
        public int calcFat(int recebeN)
        
        {
           int resultado = 1;
           for (int i = 1; i <= recebeN; i++)
			{
			   resultado = resultado * i;
			}
            return resultado;
        }

    }
}
