namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class oracion1 : Form
    {
        public oracion1()
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void union1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new sopa1();
            form.Show();
        }

        private void controlBoton1()
        {
            if (textBox1.Text == "pobreza")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Palabra equivocada");
                button1.Enabled = false;
                textBox1.Focus();
            }
        }
        private void controlBoton2()
        {
            if (textBox2.Text == "alimentacion" || textBox2.Text == "alimentación")
            {
                errorProvider1.SetError(textBox2, "");
            }
            else
            {
                errorProvider1.SetError(textBox2, "Palabra equivocada");
                button1.Enabled = false;
                textBox2.Focus();
            }

        }
        private void controlBoton3()
        {
            if (textBox3.Text == "sana")
            {
                errorProvider1.SetError(textBox3, "");
            }
            else
            {
                errorProvider1.SetError(textBox3, "Palabra equivocada");
                button1.Enabled = false;
                textBox3.Focus();
            }

        }
        private void controlBoton4()
        {
            if (textBox4.Text == "bienestar")
            {
                errorProvider1.SetError(textBox4, "");
            }
            else
            {
                errorProvider1.SetError(textBox4, "Palabra equivocada");
                button1.Enabled = false;
                textBox4.Focus();
            }

        }
        private void controlBoton5()
        {
            if (textBox5.Text == "educacion" || textBox5.Text == "educación")
            {
                button1.Enabled = true;
                errorProvider1.SetError(textBox5, "");
            }
            else
            {
                errorProvider1.SetError(textBox5, "Palabra equivocada");
                button1.Enabled = false;
                textBox5.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 7;
            controlBoton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 12;
            controlBoton2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 4;
            controlBoton3();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.MaxLength = 9;
            controlBoton4();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            textBox5.MaxLength = 9;
            controlBoton5();
        }

        private void oracion1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}