namespace DesktopSQL.Pracownik
{
    partial class DodajTowar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UtworyGrid = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CzasTrwania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaTB = new System.Windows.Forms.TextBox();
            this.ComboGatunek = new System.Windows.Forms.ComboBox();
            this.ComboTyp = new System.Windows.Forms.ComboBox();
            this.cenaTB = new System.Windows.Forms.TextBox();
            this.CountNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.DodajBT = new System.Windows.Forms.Button();
            this.AnulujBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UtworyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gatunek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Typ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ilosc na magazynie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Wheat;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nazwa";
            // 
            // UtworyGrid
            // 
            this.UtworyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UtworyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.CzasTrwania});
            this.UtworyGrid.Location = new System.Drawing.Point(15, 167);
            this.UtworyGrid.Name = "UtworyGrid";
            this.UtworyGrid.Size = new System.Drawing.Size(257, 184);
            this.UtworyGrid.TabIndex = 5;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            // 
            // CzasTrwania
            // 
            this.CzasTrwania.HeaderText = "CzasTrwania";
            this.CzasTrwania.Name = "CzasTrwania";
            // 
            // NazwaTB
            // 
            this.NazwaTB.Location = new System.Drawing.Point(107, 6);
            this.NazwaTB.Name = "NazwaTB";
            this.NazwaTB.Size = new System.Drawing.Size(165, 20);
            this.NazwaTB.TabIndex = 6;
            // 
            // ComboGatunek
            // 
            this.ComboGatunek.FormattingEnabled = true;
            this.ComboGatunek.Location = new System.Drawing.Point(107, 32);
            this.ComboGatunek.Name = "ComboGatunek";
            this.ComboGatunek.Size = new System.Drawing.Size(165, 21);
            this.ComboGatunek.TabIndex = 7;
            // 
            // ComboTyp
            // 
            this.ComboTyp.FormattingEnabled = true;
            this.ComboTyp.Location = new System.Drawing.Point(107, 59);
            this.ComboTyp.Name = "ComboTyp";
            this.ComboTyp.Size = new System.Drawing.Size(165, 21);
            this.ComboTyp.TabIndex = 8;
            // 
            // cenaTB
            // 
            this.cenaTB.Location = new System.Drawing.Point(107, 91);
            this.cenaTB.Name = "cenaTB";
            this.cenaTB.Size = new System.Drawing.Size(165, 20);
            this.cenaTB.TabIndex = 9;
            // 
            // CountNum
            // 
            this.CountNum.Location = new System.Drawing.Point(152, 117);
            this.CountNum.Name = "CountNum";
            this.CountNum.Size = new System.Drawing.Size(120, 20);
            this.CountNum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Wheat;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Utwory:";
            // 
            // DodajBT
            // 
            this.DodajBT.Location = new System.Drawing.Point(15, 362);
            this.DodajBT.Name = "DodajBT";
            this.DodajBT.Size = new System.Drawing.Size(75, 23);
            this.DodajBT.TabIndex = 12;
            this.DodajBT.Text = "Dodaj";
            this.DodajBT.UseVisualStyleBackColor = true;
            this.DodajBT.Click += new System.EventHandler(this.DodajBT_Click);
            // 
            // AnulujBT
            // 
            this.AnulujBT.Location = new System.Drawing.Point(203, 362);
            this.AnulujBT.Name = "AnulujBT";
            this.AnulujBT.Size = new System.Drawing.Size(75, 23);
            this.AnulujBT.TabIndex = 13;
            this.AnulujBT.Text = "Anuluj";
            this.AnulujBT.UseVisualStyleBackColor = true;
            this.AnulujBT.Click += new System.EventHandler(this.AnulujBT_Click);
            // 
            // DodajTowar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 397);
            this.Controls.Add(this.AnulujBT);
            this.Controls.Add(this.DodajBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CountNum);
            this.Controls.Add(this.cenaTB);
            this.Controls.Add(this.ComboTyp);
            this.Controls.Add(this.ComboGatunek);
            this.Controls.Add(this.NazwaTB);
            this.Controls.Add(this.UtworyGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(306, 436);
            this.Name = "DodajTowar";
            this.Text = "DodajTowar";
            ((System.ComponentModel.ISupportInitialize)(this.UtworyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView UtworyGrid;
        private System.Windows.Forms.TextBox NazwaTB;
        private System.Windows.Forms.ComboBox ComboGatunek;
        private System.Windows.Forms.ComboBox ComboTyp;
        private System.Windows.Forms.TextBox cenaTB;
        private System.Windows.Forms.NumericUpDown CountNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DodajBT;
        private System.Windows.Forms.Button AnulujBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CzasTrwania;
    }
}