namespace Calculator_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double h = 0, m = 0, imc = 0;
            h = Convert.ToDouble(textH.Text);
            m = Convert.ToDouble(textM.Text);
            h = h / 100;
            if(h>0 && m>0)
                 imc = m / (h * h);

            
            if (double.TryParse(textH.Text, out h) && h > 0)
            {
               

            }
            else
            { 
                string message = "Introduceti doar valori pozitive pentru campurile inaltime si greutate";
                string title = "Eroare";
                MessageBox.Show(message, title);

                textH.Text = String.Empty;
                textM.Text = String.Empty;
                textS.Text = String.Empty;
                textIMC.Text = String.Empty;
            }
            //try
            //{
            //  h = Convert.ToDouble(textH.Text);
            // m = Convert.ToDouble(textM.Text);
            // }
            /// catch(  Exception eX) { 
            /// MessageBox.Show(eX.Message);
            // }

            textIMC.Text = imc.ToString("0.00");

            if (imc < 18.5)
                textS.Text = "Subponderal";
            else if(18.5<imc && imc<25)
                textS.Text = "Greutate Normala";

            else if(25<imc && imc<30)
                textS.Text = "Exces de greutate";
            
            else
                textS.Text = "Obez";



        }

        private void textIMC_TextChanged(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textH.Text=String.Empty;
            textM.Text=String.Empty;
            textS.Text=String.Empty;
            textIMC.Text=String.Empty;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}