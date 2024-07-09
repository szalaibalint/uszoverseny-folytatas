namespace uszoverseny_folytatas
{
    partial class VersenyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerseny = new System.Windows.Forms.Button();
            this.btnKovetkezo = new System.Windows.Forms.Button();
            this.txtVersenyzo = new System.Windows.Forms.TextBox();
            this.dtpIdoeredmeny = new System.Windows.Forms.DateTimePicker();
            this.cBoxUszasnem = new System.Windows.Forms.ComboBox();
            this.numTav = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTav)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Táv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Versenyző:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Időeredmény:";
            // 
            // btnVerseny
            // 
            this.btnVerseny.Location = new System.Drawing.Point(456, 69);
            this.btnVerseny.Name = "btnVerseny";
            this.btnVerseny.Size = new System.Drawing.Size(75, 23);
            this.btnVerseny.TabIndex = 3;
            this.btnVerseny.Text = "Verseny";
            this.btnVerseny.UseVisualStyleBackColor = true;
            this.btnVerseny.Click += new System.EventHandler(this.btnVerseny_Click);
            // 
            // btnKovetkezo
            // 
            this.btnKovetkezo.Location = new System.Drawing.Point(456, 229);
            this.btnKovetkezo.Name = "btnKovetkezo";
            this.btnKovetkezo.Size = new System.Drawing.Size(75, 23);
            this.btnKovetkezo.TabIndex = 4;
            this.btnKovetkezo.Text = "Következő";
            this.btnKovetkezo.UseVisualStyleBackColor = true;
            this.btnKovetkezo.Click += new System.EventHandler(this.btnKovetkezo_Click);
            // 
            // txtVersenyzo
            // 
            this.txtVersenyzo.Location = new System.Drawing.Point(214, 154);
            this.txtVersenyzo.Name = "txtVersenyzo";
            this.txtVersenyzo.Size = new System.Drawing.Size(100, 20);
            this.txtVersenyzo.TabIndex = 5;
            // 
            // dtpIdoeredmeny
            // 
            this.dtpIdoeredmeny.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIdoeredmeny.Location = new System.Drawing.Point(186, 239);
            this.dtpIdoeredmeny.Name = "dtpIdoeredmeny";
            this.dtpIdoeredmeny.ShowUpDown = true;
            this.dtpIdoeredmeny.Size = new System.Drawing.Size(200, 20);
            this.dtpIdoeredmeny.TabIndex = 6;
            this.dtpIdoeredmeny.Value = new System.DateTime(2024, 7, 9, 0, 0, 0, 0);
            // 
            // cBoxUszasnem
            // 
            this.cBoxUszasnem.FormattingEnabled = true;
            this.cBoxUszasnem.Items.AddRange(new object[] {
            "pillango",
            "valami mas"});
            this.cBoxUszasnem.Location = new System.Drawing.Point(283, 68);
            this.cBoxUszasnem.Name = "cBoxUszasnem";
            this.cBoxUszasnem.Size = new System.Drawing.Size(121, 21);
            this.cBoxUszasnem.TabIndex = 7;
            // 
            // numTav
            // 
            this.numTav.Location = new System.Drawing.Point(163, 72);
            this.numTav.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTav.Name = "numTav";
            this.numTav.Size = new System.Drawing.Size(62, 20);
            this.numTav.TabIndex = 8;
            this.numTav.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "m";
            // 
            // VersenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTav);
            this.Controls.Add(this.cBoxUszasnem);
            this.Controls.Add(this.dtpIdoeredmeny);
            this.Controls.Add(this.txtVersenyzo);
            this.Controls.Add(this.btnKovetkezo);
            this.Controls.Add(this.btnVerseny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VersenyForm";
            this.Text = "VersenyForm";
            ((System.ComponentModel.ISupportInitialize)(this.numTav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerseny;
        private System.Windows.Forms.Button btnKovetkezo;
        private System.Windows.Forms.TextBox txtVersenyzo;
        private System.Windows.Forms.DateTimePicker dtpIdoeredmeny;
        private System.Windows.Forms.ComboBox cBoxUszasnem;
        private System.Windows.Forms.NumericUpDown numTav;
        private System.Windows.Forms.Label label4;
    }
}