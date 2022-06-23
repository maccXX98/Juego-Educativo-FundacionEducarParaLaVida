namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class letras4 : Form
    {
        public letras4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void empezar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void controlBoton1()
        {
            if (textBox1.Text == "cion" || textBox1.Text == "ción")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Sílaba equivocada");
                textBox1.Focus();
            }
        }
        private void controlBoton2()
        {
            if (textBox2.Text == "li")
            {
                errorProvider1.SetError(textBox2, "");
            }
            else
            {
                errorProvider1.SetError(textBox2, "Sílaba equivocada");
                textBox2.Focus();
            }

        }
        private void controlBoton3()
        {
            if (textBox3.Text == "pren")
            {
                errorProvider1.SetError(textBox3, "");
            }
            else
            {
                errorProvider1.SetError(textBox3, "Sílaba equivocada");
                textBox3.Focus();
            }

        }
        private void controlBoton4()
        {
            if (textBox4.Text == "bla")
            {
                errorProvider1.SetError(textBox4, "");
            }
            else
            {
                errorProvider1.SetError(textBox4, "Sílaba equivocada");
                textBox4.Focus();
            }

        }
        private void controlBoton5()
        {
            if (textBox5.Text == "cue")
            {
                errorProvider1.SetError(textBox5, "");
            }
            else
            {
                errorProvider1.SetError(textBox5, "Sílaba equivocada");
                textBox5.Focus();
            }

        }
        private void controlBoton6()
        {
            if (textBox6.Text == "no")
            {
                errorProvider1.SetError(textBox6, "");
            }
            else
            {
                errorProvider1.SetError(textBox6, "Sílaba equivocada");
                textBox6.Focus();
            }

        }
        private void controlBoton7()
        {
            if (textBox7.Text == "lud")
            {
                errorProvider1.SetError(textBox7, "");
            }
            else
            {
                errorProvider1.SetError(textBox7, "Sílaba equivocada");
                textBox7.Focus();
            }

        }
        private void controlBoton8()
        {
            if (textBox8.Text == "zo")
            {
                button1.Enabled = true;
                errorProvider1.SetError(textBox8, "");
            }
            else
            {
                errorProvider1.SetError(textBox8, "Sílaba equivocada");
                textBox8.Focus();
            }

        }
        private void controlBoton9()
        {
            if (textBox9.Text == "tal")
            {
                errorProvider1.SetError(textBox9, "");
            }
            else
            {
                errorProvider1.SetError(textBox9, "Sílaba equivocada");
                textBox9.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
            controlBoton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 2;
            controlBoton2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 4;
            controlBoton3();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
            controlBoton4();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 3;
            controlBoton5();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 2;
            controlBoton6();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 3;
            controlBoton7();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 2;
            controlBoton8();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.MaxLength = 3;
            controlBoton9();
        }

        private void letras4_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new oracion4();
            form.Show();
            this.Hide();
        }
    }
}