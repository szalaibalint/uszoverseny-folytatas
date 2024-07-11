using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszoverseny_folytatas
{
    public partial class EredmenyForm : Form
    {
        private List<Versenyzo> versenyzok;

        public EredmenyForm()
        {
            InitializeComponent();
        }

        public void EredmenyHirdetes(string uszasNem, int tav, List<Versenyzo> versenyzok)
        {
            lblCim.Text = tav + " méteres " + uszasNem + " eredménye: ";
            this.versenyzok = versenyzok;
            foreach (Versenyzo versenyzo in versenyzok)
            {
                lstResztvevok.Items.Add(versenyzo);
            }
        }

        private void lstResztvevok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstResztvevok.SelectedIndex != -1)
                {
                    Versenyzo versenyzo = (Versenyzo)lstResztvevok.SelectedItem;
                    txtRajtszam.Text = versenyzo.RajtSzam;
                    txtOrszag.Text = versenyzo.Orszag;
                    txtIdoeredmeny.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás választás", "Hiba");
            }
        }

        private void rdBtNevsor_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdBtNevsor.Checked)
            {
                lstResztvevok.Sorted = false;
                lstResztvevok.Items.Clear();
                Versenyzo temp;
                for (int i = 0; i < versenyzok.Count - 1; i++)
                {
                    for (int j = i + 1; j < versenyzok.Count; j++)
                    {
                        if (versenyzok[i].IdoEredmeny > versenyzok[j].IdoEredmeny)
                        {
                            temp = versenyzok[i];
                            versenyzok[i] = versenyzok[j];
                            versenyzok[j] = temp;
                        }
                    }
                }
                foreach (Versenyzo versenyzo in versenyzok)
                {
                    lstResztvevok.Items.Add(versenyzo);
                }
            }
            else
            {
                lstResztvevok.Sorted = true;
            }
        }

        private void btnOrszagok_Click(object sender, EventArgs e)
        {
            ZaszloForm zaszloForm = new ZaszloForm();
            zaszloForm.Fogad(versenyzok);
            zaszloForm.ShowDialog();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
