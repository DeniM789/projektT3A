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
    public partial class FormPravidla : Form
    {
        public FormPravidla()
        {
            InitializeComponent();

            lblPravidla.Text =
                        "Pravidla šibenice:\r\n\r\n" +
                        "• Hráč hádá slovo po písmenech.\r\n" +
                        "• Každá špatná odpověď přidá část šibenice.\r\n" +
                        "• Pokud uhodneš celé slovo, vyhráváš.\r\n" +
                        "• Pokud se šibenice dokončí, prohráváš.";


        }

        private void btnZpet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
