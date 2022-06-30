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
            this.Hide();
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
            if (textBox1.Text == "dar")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox1.Focus();
            }
        }
        private void controlBoton2()
        {
            if (textBox2.Text == "par")
            {
                errorProvider1.SetError(textBox2, "");
            }
            else
            {
                errorProvider1.SetError(textBox2, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox2.Focus();
            }

        }
        private void controlBoton3()
        {
            if (textBox3.Text == "qui")
            {
            errorProvider1.SetError(textBox3, "");
            }
            else
            {
            errorProvider1.SetError(textBox3, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox3.Focus();
            }

         }
        private void controlBoton4()
        {
            if (textBox4.Text == "gual")
            {
                errorProvider1.SetError(textBox4, "");
            }
            else
            {
                errorProvider1.SetError(textBox4, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox4.Focus();
            }
         
        }
        private void controlBoton5()
        {
            if (textBox5.Text == "ci")
            {
                errorProvider1.SetError(textBox5, "");
            }
            else
            {
                errorProvider1.SetError(textBox5, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox5.Focus();
            }
      
        }
        private void controlBoton6()
        {
            if (textBox6.Text == "fa")
            {
                errorProvider1.SetError(textBox6, "");
            }
            else
            {
                errorProvider1.SetError(textBox6, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox6.Focus();
            }
       
        }
        private void controlBoton7()
        {
            if (textBox7.Text == "yo")
            {
                errorProvider1.SetError(textBox7, "");
            }
            else
            {
                errorProvider1.SetError(textBox7, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox7.Focus();
            }
         
        }
        private void controlBoton8()
        {
            if (textBox8.Text == "rar")
            {
                empezar.Enabled = true;
                errorProvider1.SetError(textBox8, "");
            }
            else
            {
                errorProvider1.SetError(textBox8, "Sílaba equivocada");
                empezar.Enabled = false;
                textBox8.Focus();
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;
            controlBoton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
            controlBoton2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
            controlBoton3();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 4;
            controlBoton4();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 2;
            controlBoton5();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 2;
            controlBoton6();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 2;
            controlBoton7();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 3;
            controlBoton8();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form form = new menuObjetivos();
            form.Show();
            this.Hide();
        }
    }
}