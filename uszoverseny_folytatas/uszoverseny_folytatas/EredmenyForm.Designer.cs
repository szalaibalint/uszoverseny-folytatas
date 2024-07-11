namespace uszoverseny_folytatas
{
    partial class EredmenyForm
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
            this.lblCim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstResztvevok = new System.Windows.Forms.ListBox();
            this.btnOrszagok = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdBtNevsor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoeredmeny = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.ForeColor = System.Drawing.Color.Maroon;
            this.lblCim.Location = new System.Drawing.Point(67, 31);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(352, 24);
            this.lblCim.TabIndex = 0;
            this.lblCim.Text = "300 méteres gyorsúszás eredménye:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(81, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résztvevők";
            // 
            // lstResztvevok
            // 
            this.lstResztvevok.FormattingEnabled = true;
            this.lstResztvevok.Location = new System.Drawing.Point(44, 100);
            this.lstResztvevok.Name = "lstResztvevok";
            this.lstResztvevok.Size = new System.Drawing.Size(170, 238);
            this.lstResztvevok.TabIndex = 2;
            this.lstResztvevok.SelectedIndexChanged += new System.EventHandler(this.lstResztvevok_SelectedIndexChanged);
            // 
            // btnOrszagok
            // 
            this.btnOrszagok.Location = new System.Drawing.Point(65, 357);
            this.btnOrszagok.Name = "btnOrszagok";
            this.btnOrszagok.Size = new System.Drawing.Size(140, 23);
            this.btnOrszagok.TabIndex = 3;
            this.btnOrszagok.Text = "Résztvevő országok";
            this.btnOrszagok.UseVisualStyleBackColor = true;
            this.btnOrszagok.Click += new System.EventHandler(this.btnOrszagok_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(279, 357);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(140, 23);
            this.btnBezar.TabIndex = 4;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdBtNevsor);
            this.groupBox1.Location = new System.Drawing.Point(256, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezési szempont:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Eredmény szerint";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdBtNevsor
            // 
            this.rdBtNevsor.AutoSize = true;
            this.rdBtNevsor.Checked = true;
            this.rdBtNevsor.Location = new System.Drawing.Point(21, 22);
            this.rdBtNevsor.Name = "rdBtNevsor";
            this.rdBtNevsor.Size = new System.Drawing.Size(92, 17);
            this.rdBtNevsor.TabIndex = 0;
            this.rdBtNevsor.TabStop = true;
            this.rdBtNevsor.Text = "Névsor szerint";
            this.rdBtNevsor.UseVisualStyleBackColor = true;
            this.rdBtNevsor.CheckedChanged += new System.EventHandler(this.rdBtNevsor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Időeredmény:";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Location = new System.Drawing.Point(335, 98);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.ReadOnly = true;
            this.txtRajtszam.Size = new System.Drawing.Size(100, 20);
            this.txtRajtszam.TabIndex = 9;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(335, 132);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.ReadOnly = true;
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 10;
            // 
            // txtIdoeredmeny
            // 
            this.txtIdoeredmeny.Location = new System.Drawing.Point(335, 167);
            this.txtIdoeredmeny.Name = "txtIdoeredmeny";
            this.txtIdoeredmeny.ReadOnly = true;
            this.txtIdoeredmeny.Size = new System.Drawing.Size(100, 20);
            this.txtIdoeredmeny.TabIndex = 11;
            // 
            // EredmenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(482, 404);
            this.Controls.Add(this.txtIdoeredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnOrszagok);
            this.Controls.Add(this.lstResztvevok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EredmenyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eredmények";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstResztvevok;
        private System.Windows.Forms.Button btnOrszagok;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdBtNevsor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoeredmeny;
    }
}