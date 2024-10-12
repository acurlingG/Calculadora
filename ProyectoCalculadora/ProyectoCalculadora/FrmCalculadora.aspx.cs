using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Diagnostics;

namespace ProyectoCalculadora
{
    public partial class FrmCalculadora : System.Web.UI.Page
    {
        //Vriables
        //Suma
        public static string su;
        public static int suma;

        //Resta
        public static string res;
        public static int restar;

        //Multiplicación
        public static string mul;
        public static int multiplicar;

        //División
        public static string div;
        public static int division;

        //Igual
        public static string igu;
        public static int igual;

        //Total
        public static int total;
     


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = string.Empty;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '1';
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '2';
            }
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '3';
            }
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '4';
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '5';
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '6';
            }
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '7';
            }
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '8';
            }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {

            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '9';
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '0';
            }
        }
        //***************************************************************
        protected void btnComa_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += ',';
            }
        }
        protected void btnElev_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length < 9)
            {
                txtPrincipal.Text += '^';
            }
        }
        protected void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text != string.Empty)
            {
                double valorIngresado = double.Parse(txtPrincipal.Text);
                double resultado = Math.Sqrt(valorIngresado);
                txtPrincipal.Text = resultado.ToString();
            }
        }
        protected void btnCuadrado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrincipal.Text))
            {
                double valorIngresado = double.Parse(txtPrincipal.Text);
                double resultado = valorIngresado * valorIngresado;
                txtPrincipal.Text = resultado.ToString();
            }
        }
        protected void btnLog_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text != string.Empty)
            {
                double valorIngresado = double.Parse(txtPrincipal.Text);
                double resultado = Math.Log10(valorIngresado); // Logaritmo en base 10
                txtPrincipal.Text = resultado.ToString();
            }
        }
        protected void btnPotencia_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text != string.Empty)
            {
                // Obtiene el contenido del cuadro de texto
                string input = txtPrincipal.Text;

                // Busca el carácter '^' para separar la base y el exponente
                int exponentIndex = input.IndexOf('^');

                if (exponentIndex != -1)
                {
                    string basePart = input.Substring(0, exponentIndex).Trim();
                    string exponentPart = input.Substring(exponentIndex + 1).Trim();

                    if (double.TryParse(basePart, out double baseNumber) && double.TryParse(exponentPart, out double exponent))
                    {
                        double result = Math.Pow(baseNumber, exponent);
                        txtPrincipal.Text = result.ToString();
                    }
                    else
                    {
                        // Maneja el caso en el que la entrada no sea válida
                        txtPrincipal.Text = "Entrada no válida. Ingrese la base y el exponente separados por '^'.";
                    }
                }
                else
                {
                    // Maneja el caso en el que no se haya ingresado una base y un exponente válidos
                    txtPrincipal.Text = "Entrada no válida. Ingrese la base y el exponente separados por '^'.";
                }
            }

        }
      
        //***************************************************************
        protected void btnMas_Click(object sender, EventArgs e)
        {
            su = this.txtPrincipal.Text;
            suma = Convert.ToInt32(su);
            this.txtPrincipal.Text = "";
        }

        //***************************************************************
        protected void btnMenos_Click(object sender, EventArgs e)
        {
            res = this.txtPrincipal.Text;
            restar = Convert.ToInt32(res);
            this.txtPrincipal.Text = "";
        }

        //***************************************************************
        protected void btnPor_Click(object sender, EventArgs e)
        {
            mul = this.txtPrincipal.Text;
            multiplicar = Convert.ToInt32(mul);
            this.txtPrincipal.Text = "";
        }
        //***************************************************************
        protected void btnDiv_Click(object sender, EventArgs e)
        {
            div = this.txtPrincipal.Text;
            division = Convert.ToInt32(div);
            this.txtPrincipal  .Text = "";
        }
        //***************************************************************

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Text.Length > 0)
            {
                txtPrincipal.Text = txtPrincipal.Text.Remove(txtPrincipal.Text.Length - 1);
            }
        }
        //***************************************************************
        protected void btnIgual_Click(object sender, EventArgs e)
        {
            igu = this.txtPrincipal.Text;
            igual = Convert.ToInt32(igu);
            this.txtPrincipal.Text = "";
            if (suma > 0)
            {
                total = suma + igual;
                this.txtPrincipal.Text = Convert.ToString(total);

                borra();
            }
            else
            if (restar > 0)
            {
                total = restar - igual;
                this.txtPrincipal.Text = Convert.ToString(total);

                borra();
            }
            else
            if (multiplicar > 0)
            {
                total = multiplicar * igual;
                this.txtPrincipal.Text = Convert.ToString(total);

                borra();
            }
            else
            if (division > 0)
            {
                total = division / igual;
                this.txtPrincipal .Text = Convert.ToString(total);

                borra();
            }
        }

        //***************************************************************

        public void borra()
        {
            //Suma
            su = null;
            suma = 0;

            //Resta
            res = null;
            restar = 0;

            //Multiplicación
            mul = null;
            multiplicar = 0;

            //División
            div = null;
            division = 0;

            //Igual
            igu = null;
            igual = 0;

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrincipal.Text, out double x))
            {
                double result = Math.Pow(10, x);
                txtPrincipal.Text = result.ToString();
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrincipal.Text))
            {
                int valorIngresado = int.Parse(txtPrincipal.Text);
                int resultado = CalcularFactorial(valorIngresado);
                txtPrincipal.Text = resultado.ToString();
            }
        }

        private int CalcularFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalcularFactorial(n - 1);
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrincipal.Text))
            {
                double valorActual = double.Parse(txtPrincipal.Text);
                valorActual = -valorActual;
                txtPrincipal.Text = valorActual.ToString();
            }
        }
    }
    }



    

