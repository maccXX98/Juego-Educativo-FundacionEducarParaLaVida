namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class letras15 : Form
    {
        public letras15()
        {
            InitializeComponent();
        }

        private void controlBoton1()
        {
            if (textBox1.Text == "pe")
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
            if (textBox2.Text == "les")
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
            if (textBox3.Text == "o")
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
            if (textBox4.Text == "va")
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
            if (textBox5.Text == "rar")
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
            if (textBox6.Text == "pro")
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
            if (textBox7.Text == "dio")
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
            if (textBox8.Text == "bio")
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
        private void controlBoton9()
        {
            if (textBox9.Text == "ves")
            {
                errorProvider1.SetError(textBox9, "");
            }
            else
            {
                errorProvider1.SetError(textBox9, "S�laba equivocada");
                textBox9.Focus();
            }

        }
        private void controlBoton10()
        {
            if (textBox10.Text == "bien")
            {
                errorProvider1.SetError(textBox10, "");
            }
            else
            {
                errorProvider1.SetError(textBox10, "S�laba equivocada");
                textBox10.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 2;
            controlBoton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
            controlBoton2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 1;
            controlBoton3();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 2;
            controlBoton4();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 3;
            controlBoton5();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
            controlBoton6();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 3;
            controlBoton7();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 3;
            controlBoton8();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.MaxLength = 3;
            controlBoton9();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.MaxLength = 4;
            controlBoton10();
        }

        private void letras4_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new oracion15();
            form.Show();
            this.Hide();
        }
    }
}