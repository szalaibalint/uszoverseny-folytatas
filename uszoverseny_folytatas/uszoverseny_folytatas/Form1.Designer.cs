﻿namespace uszoverseny_folytatas
{
    partial class InditoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MegnyitasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MentesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersenyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EredmenyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NevjegyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.VersenyMenuItem,
            this.EredmenyMenuItem,
            this.NevjegyMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MegnyitasMenuItem,
            this.MentesMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // MegnyitasMenuItem
            // 
            this.MegnyitasMenuItem.Name = "MegnyitasMenuItem";
            this.MegnyitasMenuItem.Size = new System.Drawing.Size(129, 22);
            this.MegnyitasMenuItem.Text = "Megnyitás";
            this.MegnyitasMenuItem.Click += new System.EventHandler(this.MegnyitasMenuItem_Click);
            // 
            // MentesMenuItem
            // 
            this.MentesMenuItem.Name = "MentesMenuItem";
            this.MentesMenuItem.Size = new System.Drawing.Size(129, 22);
            this.MentesMenuItem.Text = "Mentés";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // VersenyMenuItem
            // 
            this.VersenyMenuItem.Name = "VersenyMenuItem";
            this.VersenyMenuItem.Size = new System.Drawing.Size(59, 20);
            this.VersenyMenuItem.Text = "Verseny";
            this.VersenyMenuItem.Click += new System.EventHandler(this.VersenyMenuItem_Click);
            // 
            // EredmenyMenuItem
            // 
            this.EredmenyMenuItem.Name = "EredmenyMenuItem";
            this.EredmenyMenuItem.Size = new System.Drawing.Size(72, 20);
            this.EredmenyMenuItem.Text = "Eredmény";
            this.EredmenyMenuItem.Click += new System.EventHandler(this.EredmenyMenuItem_Click);
            // 
            // NevjegyMenuItem
            // 
            this.NevjegyMenuItem.Name = "NevjegyMenuItem";
            this.NevjegyMenuItem.Size = new System.Drawing.Size(62, 20);
            this.NevjegyMenuItem.Text = "Névjegy";
            this.NevjegyMenuItem.Click += new System.EventHandler(this.NevjegyMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::uszoverseny_folytatas.Properties.Resources.uszas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "InditoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Úszóverseny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MegnyitasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MentesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersenyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EredmenyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NevjegyMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

