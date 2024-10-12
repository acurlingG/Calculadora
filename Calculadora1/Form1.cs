namespace Calculadora1
{
    public partial class Form1 : Form
    {

        static int num1 = 0, num2 = 0;
        static bool suma = false;
        static string valor2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {

            if (suma == true)
            {
                valor2 = valor2 + "1";
            }

            lresultado.Text = lresultado.Text + "1";

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (suma == true)
            {
                valor2 = valor2 + "2";
            }

            lresultado.Text = lresultado.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (suma == true)
            {
                valor2 = valor2 + "3";
            }

            lresultado.Text = lresultado.Text + "3";

        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(lresultado.Text);
            lresultado.Text = lresultado.Text + "+";
            suma = true;

        }

        private void bigual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(valor2);
            int total = num1 + num2;
            lresultado.Text = lresultado.Text + "= " + total.ToString();
        }

        private void bc_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 =0;
            valor2 = string.Empty;
            lresultado.Text = string.Empty;
            suma =false;
            
        }
    }
}
