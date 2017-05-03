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

namespace DesktopSQL.Kierownik
{
    public partial class AdditionalQuery : Form
    {
        public AdditionalQuery()
        {
            InitializeComponent();
            string towarQuerry = "select * from SklepMuzycznyV2.dbo.Towar";
            DataSet TowarDataSet = new DataSet();
            DataGridView TowarGrid = new DataGridView();
            SqlDataAdapter TowarAdapter = new SqlDataAdapter();
            Dictionary.SelectData(towarQuerry, false, ref TowarGrid, new Panel(), ref TowarAdapter, ref TowarDataSet, "Towar", this);
            for (int i = 0; i < TowarDataSet.Tables[0].Rows.Count; i++)
            {
                zad5Type.Items.Add(TowarDataSet.Tables[0].Rows[i].Field<string>("To_Nazwa"));
            }

            this.BackColor = Dictionary.BackColor;
            Dictionary.DesignButton(Zad1Bt);
            Dictionary.DesignButton(zad2bt);
            Dictionary.DesignButton(zad3bt);
            Dictionary.DesignButton(zad4bt);
            Dictionary.DesignButton(zad5bt);
            Dictionary.DesignButton(zad6bt);
            Dictionary.DesignButton(zad7bt);
            Dictionary.DesignButton(zad8bt);
            Dictionary.DesignButton(zad9bt);
            Dictionary.DesignButton(zad1b);
            Dictionary.DesignButton(LogoutTB);
            Dictionary.DesignButton(ExitTB);
        }
        SqlDataAdapter adapterX;
        DataSet datasetX;

