namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHra hra = new FormHra();
            this.Hide();
            hra.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormPravidla pravidla = new FormPravidla();
            this.Hide();
            pravidla.ShowDialog();
            this.Show();

        }
    }
}
