using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personbadge_oef
{
    public partial class NieuwPersoon : Form
    {
        public Persoon persoon = new Persoon();
        public NieuwPersoon()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            persoon.Achternaam = txtAchternaam.Text;
            persoon.Voornaam = txtVoornaam.Text;
            persoon.Leeftijd = (int)numLeeftijd.Value;
            DialogResult = DialogResult.OK ;
        }

    }
}
