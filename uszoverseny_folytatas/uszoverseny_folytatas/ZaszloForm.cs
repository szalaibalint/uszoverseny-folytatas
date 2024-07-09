﻿using System;
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
    public partial class ZaszloForm : Form
    {
        public ZaszloForm()
        {
            InitializeComponent();
        }

        private int bal = 20, fent = 20, tavX = 120, tavY = 80,
            zaszloX = 75, zaszloY = 50, labelY = 15, oszlopSzam = 3;

        private void ZaszloForm_Load(object sender, EventArgs e)
        {
            ZaszloKigyujt();
            ZaszloFelrak();
        }

        private List<Versenyzo> versenyzok;
        private List<string> zaszlok = new List<string>();
        private List<string> feliratok = new List<string>();

        internal void Fogad(List<Versenyzo> versenyzok)
        {
            this.versenyzok = versenyzok;
        }

        private void ZaszloKigyujt()
        {
            foreach (var versenyzo in versenyzok)
            {
                if (!zaszlok.Contains(versenyzo.Zaszlo))
                {
                    zaszlok.Add(versenyzo.Zaszlo);
                    feliratok.Add(versenyzo.Orszag);
                }
            }
        }

        private void ZaszloFelrak()
        {
            PictureBox pctBox;
            Label felirat;
            int sor = 0, oszlop = 0;

            for (int i = 0; i < zaszlok.Count; i++)
            {
                pctBox = new PictureBox();
                pctBox.Location = new Point(bal + oszlop * (tavX), fent + sor * (tavY));
                pctBox.Size = new Size(zaszloX, zaszloY);
                pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pctBox.Image = Image.FromFile(zaszlok[i] + ".png");

                felirat = new Label();
                felirat.Location = new Point(pctBox.Location.X, pctBox.Location.Y + zaszloY);
                felirat.Size = new Size(zaszloX, labelY);
                felirat.TextAlign = ContentAlignment.MiddleCenter;
                felirat.Text = feliratok[i];
                pnlKozponti.Controls.Add(pctBox);
                pnlKozponti.Controls.Add(felirat);
                oszlop++;
                if (oszlop == oszlopSzam)
                {
                    oszlop = 0;
                    sor++;
                }
            }
        }
    }
}
