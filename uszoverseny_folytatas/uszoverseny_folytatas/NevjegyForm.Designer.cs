namespace uszoverseny_folytatas
{
    partial class NevjegyForm
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
            this.txtNevjegy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNevjegy
            // 
            this.txtNevjegy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNevjegy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNevjegy.HideSelection = false;
            this.txtNevjegy.Location = new System.Drawing.Point(12, 62);
            this.txtNevjegy.Name = "txtNevjegy";
            this.txtNevjegy.ReadOnly = true;
            this.txtNevjegy.Size = new System.Drawing.Size(343, 28);
            this.txtNevjegy.TabIndex = 3;
            this.txtNevjegy.TabStop = false;
            this.txtNevjegy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NevjegyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 160);
            this.Controls.Add(this.txtNevjegy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NevjegyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NevjegyForm";
            this.Load += new System.EventHandler(this.NevjegyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNevjegy;
    }
}