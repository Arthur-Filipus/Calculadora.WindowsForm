using System.Globalization;

namespace Calculadora.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal valor1 = 0;
        decimal valor2 = 0;

        string operacao = "";

        public void Teste()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 1;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 2;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 3;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 4;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 5;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 6;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 7;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (lbloperacao.Text == "")
            {
                Resultado.Text += 8;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (lbloperacao.Text == "")
            {
                Resultado.Text += 9;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += 0;
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor2 = decimal.Parse(Resultado2.Text, CultureInfo.InvariantCulture);
                if (operacao == "SOMA")
                {
                    Final.Text = Convert.ToString(valor1 + valor2);

                }
                else if (operacao == "SUBT")
                {
                    Final.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULT")
                {
                    Final.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "DIVI")
                {
                    Final.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {


            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            lbloperacao.Text = "";
            operacao = "SOMA";
            lbloperacao.Text = "+";

        }

        private void button13_Click(object sender, EventArgs e)
        {


            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            lbloperacao.Text = "";
            operacao = "SUBT";
            lbloperacao.Text = "-";

        }

        private void button14_Click(object sender, EventArgs e)
        {


            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            lbloperacao.Text = "";
            operacao = "DIVI";
            lbloperacao.Text = "÷";

        }

        private void button15_Click(object sender, EventArgs e)
        {


            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            lbloperacao.Text = "";
            operacao = "MULT";
            lbloperacao.Text = "x";

        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (Resultado2.Text != "")
            {
                Resultado2.Text = "";
                valor2 = 0;
            }
            else if (lbloperacao.Text != "")
            {
                lbloperacao.Text = "";
            }
            else if (Resultado.Text != "")
            {
                Resultado.Text = "";
                valor1 = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Final.Text = "";
            Resultado2.Text = "";
            lbloperacao.Text = "";
            Resultado.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (lbloperacao.Text == "")
            {
                Resultado.Text += ".";
            }
            else if (lbloperacao.Text != "")
            {
                Resultado2.Text += ".";
            }
        }
    }
}