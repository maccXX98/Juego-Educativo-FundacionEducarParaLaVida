namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class oracion2 : Form
    {
        public oracion2()
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

        private void controlBoton1()
        {
            if (textBox1.Text == "saludables")
            {
                errorProvider1.SetError(textBox1, "");
            }
            else
            {
                errorProvider1.SetError(textBox1, "Palabra equivocada");
                textBox1.Focus();
            }
        }
        private void controlBoton2()
        {
            if (textBox2.Text == "agricola" || textBox2.Text == "agr�cola")
            {
                errorProvider1.SetError(textBox2, "");
            }
            else
            {
                errorProvider1.SetError(textBox2, "Palabra equivocada");
                textBox2.Focus();
            }

        }
        private void controlBoton3()
        {
            if (textBox3.Text == "necesidades")
            {
                errorProvider1.SetError(textBox3, "");
            }
            else
            {
                errorProvider1.SetError(textBox3, "Palabra equivocada");
                textBox3.Focus();
            }

        }
        private void controlBoton4()
        {
            if (textBox4.Text == "mejorar")
            {
                button1.Enabled = true;
                errorProvider1.SetError(textBox4, "");
            }
            else
            {
                errorProvider1.SetError(textBox4, "Palabra equivocada");
                textBox4.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new sopa2();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;
            controlBoton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 8;
            controlBoton2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 11;
            controlBoton3();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 7;
            controlBoton4();
        }

        private void oracion2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form form = new menuObjetivos();
            form.Show();
            this.Hide();
        }
    }
}