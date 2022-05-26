namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class menuObjetivos : Form
    {
        public menuObjetivos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void empezar_Click(object sender, EventArgs e)
        {

        }

        internal static void ActiveForm()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonIndustrial_Click(object sender, EventArgs e)
        {

        }

        private void button6Agua_Click(object sender, EventArgs e)
        {

        }

        private void button1Pobreza_Click(object sender, EventArgs e)
        {
            Form form = new letras1();
            form.Show();
        }

        private void button2Hambre_Click(object sender, EventArgs e)
        {
            Form form = new letras2();
            form.Show();
        }

        private void button18Final_Click(object sender, EventArgs e)
        {
            Form form = new seleccionarDificultad();
            form.Show();
        }
    }
}