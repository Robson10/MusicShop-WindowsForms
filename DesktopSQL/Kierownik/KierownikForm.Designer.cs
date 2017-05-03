namespace DesktopSQL.Kierownik
{
    partial class KierownikForm
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
            this.KlienciTB = new System.Windows.Forms.Button();
            this.PracownicyTB = new System.Windows.Forms.Button();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AdditionalQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitTB
            // 
            this.ExitTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitTB.Location = new System.Drawing.Point(559, 12);
            this.ExitTB.Name = "ExitTB";
            this.ExitTB.Size = new System.Drawing.Size(75, 23);
            this.ExitTB.TabIndex = 27;
            this.ExitTB.Text = "Zamknij";
            this.ExitTB.UseVisualStyleBackColor = true;
            this.ExitTB.Click += new System.EventHandler(this.Close_Click);
            // 
            // LogoutTB
            // 
            this.LogoutTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutTB.Location = new System.Drawing.Point(478, 12);
            this.LogoutTB.Name = "LogoutTB";
            this.LogoutTB.Size = new System.Drawing.Size(75, 23);
            this.LogoutTB.TabIndex = 26;
            this.LogoutTB.Text = "Wyloguj";
            this.LogoutTB.UseVisualStyleBackColor = true;
            this.LogoutTB.Click += new System.EventHandler(this.Logout_Click);
            // 
            // KlienciTB
            // 
            this.KlienciTB.Location = new System.Drawing.Point(12, 12);
            this.KlienciTB.Name = "KlienciTB";
            this.KlienciTB.Size = new System.Drawing.Size(133, 23);
            this.KlienciTB.TabIndex = 28;
            this.KlienciTB.Text = "Modyfikuj liste klientow";
            this.KlienciTB.UseVisualStyleBackColor = true;
            this.KlienciTB.Click += new System.EventHandler(this.KlienciTB_Click);
            // 
            // PracownicyTB
            // 
            this.PracownicyTB.Location = new System.Drawing.Point(151, 12);
            this.PracownicyTB.Name = "PracownicyTB";
            this.PracownicyTB.Size = new System.Drawing.Size(133, 23);
            this.PracownicyTB.TabIndex = 30;
            this.PracownicyTB.Text = "Modyfikuj pracownikow";
            this.PracownicyTB.UseVisualStyleBackColor = true;
            this.PracownicyTB.Click += new System.EventHandler(this.PracownicyTB_Click);
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(12, 41);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(88, 23);
            this.UpdateBT.TabIndex = 32;
            this.UpdateBT.Text = "Aktualizuj";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.Update_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(106, 41);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(100, 23);
            this.DeleteBT.TabIndex = 33;
            this.DeleteBT.Text = "Usun zaznaczony";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 225);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // AdditionalQuery
            // 
            this.AdditionalQuery.Location = new System.Drawing.Point(290, 12);
            this.AdditionalQuery.Name = "AdditionalQuery";
            this.AdditionalQuery.Size = new System.Drawing.Size(133, 23);
            this.AdditionalQuery.TabIndex = 35;
            this.AdditionalQuery.Text = "Dodatkowe funkcje";
            this.AdditionalQuery.UseVisualStyleBackColor = true;
            this.AdditionalQuery.Click += new System.EventHandler(this.AdditionalQuery_Click);
            // 
            // KierownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 308);
            this.Controls.Add(this.AdditionalQuery);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.PracownicyTB);
            this.Controls.Add(this.KlienciTB);
            this.Controls.Add(this.ExitTB);
            this.Controls.Add(this.LogoutTB);
            this.MaximumSize = new System.Drawing.Size(800, 347);
            this.Name = "KierownikForm";
            this.Text = "Okno Kierownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitTB;
        private System.Windows.Forms.Button LogoutTB;
        private System.Windows.Forms.Button KlienciTB;
        private System.Windows.Forms.Button PracownicyTB;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AdditionalQuery;
    }
}