        private string datePickerToSQLDate(System.Windows.Forms.DateTimePicker x)
        {
            return x.Value.Year + " - " + ((x.Value.Month < 10) ? "0" + x.Value.Month.ToString() : x.Value.Month.ToString()) + " - " + ((x.Value.Day < 10) ? "0" + x.Value.Day.ToString() : x.Value.Day.ToString());
        }
        private void Zad1Bt_Click(object sender, EventArgs e)
        {
            string data = datePickerToSQLDate(zad1Date);
            //Otrzymać listę klientów posortowanych według wartości ich zakupów na wyznaczony termin. (kierownik)
            string query1A = "SELECT " +
                "Kl_Imie as ImieKlienta,Kl_Nazwisko as NazwiskoKlienta,Zamowienia.Za_NaKiedy as NaKiedyZamowiono,ListaTowarow.Li_Cena_Zakupu* Li_IloscTowaru as lacznyKoszt " +
                "FROM[SklepMuzycznyV2].[dbo].[Klienci] " +
                "INNER JOIN SklepMuzycznyV2.dbo.Zamowienia on[Klienci].Kl_ID = Zamowienia.Kl_ID " +
                "INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow on ListaTowarow.Za_ID = Zamowienia.Za_ID " +
                "Where Zamowienia.Za_NaKiedy= '"+data+"' " +
                "ORDER BY ListaTowarow.Li_Cena_Zakupu* ListaTowarow.Li_IloscTowaru desc, Zamowienia.Za_NaKiedy";
            Dictionary.SelectData(query1A, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }
        private void zad1b_Click(object sender, EventArgs e)
        {
            //Otrzymać liczbę klientów którzy zamówili towary w kwocie nie mniejszej od ustalonej wartości na określony termin. (kierownik)
            string query1B = "SELECT " +
                "Klienci.Kl_Imie, Klienci.Kl_Nazwisko,ListaTowarow.Li_Cena_Zakupu*ListaTowarow.Li_Cena_Zakupu as ŁącznaKwota " +
                "FROM[SklepMuzycznyV2].[dbo].[Klienci] " +
                "INNER JOIN SklepMuzycznyV2.dbo.Zamowienia on Klienci.Kl_ID = Zamowienia.Kl_ID " +
                "INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow on ListaTowarow.Za_ID = Zamowienia.Za_ID " +
                "WHERE Li_Cena_Zakupu*Li_Cena_Zakupu >"+zad1bCena.Value.ToString().Replace(",",".")+
                "AND Zamowienia.Za_NaKiedy = '"+datePickerToSQLDate(zad1bData)+ "'";

            Dictionary.SelectData(query1B, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // Otrzymać listę z wartością towarów sprzedanych za określony czas(Kierownik)
            string query = "SELECT Towar.To_Nazwa as NazwaTowaru, ListaTowarow.Li_Cena_Zakupu as CenaZaSztuke, ListaTowarow.Li_IloscTowaru as ZakupionychSztuk, Zamowienia.Za_KiedyKupione "+
            "FROM[SklepMuzycznyV2].[dbo].[Towar] " +
            "INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow on Towar.To_ID = ListaTowarow.To_ID " +
            "INNER JOIN SklepMuzycznyV2.dbo.Zamowienia on ListaTowarow.Za_ID = Zamowienia.Za_ID " +
            "where Zamowienia.Za_KiedyKupione >= '"+datePickerToSQLDate(zad2dateA)+ "' and Zamowienia.Za_KiedyKupione <= '"+datePickerToSQLDate(zad2dateB)+"' " +
            "ORDER BY ListaTowarow.Li_Cena_Zakupu asc; ";
            Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Otrzymać listę brakujących towarów. (Pracownik, Kierownik)
            string query = "SELECT Towar.To_Nazwa as NazwaTowaru, Towar.To_IloscNaStanie - ListaTowarow.Li_IloscTowaru as brakującyTowar FROM[SklepMuzycznyV2].[dbo].[Towar] inner join SklepMuzycznyV2.dbo.ListaTowarow on ListaTowarow.To_ID = Towar.To_ID where Towar.To_IloscNaStanie - ListaTowarow.Li_IloscTowaru < 0; ";
            Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }

        private void zad4bt_Click(object sender, EventArgs e)
        {

            //Otrzymać listę towarów do zamówienia z hurtowni(Kierownik, Pracownik)

            string query = "SELECT To_Nazwa as NazwaTowaru, To_IloscNaStanie FROM[SklepMuzycznyV2].[dbo].[Towar] where To_IloscNaStanie<10 ORDER BY To_IloscNaStanie asc;";
            Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }
        private void zad5bt_Click(object sender, EventArgs e)
        {

            //            Otrzymać dane za sprzedaż wyznaczonego towaru na wyznaczony termin. (Kierownik)
            if (zad5Type.SelectedItem!=null)
            {
                string query = "SELECT Towar.To_Nazwa as NazwaTowaru, ListaTowarow.Li_Cena_Zakupu as CenaZaSztuke, ListaTowarow.Li_IloscTowaru as IloscSztuk,Zamowienia.Za_KiedyKupione " +
                    "FROM[SklepMuzycznyV2].[dbo].Towar INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow on Towar.To_ID = ListaTowarow.To_ID INNER JOIN SklepMuzycznyV2.dbo.Zamowienia on ListaTowarow.Za_ID= Zamowienia.Za_ID " +
        "where Zamowienia.Za_KiedyKupione= '" + datePickerToSQLDate(Zad5DateA) + "' and Towar.To_Nazwa= '" + zad5Type.SelectedItem.ToString() + "'" +
        "ORDER BY ListaTowarow.Li_Cena_Zakupu asc;";
                Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
            }
            else
            { MessageBox.Show("Nie wybrałeś towaru"); }
        }

        private void zad6bt_Click(object sender, EventArgs e)
        {
            //            Otrzymać listę klientów którzy dokonali największą ilość zamówień za wyznaczony odcinek czasu(Kierownik)

            string query = "SELECT "+
                "Klienci.Kl_Imie,Klienci.Kl_Nazwisko, " +
                "Count(Zamowienia.Kl_ID) as ileZamowien " +
            "FROM[SklepMuzycznyV2].[dbo].Klienci " +
            "inner join SklepMuzycznyV2.dbo.Zamowienia on Zamowienia.Kl_ID = Klienci.Kl_ID " +
            "where Zamowienia.Za_NaKiedy >= '"+ datePickerToSQLDate(zad9DateA) + "' and Zamowienia.Za_NaKiedy <= '"+datePickerToSQLDate(zad9DateB)+"' " +
            "group by Klienci.Kl_Imie,Klienci.Kl_Nazwisko " +
            "order by ileZamowien desc; ";
            Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //            Otrzymać nazwę i ilość towarów najczęściej zamawianych w sklepie. (kierownik)
            
            string query = "SELECT Towar.To_Nazwa as NazwaTowaru,Towar.To_IloscNaStanie as IloscNaMagazynie,ListaTowarow.Li_IloscTowaru as IloscZamowionychDoTejPory "+
            "FROM[SklepMuzycznyV2].[dbo].[Towar] INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow on Towar.To_ID = ListaTowarow.To_ID INNER JOIN SklepMuzycznyV2.dbo.Zamowienia on ListaTowarow.Za_ID = Zamowienia.Za_ID "+
            "ORDER BY ListaTowarow.Li_IloscTowaru desc; ";
            Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }

        private void zad7bt_Click(object sender, EventArgs e)
        {
            //Otrzymać listę zrealizowanych zamówień oddzielnymi pracownikami sklepu.(Kierownik)

            string query = "SELECT Pracownicy.Pr_Imie, count(Zamowienia.Pr_ID) as IloscZlecen FROM[SklepMuzycznyV2].[dbo].[Pracownicy] inner join SklepMuzycznyV2.dbo.Zamowienia On Zamowienia.Pr_ID = Pracownicy.Pr_ID where Zamowienia.Za_CzyZrealizowano = 1 Group by Pracownicy.Pr_Imie having count(Zamowienia.Za_ID) > 0 order by IloscZlecen desc";
            Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
        }

        private void zad8bt_Click(object sender, EventArgs e)
        {
            //            Otrzymać sumę realizowanych zamówień w sklepie na wyznaczony termin. (Kierownik)
            string query = "SELECT left(Zamowienia.Za_NaKiedy, 12) as naKiedy, Count(Zamowienia.Za_ID) as IloscZlecen FROM[SklepMuzycznyV2].[dbo].Zamowienia"+
                " group by Zamowienia.Za_NaKiedy having Cast(Zamowienia.Za_NaKiedy as date) = '"+ datePickerToSQLDate(zad8DateA) +"'";
            Dictionary.SelectData(query, true, ref myGrid, new Panel(), ref adapterX, ref datasetX, "Klienci", this);
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
