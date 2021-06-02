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

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtValor1.Text);
            num2 = Convert.ToDouble(txtValor2.Text);
            resultado = num1 + num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtValor1.Text);
            num2 = Convert.ToDouble(txtValor2.Text);
            result = num1 - num2;
            txtResultado.Text = result.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtValor1.Text);
            num2 = Convert.ToDouble(txtValor2.Text);
            result = num1 * num2;
            txtResultado.Text = result.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtValor1.Text);
            num2 = Convert.ToDouble(txtValor2.Text);
            result = num1 / num2;
            txtResultado.Text = result.ToString();
        }
    }
}
