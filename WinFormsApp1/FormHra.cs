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
        string[] slova = { "skola", "program", "csharp", "pocitac", "formular" };
        string slovo;

        char[] hadaneSlovo;
        int zivoty = 10;
        bool konecHry = false;

        public FormHra()
        {
            InitializeComponent();
        }

        private void FormHra_Load(object sender, EventArgs e)
        {

            Random rnd = new Random();
            slovo = slova[rnd.Next(slova.Length)];

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

            if (chyby >= 1)
                g.DrawLine(p, 20, 230, 150, 230);
            if (chyby >= 2)
                g.DrawLine(p, 50, 230, 50, 20);
            if (chyby >= 3)
                g.DrawLine(p, 50, 20, 120, 20);
            if (chyby >= 4)
                g.DrawLine(p, 120, 20, 120, 40);
            if (chyby >= 5)
                g.DrawEllipse(p, 95, 40, 50, 50);
            if (chyby >= 6)
                g.DrawLine(p, 120, 90, 120, 150);
            if (chyby >= 7)
                g.DrawLine(p, 120, 110, 90, 130);
            if (chyby >= 8)
                g.DrawLine(p, 120, 110, 150, 130);
            if (chyby >= 9)
                g.DrawLine(p, 120, 150, 90, 190);
            if (chyby >= 10)
                g.DrawLine(p, 120, 150, 150, 190);
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

            if (konecHry)
                return;

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
                konecHry = true;
            }


            if (zivoty <= 0)
            {
                MessageBox.Show("Prohrál jsi!");
                konecHry = true;
            }

        }


    }
}
