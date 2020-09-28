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
    public partial class EditBadge : Form
    {
        public Persoon selectedPersoon;
        public EditBadge()
        {
            InitializeComponent();
        }

        private void EditBadge_Load(object sender, EventArgs e)
        {
            label1.Text = selectedPersoon.Voornaam + " " + selectedPersoon.Achternaam;
            UpdateLists();
        }

        private void UpdateLists()
        {
            using (oefeningEntities ctx = new oefeningEntities())
            {
                var coupledbadges = ctx.badges.Join(ctx.PersoonBadges,
                    b => b.id,
                    pb => pb.badge,
                    (b,pb) => new {b,pb, Opschrift = b.Opschrift}
                    );

                lbxCurrentBadges.DisplayMember = "Opschrift";
                lbxCurrentBadges.DataSource = coupledbadges.Where(x => x.pb.Persoon == selectedPersoon.id).ToList();
            }
        }
    }
}
