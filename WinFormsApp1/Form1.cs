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
            this.Hide();
            FormHra hra = new FormHra();
            hra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pravidla = "Pravidla šibenice:\n\n" +
                              "- Hráè hádá slovo po písmenech.\n" +
                              "- Každá špatná odpovìï pøidá èást šibenice.\n" +
                              "- Pokud uhodneš celé slovo, vyhráváš.\n" +
                              "- Pokud se šibenice dokonèí, prohráváš.";

            MessageBox.Show(pravidla, "Pravidla");
        }
    }
}
