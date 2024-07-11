using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace uszoverseny_folytatas
{
    public partial class InditoForm : Form
    {
        public List<Versenyzo> versenyzok = new List<Versenyzo>();
        private VersenyForm versenyForm = new VersenyForm();
        private EredmenyForm eredmenyForm = new EredmenyForm();

        public InditoForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "versenyzok.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "eredmenyek.txt";
            VersenyMenuItem.Enabled = false;
            EredmenyMenuItem.Enabled = false;
            MentesMenuItem.Enabled = false;
        }

        private void AdatBevitel()
        {
            DialogResult eredmeny = openFileDialog1.ShowDialog();
            if (eredmeny == DialogResult.OK)
            {
                string fajlNev = openFileDialog1.FileName;
                try
                {
                    AdatBeolvasas(fajlNev);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl beolvasásakor", "Hiba");
                }
            }
        }

        private void AdatBeolvasas(string fajlNev)
        {
            StreamReader olvasoCsatorna = null;
            try
            {
                olvasoCsatorna = new StreamReader(fajlNev);
                while (!olvasoCsatorna.EndOfStream)
                {
                    string adat = olvasoCsatorna.ReadLine();
                    if (adat != "")
                    {
                        Feldolgoz(adat);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a fájl beolvasásánál", "Hiba");
            }
            olvasoCsatorna.Close();
        }

        private void Feldolgoz(string adat)
        {
            string[] adatok = adat.Split(';');
            versenyzok.Add(new Versenyzo(adatok[0], adatok[1], adatok[2]));
        }

        private void MegnyitasMenuItem_Click(object sender, EventArgs e)
        {
            AdatBevitel();
            VersenyMenuItem.Enabled = true;
        }

        private void VersenyMenuItem_Click(object sender, EventArgs e)
        {
            versenyForm.Fogad(versenyzok);
            this.Hide();
            versenyForm.ShowDialog();
            this.Show();
            EredmenyMenuItem.Enabled = true;
            VersenyMenuItem.Enabled = false;
            MentesMenuItem.Enabled = true;
            int tav = versenyForm.Tav;
            string uszasNem = versenyForm.UszasNem;
            eredmenyForm.EredmenyHirdetes(uszasNem, tav, versenyzok);
        }

        private void EredmenyMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eredmenyForm.ShowDialog();
            this.Show();
        }

        private void NevjegyMenuItem_Click(object sender, EventArgs e)
        {
            string keszito = "Szalai Bálint";
            NevjegyForm about = new NevjegyForm(keszito);
            about.ShowDialog();
        }

        private void KilepesMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MentesMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter iroCsatorna = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    iroCsatorna = new StreamWriter(fajlNev);
                    FajlbaIr(iroCsatorna);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl írásakor", "Hiba");
                }
                finally
                {
                    if (iroCsatorna != null)
                    {
                        iroCsatorna.Close();
                    }
                }
            }
        }

        private void FajlbaIr(StreamWriter iroCsatorna)
        {
            foreach (Versenyzo versenyzo in versenyzok)
            {
                iroCsatorna.WriteLine(versenyzo.Fajlba());
            }
        }
    }

    public class Versenyzo
    {
        public string RajtSzam { get; private set; }
        public string Nev { get; private set; }
        public string Orszag { get; private set; }
        public string Zaszlo { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        public static int sorSzam;

        public Versenyzo(string nev, string orszag, string zaszlo)
        {
            this.Nev = nev;
            this.Orszag = orszag;
            this.Zaszlo = zaszlo;
            sorSzam++;
            RajtSzam = (sorSzam < 10) ? ("0" + sorSzam) : sorSzam.ToString();
        }

        public void Versenyez(TimeSpan idoEredmeny)
        {
            this.IdoEredmeny = idoEredmeny;
        }

        public string Fajlba()
        {
            return this.Nev + ";" + this.Orszag + ";" + this.IdoEredmeny;
        }

        public override string ToString()
        {
            return Nev;
        }
    }
}
