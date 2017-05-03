namespace DesktopSQL.Pracownik
{
    partial class DodajWykonawce
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
            this.ImieTB = new System.Windows.Forms.TextBox();
            this.NazwiskoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImieTB
            // 
            this.ImieTB.Location = new System.Drawing.Point(78, 12);
            this.ImieTB.Name = "ImieTB";
            this.ImieTB.Size = new System.Drawing.Size(134, 20);
            this.ImieTB.TabIndex = 1;
            // 
            // NazwiskoTB
            // 
            this.NazwiskoTB.Location = new System.Drawing.Point(78, 38);
            this.NazwiskoTB.Name = "NazwiskoTB";
            this.NazwiskoTB.Size = new System.Drawing.Size(134, 20);
            this.NazwiskoTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(13, 91);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 5;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(137, 91);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 6;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // DodajWykonawce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 126);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazwiskoTB);
            this.Controls.Add(this.ImieTB);
            this.Name = "DodajWykonawce";
            this.Text = "DodajWykonawce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImieTB;
        private System.Windows.Forms.TextBox NazwiskoTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Anuluj;
    }
}