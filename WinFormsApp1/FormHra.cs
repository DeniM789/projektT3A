using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormHra : Form
    {

        string slovo = "skola";
        char[] hadaneSlovo;
        int zivoty = 10;

        public FormHra()
        {
            InitializeComponent();
        }

        private void FormHra_Load(object sender, EventArgs e)
        {
            hadaneSlovo = new char[slovo.Length];

            for (int i = 0; i < slovo.Length; i++)
                hadaneSlovo[i] = '_';

            AktualizujSlovo();
        }

        private void pnlSibenice_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);

            int chyby = 10 - zivoty;

        }


        void AktualizujSlovo()
        {
            lblSlovo.Text = "";

            for (int i = 0; i < hadaneSlovo.Length; i++)
                lblSlovo.Text += hadaneSlovo[i] + " ";

            lblZivoty.Text = "Životy: " + zivoty;
        }

        private void Pismeno_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Enabled = false;

            char pismeno = char.ToLower(b.Text[0]);
            bool trefa = false;

            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] == pismeno)
                {
                    hadaneSlovo[i] = pismeno;
                    trefa = true;
                }
            }

            if (!trefa)
                zivoty--;

            AktualizujSlovo();
            pnlSibenice.Invalidate();


            bool vyhra = true;

            for (int i = 0; i < hadaneSlovo.Length; i++)
            {
                if (hadaneSlovo[i] == '_')
                    vyhra = false;
            }

            if (vyhra)
            {
                MessageBox.Show("Vyhrál jsi!");
            }


            if (zivoty <= 0)
            {
                MessageBox.Show("Prohrál jsi!");
            }

        }


    }
}
