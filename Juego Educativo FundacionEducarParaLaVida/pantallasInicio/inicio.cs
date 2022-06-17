namespace Juego_Educativo_FundacionEducarParaLaVida
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void empezar_Click(object sender, EventArgs e)
        {
            Form form = new menuObjetivos();
            form.Show();
            this.Hide();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}