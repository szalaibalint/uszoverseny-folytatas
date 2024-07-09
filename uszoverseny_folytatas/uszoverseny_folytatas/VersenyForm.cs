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
    public partial class VersenyForm : Form
    {
        public List<Versenyzo> Versenyzok { get; private set; }
        public string UszasNem { get; private set; }
        public int Tav { get; private set; }

        private DateTime alap = new DateTime(2000, 01, 01, 0, 0, 0);
        private int sorSzam;

        public VersenyForm()
        {
            InitializeComponent();
            dtpIdoeredmeny.Value = alap;
            cBoxUszasnem.SelectedIndex = 0;
            btnKovetkezo.Enabled = false;
            btnVerseny.Enabled = true;
        }

        internal void Fogad(List<Versenyzo> versenyzok)
        {
            Versenyzok = versenyzok;
        }

        private void VersenyzoBeallitas()
        {
            dtpIdoeredmeny.Value = alap;
            if (sorSzam < Versenyzok.Count)
            {
                txtVersenyzo.Text = Versenyzok[sorSzam].ToString();
            }
            else
            {
                this.Close();
            }
        }

        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            TimeSpan idoEredmeny = dtpIdoeredmeny.Value - alap;
            Versenyzok[sorSzam].Versenyez(idoEredmeny);
            sorSzam++;
            VersenyzoBeallitas();
        }

        private void btnVerseny_Click(object sender, EventArgs e)
        {
            btnVerseny.Enabled = false;
            btnKovetkezo.Enabled = true;
            UszasNem = cBoxUszasnem.Text;
            Tav = int.Parse(numTav.Value.ToString());
            VersenyzoBeallitas();
        }
    }
}
