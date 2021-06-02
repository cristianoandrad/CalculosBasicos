using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculosBasicos
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResultado.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
