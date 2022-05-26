namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class letras1 : Form
    {
        public letras1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void empezar_Click(object sender, EventArgs e)
        {
            Form form = new oracion1();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void letras1_Load(object sender, EventArgs e)
        {
            empezar.Enabled = false;
        }

        private void controlBoton1()
        {
            if (textBox1.Text == "a")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Letra equivocada");
                empezar.Enabled = false;
                textBox1.Focus();
            }
        }
        private void controlBoton2()
        {
            if (textBox2.Text == "a")
            {
                errorProvider1.SetError(textBox2, "");
            }
            else
            {
                errorProvider1.SetError(textBox2, "Letra equivocada");
                empezar.Enabled = false;
                textBox2.Focus();
            }

        }
        private void controlBoton3()
        {
            if (textBox3.Text == "u")
            {
            errorProvider1.SetError(textBox3, "");
            }
            else
            {
            errorProvider1.SetError(textBox3, "Letra equivocada");
                empezar.Enabled = false;
                textBox3.Focus();
            }

         }
        private void controlBoton4()
        {
            if (textBox4.Text == "l")
            {
                errorProvider1.SetError(textBox4, "");
            }
            else
            {
                errorProvider1.SetError(textBox4, "Letra equivocada");
                empezar.Enabled = false;
                textBox4.Focus();
            }
         
        }
        private void controlBoton5()
        {
            if (textBox5.Text == "i")
            {
                errorProvider1.SetError(textBox5, "");
            }
            else
            {
                errorProvider1.SetError(textBox5, "Letra equivocada");
                empezar.Enabled = false;
                textBox4.Focus();
            }
      
        }
        private void controlBoton6()
        {
            if (textBox6.Text == "a")
            {
                errorProvider1.SetError(textBox6, "");
            }
            else
            {
                errorProvider1.SetError(textBox6, "Letra equivocada");
                empezar.Enabled = false;
                textBox4.Focus();
            }
       
        }
        private void controlBoton7()
        {
            if (textBox7.Text == "o")
            {
                errorProvider1.SetError(textBox7, "");
            }
            else
            {
                errorProvider1.SetError(textBox7, "Letra equivocada");
                empezar.Enabled = false;
                textBox4.Focus();
            }
         
        }
        private void controlBoton8()
        {
            if (textBox8.Text == "r")
            {
                empezar.Enabled = true;
                errorProvider1.SetError(textBox8, "");
            }
            else
            {
                errorProvider1.SetError(textBox8, "Letra equivocada");
                empezar.Enabled = false;
                textBox8.Focus();
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 1;
            controlBoton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 1;
            controlBoton2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 1;
            controlBoton3();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 1;
            controlBoton4();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 1;
            controlBoton5();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 1;
            controlBoton6();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 1;
            controlBoton7();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 1;
            controlBoton8();
        }
    }
}