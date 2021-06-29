using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatro_Mr.Klenin
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        
        private double resultado;
        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //division
            if (tbDisplay.Text == "")
            {

                tbDisplay.Text = "0";


            }
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero zero 
            tbDisplay.Text =tbDisplay.Text + "0";
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero1
            if (tbDisplay.Text == "0")
            {
                
                tbDisplay.Clear();
                
                
            }
            

            tbDisplay.Text = tbDisplay.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero2
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero3
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero4
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero5
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero6
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero7
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero8
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero9
            if (tbDisplay.Text == "0")
            {

                tbDisplay.Clear();


            }
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //+
            if (tbDisplay.Text == "")
            {

                tbDisplay.Text = "0";


            }
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text );
            tbDisplay.Text = "";
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            //-
            if (tbDisplay.Text == "")
            {

                tbDisplay.Text = "0";


            }
            if (tbDisplay.Text != "")
            {

                tbDisplay.Text = "0";


            }
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //multiplicacion
            if (tbDisplay.Text == "")
            {

                tbDisplay.Text = "0";


            }
            
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //boton limpiar

            tbDisplay.Clear();
            tbDisplay.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //igual
            //string val1="205";
            //string val2="55";
            //int resultado = 0;
            //int valor1 = 0;
            //int valor2 = 0;
            //valor1 = Convert.ToInt32(val1);
            //valor2 = Convert.ToInt32(val1);
            //resultado = valor1 + valor2;
            //tbDisplay.Text = resultado.ToString();
            if (tbDisplay.Text == "")
            {

                tbDisplay.Text = valor1.ToString();


            }
            valor2 = Convert.ToDouble(tbDisplay.Text) ;
            
            
            resultado= Convert.ToDouble(tbDisplay.Text);
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;

                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
                

            }
            tbDisplay.Text = resultado.ToString();

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text+".";
        }
    }
}
