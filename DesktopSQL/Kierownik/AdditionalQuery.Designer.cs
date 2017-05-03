namespace DesktopSQL.Kierownik
{
    partial class AdditionalQuery
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
            this.ExitTB = new System.Windows.Forms.Button();
            this.LogoutTB = new System.Windows.Forms.Button();
            this.Zad1Bt = new System.Windows.Forms.Button();
            this.zad1Date = new System.Windows.Forms.DateTimePicker();
            this.zad1bCena = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.zad2bt = new System.Windows.Forms.Button();
            this.zad2dateA = new System.Windows.Forms.DateTimePicker();
            this.zad2dateB = new System.Windows.Forms.DateTimePicker();
            this.zad3bt = new System.Windows.Forms.Button();
            this.zad4bt = new System.Windows.Forms.Button();
            this.zad5bt = new System.Windows.Forms.Button();
            this.zad5Type = new System.Windows.Forms.ComboBox();
            this.Zad5DateA = new System.Windows.Forms.DateTimePicker();
            this.zad6bt = new System.Windows.Forms.Button();
            this.zad7bt = new System.Windows.Forms.Button();
            this.zad8bt = new System.Windows.Forms.Button();
            this.zad8DateA = new System.Windows.Forms.DateTimePicker();
            this.zad9bt = new System.Windows.Forms.Button();
            this.zad9DateA = new System.Windows.Forms.DateTimePicker();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.zad9DateB = new System.Windows.Forms.DateTimePicker();
            this.zad1b = new System.Windows.Forms.Button();
            this.zad1bData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.zad1bCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitTB
            // 
            this.ExitTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitTB.Location = new System.Drawing.Point(882, 12);
            this.ExitTB.Name = "ExitTB";
            this.ExitTB.Size = new System.Drawing.Size(75, 23);
            this.ExitTB.TabIndex = 29;
            this.ExitTB.Text = "Zamknij";
            this.ExitTB.UseVisualStyleBackColor = true;
            this.ExitTB.Click += new System.EventHandler(this.Close_Click);
            // 
            // LogoutTB
            // 
            this.LogoutTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutTB.Location = new System.Drawing.Point(788, 12);
            this.LogoutTB.Name = "LogoutTB";
            this.LogoutTB.Size = new System.Drawing.Size(88, 23);
            this.LogoutTB.TabIndex = 28;
            this.LogoutTB.Text = "Zamknij Okno";
            this.LogoutTB.UseVisualStyleBackColor = true;
            this.LogoutTB.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Zad1Bt
            // 
            this.Zad1Bt.Location = new System.Drawing.Point(12, 128);
            this.Zad1Bt.Name = "Zad1Bt";
            this.Zad1Bt.Size = new System.Drawing.Size(179, 23);
            this.Zad1Bt.TabIndex = 30;
            this.Zad1Bt.Text = "Lista klientów";
            this.Zad1Bt.UseVisualStyleBackColor = true;
            this.Zad1Bt.Click += new System.EventHandler(this.Zad1Bt_Click);
            // 
            // zad1Date
            // 
            this.zad1Date.Location = new System.Drawing.Point(197, 128);
            this.zad1Date.Name = "zad1Date";
            this.zad1Date.Size = new System.Drawing.Size(198, 20);
            this.zad1Date.TabIndex = 31;
            this.zad1Date.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // zad1bCena
            // 
            this.zad1bCena.DecimalPlaces = 2;
            this.zad1bCena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.zad1bCena.Location = new System.Drawing.Point(478, 99);
            this.zad1bCena.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.zad1bCena.Name = "zad1bCena";
            this.zad1bCena.Size = new System.Drawing.Size(120, 20);
            this.zad1bCena.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(420, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Zakupy >";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // zad2bt
            // 
            this.zad2bt.Location = new System.Drawing.Point(12, 12);
            this.zad2bt.Name = "zad2bt";
            this.zad2bt.Size = new System.Drawing.Size(179, 23);
            this.zad2bt.TabIndex = 35;
            this.zad2bt.Text = "Lista towarów sprzedanych od do";
            this.zad2bt.UseVisualStyleBackColor = true;
            this.zad2bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // zad2dateA
            // 
            this.zad2dateA.Location = new System.Drawing.Point(197, 15);
            this.zad2dateA.Name = "zad2dateA";
            this.zad2dateA.Size = new System.Drawing.Size(198, 20);
            this.zad2dateA.TabIndex = 36;
            this.zad2dateA.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // zad2dateB
            // 
            this.zad2dateB.Location = new System.Drawing.Point(401, 15);
            this.zad2dateB.Name = "zad2dateB";
            this.zad2dateB.Size = new System.Drawing.Size(198, 20);
            this.zad2dateB.TabIndex = 37;
            this.zad2dateB.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // zad3bt
            // 
            this.zad3bt.Location = new System.Drawing.Point(197, 186);
            this.zad3bt.Name = "zad3bt";
            this.zad3bt.Size = new System.Drawing.Size(179, 23);
            this.zad3bt.TabIndex = 38;
            this.zad3bt.Text = "Lista Brakujących towarów";
            this.zad3bt.UseVisualStyleBackColor = true;
            this.zad3bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // zad4bt
            // 
            this.zad4bt.Location = new System.Drawing.Point(382, 186);
            this.zad4bt.Name = "zad4bt";
            this.zad4bt.Size = new System.Drawing.Size(179, 23);
            this.zad4bt.TabIndex = 39;
            this.zad4bt.Text = "Towary do zamowienia z hurtowni";
            this.zad4bt.UseVisualStyleBackColor = true;
            this.zad4bt.Click += new System.EventHandler(this.zad4bt_Click);
            // 
            // zad5bt
            // 
            this.zad5bt.Location = new System.Drawing.Point(12, 41);
            this.zad5bt.Name = "zad5bt";
            this.zad5bt.Size = new System.Drawing.Size(179, 23);
            this.zad5bt.TabIndex = 40;
            this.zad5bt.Text = "dane za sprzedaż towaru";
            this.zad5bt.UseVisualStyleBackColor = true;
            this.zad5bt.Click += new System.EventHandler(this.zad5bt_Click);
            // 
            // zad5Type
            // 
            this.zad5Type.FormattingEnabled = true;
            this.zad5Type.Location = new System.Drawing.Point(197, 41);
            this.zad5Type.Name = "zad5Type";
            this.zad5Type.Size = new System.Drawing.Size(198, 21);
            this.zad5Type.TabIndex = 41;
            // 
            // Zad5DateA
            // 
            this.Zad5DateA.Location = new System.Drawing.Point(401, 42);
            this.Zad5DateA.Name = "Zad5DateA";
            this.Zad5DateA.Size = new System.Drawing.Size(198, 20);
            this.Zad5DateA.TabIndex = 42;
            this.Zad5DateA.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // zad6bt
            // 
            this.zad6bt.Location = new System.Drawing.Point(12, 186);
            this.zad6bt.Name = "zad6bt";
            this.zad6bt.Size = new System.Drawing.Size(179, 23);
            this.zad6bt.TabIndex = 43;
            this.zad6bt.Text = "Najczesciej Zamawiane towary";
            this.zad6bt.UseVisualStyleBackColor = true;
            this.zad6bt.Click += new System.EventHandler(this.button5_Click);
            // 
            // zad7bt
            // 
            this.zad7bt.Location = new System.Drawing.Point(567, 186);
            this.zad7bt.Name = "zad7bt";
            this.zad7bt.Size = new System.Drawing.Size(179, 23);
            this.zad7bt.TabIndex = 44;
            this.zad7bt.Text = "wykonane zam/prac";
            this.zad7bt.UseVisualStyleBackColor = true;
            this.zad7bt.Click += new System.EventHandler(this.zad7bt_Click);
            // 
            // zad8bt
            // 
            this.zad8bt.Location = new System.Drawing.Point(12, 157);
            this.zad8bt.Name = "zad8bt";
            this.zad8bt.Size = new System.Drawing.Size(179, 23);
            this.zad8bt.TabIndex = 45;
            this.zad8bt.Text = "suma zamowien na termin";
            this.zad8bt.UseVisualStyleBackColor = true;
            this.zad8bt.Click += new System.EventHandler(this.zad8bt_Click);
            // 
            // zad8DateA
            // 
            this.zad8DateA.Location = new System.Drawing.Point(197, 159);
            this.zad8DateA.Name = "zad8DateA";
            this.zad8DateA.Size = new System.Drawing.Size(198, 20);
            this.zad8DateA.TabIndex = 46;
            this.zad8DateA.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // zad9bt
            // 
            this.zad9bt.Location = new System.Drawing.Point(12, 70);
            this.zad9bt.Name = "zad9bt";
            this.zad9bt.Size = new System.Drawing.Size(179, 23);
            this.zad9bt.TabIndex = 47;
            this.zad9bt.Text = "Najwieksza liczba zamowień na";
            this.zad9bt.UseVisualStyleBackColor = true;
            this.zad9bt.Click += new System.EventHandler(this.zad6bt_Click);
            // 
            // zad9DateA
            // 
            this.zad9DateA.Location = new System.Drawing.Point(197, 73);
            this.zad9DateA.Name = "zad9DateA";
            this.zad9DateA.Size = new System.Drawing.Size(198, 20);
            this.zad9DateA.TabIndex = 48;
            this.zad9DateA.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // myGrid
            // 
            this.myGrid.AllowUserToAddRows = false;
            this.myGrid.AllowUserToDeleteRows = false;
            this.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid.Location = new System.Drawing.Point(13, 215);
            this.myGrid.Name = "myGrid";
            this.myGrid.ReadOnly = true;
            this.myGrid.Size = new System.Drawing.Size(944, 340);
            this.myGrid.TabIndex = 49;
            // 
            // zad9DateB
            // 
            this.zad9DateB.Location = new System.Drawing.Point(401, 73);
            this.zad9DateB.Name = "zad9DateB";
            this.zad9DateB.Size = new System.Drawing.Size(198, 20);
            this.zad9DateB.TabIndex = 50;
            this.zad9DateB.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // zad1b
            // 
            this.zad1b.Location = new System.Drawing.Point(12, 99);
            this.zad1b.Name = "zad1b";
            this.zad1b.Size = new System.Drawing.Size(179, 23);
            this.zad1b.TabIndex = 51;
            this.zad1b.Text = "Lista klientów";
            this.zad1b.UseVisualStyleBackColor = true;
            this.zad1b.Click += new System.EventHandler(this.zad1b_Click);
            // 
            // zad1bData
            // 
            this.zad1bData.Location = new System.Drawing.Point(197, 102);
            this.zad1bData.Name = "zad1bData";
            this.zad1bData.Size = new System.Drawing.Size(198, 20);
            this.zad1bData.TabIndex = 52;
            this.zad1bData.Value = new System.DateTime(2017, 4, 18, 15, 30, 39, 0);
            // 
            // AdditionalQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 567);
            this.Controls.Add(this.zad1bData);
            this.Controls.Add(this.zad1b);
            this.Controls.Add(this.zad9DateB);
            this.Controls.Add(this.myGrid);
            this.Controls.Add(this.zad9DateA);
            this.Controls.Add(this.zad9bt);
            this.Controls.Add(this.zad8DateA);
            this.Controls.Add(this.zad8bt);
            this.Controls.Add(this.zad7bt);
            this.Controls.Add(this.zad6bt);
            this.Controls.Add(this.Zad5DateA);
            this.Controls.Add(this.zad5Type);
            this.Controls.Add(this.zad5bt);
            this.Controls.Add(this.zad4bt);
            this.Controls.Add(this.zad3bt);
            this.Controls.Add(this.zad2dateB);
            this.Controls.Add(this.zad2dateA);
            this.Controls.Add(this.zad2bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zad1bCena);
            this.Controls.Add(this.zad1Date);
            this.Controls.Add(this.Zad1Bt);
            this.Controls.Add(this.ExitTB);
            this.Controls.Add(this.LogoutTB);
            this.MaximumSize = new System.Drawing.Size(985, 606);
            this.MinimumSize = new System.Drawing.Size(985, 606);
            this.Name = "AdditionalQuery";
            this.Text = "AdditionalQuery";
            ((System.ComponentModel.ISupportInitialize)(this.zad1bCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitTB;
        private System.Windows.Forms.Button LogoutTB;
        private System.Windows.Forms.Button Zad1Bt;
        private System.Windows.Forms.DateTimePicker zad1Date;
        private System.Windows.Forms.NumericUpDown zad1bCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zad2bt;
        private System.Windows.Forms.DateTimePicker zad2dateA;
        private System.Windows.Forms.DateTimePicker zad2dateB;
        private System.Windows.Forms.Button zad3bt;
        private System.Windows.Forms.Button zad4bt;
        private System.Windows.Forms.Button zad5bt;
        private System.Windows.Forms.ComboBox zad5Type;
        private System.Windows.Forms.DateTimePicker Zad5DateA;
        private System.Windows.Forms.Button zad6bt;
        private System.Windows.Forms.Button zad7bt;
        private System.Windows.Forms.Button zad8bt;
        private System.Windows.Forms.DateTimePicker zad8DateA;
        private System.Windows.Forms.Button zad9bt;
        private System.Windows.Forms.DateTimePicker zad9DateA;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.DateTimePicker zad9DateB;
        private System.Windows.Forms.Button zad1b;
        private System.Windows.Forms.DateTimePicker zad1bData;
    }
}