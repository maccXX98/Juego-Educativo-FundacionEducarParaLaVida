namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class letras2 : Form
    {
        public letras2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new oracion2();
            form.Show();
            this.Hide();
        }

        private void letras2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void controlBoton1()
        {
            if (textBox1.Text == "men")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "S�laba equivocada");
                textBox1.Focus();
            }
        }
        private void controlBoton2()
        {
            if (textBox2.Text == "cion" || textBox2.Text == "ci�n")
            {
                errorProvider1.SetError(textBox2, "");
            }
            else
            {
                errorProvider1.SetError(textBox2, "S�laba equivocada");
                textBox2.Focus();
            }

        }
        private void controlBoton3()
        {
            if (textBox3.Text == "pro")
            {
                errorProvider1.SetError(textBox3, "");
            }
            else
            {
                errorProvider1.SetError(textBox3, "S�laba equivocada");
                textBox3.Focus();
            }

        }
        private void controlBoton4()
        {
            if (textBox4.Text == "cul")
            {
                errorProvider1.SetError(textBox4, "");
            }
            else
            {
                errorProvider1.SetError(textBox4, "S�laba equivocada");
                textBox4.Focus();
            }

        }
        private void controlBoton5()
        {
            if (textBox5.Text == "se")
            {
                errorProvider1.SetError(textBox5, "");
            }
            else
            {
                errorProvider1.SetError(textBox5, "S�laba equivocada");
                textBox5.Focus();
            }

        }
        private void controlBoton6()
        {
            if (textBox6.Text == "le")
            {
                errorProvider1.SetError(textBox6, "");
            }
            else
            {
                errorProvider1.SetError(textBox6, "S�laba equivocada");
                textBox6.Focus();
            }

        }
        private void controlBoton7()
        {
            if (textBox7.Text == "cer")
            {
                errorProvider1.SetError(textBox7, "");
            }
            else
            {
                errorProvider1.SetError(textBox7, "S�laba equivocada");
                textBox7.Focus();
            }

        }
        private void controlBoton8()
        {
            if (textBox8.Text == "tar")
            {
                button1.Enabled = true;
                errorProvider1.SetError(textBox8, "");
            }
            else
            {
                errorProvider1.SetError(textBox8, "S�laba equivocada");
                textBox8.Focus();
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;
            controlBoton1();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4;
            controlBoton2();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
            controlBoton3();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
            controlBoton4();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            textBox5.MaxLength = 2;
            controlBoton5();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            textBox6.MaxLength = 2;
            controlBoton6();
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            textBox7.MaxLength = 3;
            controlBoton7();
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
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