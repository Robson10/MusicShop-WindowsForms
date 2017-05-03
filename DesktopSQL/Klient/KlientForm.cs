using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopSQL.Klient
{
    public partial class KlientForm : Form
    {
        Klienci AktualnyKlient;
        public KlientForm(Klienci _AktualnyKlient)
        {
            InitializeComponent();
            this.FormBorderStyle = Dictionary.Dc_borderStyle;
            MinimumSize = new Size(600,0);
            AktualnyKlient = _AktualnyKlient;
            this.BackColor = Dictionary.BackColor;
            Dictionary.DesignButton(PrzegladajTowary);
            Dictionary.DesignButton(PrzegladajZamowienia);
            Dictionary.DesignButton(DodajZamowieni);
            Dictionary.DesignButton(LogOut);
            Dictionary.DesignButton(Exit);
        }
        SklepMuzycznyV2Entities db = new SklepMuzycznyV2Entities();

        bool resizedByuser = false;

  

        private void BaseOperation(DataGridView Grid, string query, string connectionString = "Data Source=DESKTOP-KL9U024; Initial Catalog=SklepMuzycznyV2;Integrated Security=SSPI")
        {
            TowarGV.Visible = true;
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Grid.DataSource = dt;
            }
            if (WindowState!=FormWindowState.Maximized && !resizedByuser)
            {

                TowarGV.Width= (TowarGV.PreferredSize.Width<Screen.FromControl(this).Bounds.Width-50 )?TowarGV.PreferredSize.Width: Screen.FromControl(this).Bounds.Width - 50;
                TowarGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (TowarGV.Rows.Count>0)
                TowarGV.Height = TowarGV.Rows[0].Height*10;
                this.Width = TowarGV.Width * 105 / 100;
                this.Height = TowarGV.Height+100;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void PrzegladajTowary_Click(object sender, EventArgs e)
        {
            string przeglądanieListyTowarów = "select Towar.To_Nazwa as NazwaAlbumu, Towar.To_CenaAktualna as Cena, ty.Ty_Typ as Typ, Wykonawca.Wy_Imie + Wykonawca.Wy_Nazwisko as Wykonawca, Gatunek.Ga_Gatunek as gatunek, Towar.To_IloscNaStanie,Utwor.Ut_Name from Towar inner join SklepMuzycznyV2.dbo.Typ as ty on ty.Ty_ID = Towar.Ty_ID inner join SklepMuzycznyV2.dbo.TowarWykonawca on TowarWykonawca.To_ID = Towar.To_ID inner join SklepMuzycznyV2.dbo.Wykonawca on Wykonawca.Wy_ID = TowarWykonawca.Wy_ID inner join SklepMuzycznyV2.dbo.Gatunek on Gatunek.Ga_ID = Towar.Ga_ID inner join SklepMuzycznyV2.dbo.Utwor on Utwor.To_ID = Towar.To_ID where Towar.To_IloscNaStanie > 0 order by NazwaAlbumu";
            BaseOperation(TowarGV, przeglądanieListyTowarów);
        }

        private void PrzegladajZamowienia_Click(object sender, EventArgs e)
        {
            string przeglądanieZamowień = "select " + 
                "Towar.To_Nazwa As Album, ListaTowarow.Li_IloscTowaru as Ilosc, ListaTowarow.Li_Cena_Zakupu as \"Cena[szt]\", Zamowienia.Za_KiedyKupione as Zakupiono, Zamowienia.Za_NaKiedy as \"Dostarczyć na\", Za_CzyZrealizowano as \"czy zrealizowano\" "+
                "from Zamowienia inner join ListaTowarow on ListaTowarow.Za_ID = Zamowienia.Za_ID inner join Towar on Towar.To_ID = ListaTowarow.To_ID inner join Klienci on Klienci.Kl_ID = Zamowienia.Kl_ID "+
                "where Zamowienia.Kl_ID="+AktualnyKlient.Kl_ID.ToString() +
                "order by Za_CzyZrealizowano desc,To_Nazwa";
            BaseOperation(TowarGV, przeglądanieZamowień);            
        }

        private void DodajZamowieni_Click(object sender, EventArgs e)
        {
            KlientZlozZamowienie skladanieZamowienia = new KlientZlozZamowienie(new Klienci());
            skladanieZamowienia.Show();
        }
        protected void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
