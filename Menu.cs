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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (oefeningEntities ctx = new oefeningEntities())
            {
                var joinQuery = ctx.Persoons
                    .Join(ctx.PersoonBadges,
                        p => p.id,
                        pb => pb.id,
                        (p, pb) => new { p, pb })
                    .Join(ctx.badges,
                        pb2 => pb2.pb.id,
                        b => b.id,
                        (pb2, b) => new { pb2, b });
            }

            LaadListbox();


        }

        private void LaadListbox()
        {
            using (oefeningEntities ctx = new oefeningEntities())
            {
                var query = ctx.Persoons.Select(p => new { p, naam = p.Voornaam + " " + p.Achternaam }).ToList();
                lbPersonen.DataSource = query;
                lbPersonen.DisplayMember = "naam";
                lbPersonen.ValueMember = "p";
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            NieuwPersoon np = new NieuwPersoon();
            if (np.ShowDialog() == DialogResult.OK)
            {
                using (oefeningEntities ctx = new oefeningEntities())
                {
                    ctx.Persoons.Add(np.persoon);
                    ctx.SaveChanges();
                    LaadListbox();
                }
            }
        }

        private void lbPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = lbPersonen.SelectedValue.ToString();
        }

        private void btnEditBadge_Click(object sender, EventArgs e)
        {
            EditBadge eb = new EditBadge();

            eb.selectedPersoon = (Persoon)lbPersonen.SelectedValue;

            if (eb.ShowDialog() == DialogResult.OK)
            {
                LaadListbox();
            }

        }
    }
}
