namespace SpelovanjeSlova
{
    partial class SpelovanjeForma
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
            this.PoljeZaUnosTeksta = new System.Windows.Forms.TextBox();
            this.Speluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PoljeZaUnosTeksta
            // 
            this.PoljeZaUnosTeksta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoljeZaUnosTeksta.Location = new System.Drawing.Point(12, 41);
            this.PoljeZaUnosTeksta.Multiline = true;
            this.PoljeZaUnosTeksta.Name = "PoljeZaUnosTeksta";
            this.PoljeZaUnosTeksta.Size = new System.Drawing.Size(610, 300);
            this.PoljeZaUnosTeksta.TabIndex = 0;
            // 
            // Speluj
            // 
            this.Speluj.Location = new System.Drawing.Point(12, 12);
            this.Speluj.Name = "Speluj";
            this.Speluj.Size = new System.Drawing.Size(75, 23);
            this.Speluj.TabIndex = 1;
            this.Speluj.Text = "Speluj";
            this.Speluj.UseVisualStyleBackColor = true;
            this.Speluj.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpelovanjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 353);
            this.Controls.Add(this.Speluj);
            this.Controls.Add(this.PoljeZaUnosTeksta);
            this.Name = "SpelovanjeForma";
            this.Text = "Spelovanje slova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoljeZaUnosTeksta;
        private System.Windows.Forms.Button Speluj;
    }
}

