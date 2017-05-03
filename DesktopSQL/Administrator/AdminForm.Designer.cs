using DesktopSQL.Administrator.SQLConnectors;

namespace DesktopSQL.Administrator
{
    partial class AdminForm
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
            this.UpdateBT = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoutBT = new System.Windows.Forms.Button();
            this.CloseBT = new System.Windows.Forms.Button();
            this.PracownicyBT = new System.Windows.Forms.Button();
            this.KlienciBT = new System.Windows.Forms.Button();
            this.ZamowienieTB = new System.Windows.Forms.Button();
            this.ListaTowarówBT = new System.Windows.Forms.Button();
            this.TowarBT = new System.Windows.Forms.Button();
            this.UtowrBT = new System.Windows.Forms.Button();
            this.TypBT = new System.Windows.Forms.Button();
            this.WykonawcaBT = new System.Windows.Forms.Button();
            this.GatunekBT = new System.Windows.Forms.Button();
            this.TowarGatunekBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(936, 12);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(115, 23);
            this.UpdateBT.TabIndex = 10;
            this.UpdateBT.Text = "Aktualizuj Baze";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.flowLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(50, 700);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 49);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1290, 600);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(1290, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1290, 580);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // LogoutBT
            // 
            this.LogoutBT.Location = new System.Drawing.Point(1057, 12);
            this.LogoutBT.Name = "LogoutBT";
            this.LogoutBT.Size = new System.Drawing.Size(115, 23);
            this.LogoutBT.TabIndex = 20;
            this.LogoutBT.Text = "Wyloguj";
            this.LogoutBT.UseVisualStyleBackColor = true;
            this.LogoutBT.Click += new System.EventHandler(this.Logout_Click);
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(1178, 12);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(115, 23);
            this.CloseBT.TabIndex = 21;
            this.CloseBT.Text = "Zamknij";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.Close_Click);
            // 
            // PracownicyBT
            // 
            this.PracownicyBT.Location = new System.Drawing.Point(12, 12);
            this.PracownicyBT.Name = "PracownicyBT";
            this.PracownicyBT.Size = new System.Drawing.Size(75, 23);
            this.PracownicyBT.TabIndex = 12;
            this.PracownicyBT.Text = "Pracownicy";
            this.PracownicyBT.UseVisualStyleBackColor = true;
            this.PracownicyBT.Click += new System.EventHandler(this.PracownicyBT_Click);
            // 
            // KlienciBT
            // 
            this.KlienciBT.Location = new System.Drawing.Point(93, 12);
            this.KlienciBT.Name = "KlienciBT";
            this.KlienciBT.Size = new System.Drawing.Size(75, 23);
            this.KlienciBT.TabIndex = 13;
            this.KlienciBT.Text = "Klienci";
            this.KlienciBT.UseVisualStyleBackColor = true;
            this.KlienciBT.Click += new System.EventHandler(this.KlienciBT_Click);
            // 
            // ZamowienieTB
            // 
            this.ZamowienieTB.Location = new System.Drawing.Point(174, 12);
            this.ZamowienieTB.Name = "ZamowienieTB";
            this.ZamowienieTB.Size = new System.Drawing.Size(75, 23);
            this.ZamowienieTB.TabIndex = 14;
            this.ZamowienieTB.Text = "Zamowienia";
            this.ZamowienieTB.UseVisualStyleBackColor = true;
            this.ZamowienieTB.Click += new System.EventHandler(this.ZamowienieTB_Click);
            // 
            // ListaTowarówBT
            // 
            this.ListaTowarówBT.Location = new System.Drawing.Point(255, 12);
            this.ListaTowarówBT.Name = "ListaTowarówBT";
            this.ListaTowarówBT.Size = new System.Drawing.Size(87, 23);
            this.ListaTowarówBT.TabIndex = 15;
            this.ListaTowarówBT.Text = "ListaTowarów";
            this.ListaTowarówBT.UseVisualStyleBackColor = true;
            this.ListaTowarówBT.Click += new System.EventHandler(this.ListaTowarówBT_Click);
            // 
            // TowarBT
            // 
            this.TowarBT.Location = new System.Drawing.Point(348, 12);
            this.TowarBT.Name = "TowarBT";
            this.TowarBT.Size = new System.Drawing.Size(75, 23);
            this.TowarBT.TabIndex = 16;
            this.TowarBT.Text = "Towary";
            this.TowarBT.UseVisualStyleBackColor = true;
            this.TowarBT.Click += new System.EventHandler(this.TowarBT_Click);
            // 
            // UtowrBT
            // 
            this.UtowrBT.Location = new System.Drawing.Point(429, 12);
            this.UtowrBT.Name = "UtowrBT";
            this.UtowrBT.Size = new System.Drawing.Size(75, 23);
            this.UtowrBT.TabIndex = 17;
            this.UtowrBT.Text = "Utwory";
            this.UtowrBT.UseVisualStyleBackColor = true;
            this.UtowrBT.Click += new System.EventHandler(this.UtowrBT_Click);
            // 
            // TypBT
            // 
            this.TypBT.Location = new System.Drawing.Point(510, 12);
            this.TypBT.Name = "TypBT";
            this.TypBT.Size = new System.Drawing.Size(75, 23);
            this.TypBT.TabIndex = 18;
            this.TypBT.Text = "Typy";
            this.TypBT.UseVisualStyleBackColor = true;
            this.TypBT.Click += new System.EventHandler(this.TypBT_Click);
            // 
            // WykonawcaBT
            // 
            this.WykonawcaBT.Location = new System.Drawing.Point(591, 12);
            this.WykonawcaBT.Name = "WykonawcaBT";
            this.WykonawcaBT.Size = new System.Drawing.Size(75, 23);
            this.WykonawcaBT.TabIndex = 19;
            this.WykonawcaBT.Text = "Wykonawcy";
            this.WykonawcaBT.UseVisualStyleBackColor = true;
            this.WykonawcaBT.Click += new System.EventHandler(this.WykonawcaBT_Click);
            // 
            // GatunekBT
            // 
            this.GatunekBT.Location = new System.Drawing.Point(672, 12);
            this.GatunekBT.Name = "GatunekBT";
            this.GatunekBT.Size = new System.Drawing.Size(75, 23);
            this.GatunekBT.TabIndex = 22;
            this.GatunekBT.Text = "Gatunki";
            this.GatunekBT.UseVisualStyleBackColor = true;
            this.GatunekBT.Click += new System.EventHandler(this.GatunekBT_Click);
            // 
            // TowarGatunekBT
            // 
            this.TowarGatunekBT.Location = new System.Drawing.Point(753, 12);
            this.TowarGatunekBT.Name = "TowarGatunekBT";
            this.TowarGatunekBT.Size = new System.Drawing.Size(120, 23);
            this.TowarGatunekBT.TabIndex = 23;
            this.TowarGatunekBT.Text = "Towar-Wykonawca";
            this.TowarGatunekBT.UseVisualStyleBackColor = true;
            this.TowarGatunekBT.Click += new System.EventHandler(this.TowarGatunekBT_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 641);
            this.Controls.Add(this.TowarGatunekBT);
            this.Controls.Add(this.GatunekBT);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.LogoutBT);
            this.Controls.Add(this.WykonawcaBT);
            this.Controls.Add(this.TypBT);
            this.Controls.Add(this.UtowrBT);
            this.Controls.Add(this.TowarBT);
            this.Controls.Add(this.ListaTowarówBT);
            this.Controls.Add(this.ZamowienieTB);
            this.Controls.Add(this.KlienciBT);
            this.Controls.Add(this.PracownicyBT);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.UpdateBT);
            this.MaximumSize = new System.Drawing.Size(1321, 680);
            this.MinimumSize = new System.Drawing.Size(1321, 680);
            this.Name = "AdminForm";
            this.Text = "Okno Administratora";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button LogoutBT;
        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.Button PracownicyBT;
        private System.Windows.Forms.Button KlienciBT;
        private System.Windows.Forms.Button ZamowienieTB;
        private System.Windows.Forms.Button ListaTowarówBT;
        private System.Windows.Forms.Button TowarBT;
        private System.Windows.Forms.Button UtowrBT;
        private System.Windows.Forms.Button TypBT;
        private System.Windows.Forms.Button WykonawcaBT;
        private System.Windows.Forms.Button GatunekBT;
        private System.Windows.Forms.Button TowarGatunekBT;
    }
}