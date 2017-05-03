using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesktopSQL.Kierownik
{
    public partial class KierownikForm : Form
    {
        public KierownikForm()
        {
            InitializeComponent();
            this.FormBorderStyle = Dictionary.Dc_borderStyle;
            this.BackColor = Dictionary.BackColor;
            Dictionary.DesignButton(KlienciTB);
            Dictionary.DesignButton(PracownicyTB);
            Dictionary.DesignButton(DeleteBT);
            Dictionary.DesignButton(UpdateBT);
            Dictionary.DesignButton(AdditionalQuery);
            Dictionary.DesignButton(LogoutTB);
            Dictionary.DesignButton(ExitTB);
        }
        bool resizedByuser = false;
        SqlDataAdapter PracownicyAdapter, KlienciAdapter;
        DataSet PracownicyDataSet, KlienciDataSet;
        DataGridView PracownicyGrid, KlienciGrid;
        string pracownicyQuerry = "SELECT [Pr_ID], [Pr_Imie],[Pr_Nazwisko],[Pr_AdresPracy],[Pr_CzyZatrudniony]FROM [SklepMuzycznyV2].[dbo].[Pracownicy]";
        string klienciQuerry = "SELECT [Kl_ID],[Kl_Imie] ,[Kl_Nazwisko] ,[Kl_Pesel],[Kl_Mail],[Kl_Adres]FROM[SklepMuzycznyV2].[dbo].[Klienci]";
        private void KlienciTB_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(klienciQuerry, false, ref KlienciGrid, flowLayoutPanel1, ref KlienciAdapter, ref KlienciDataSet, "Klienci",this);
            KlienciGrid.Visible = !KlienciGrid.Visible;
            KlienciGrid.Columns[0].Visible = false;
           if(PracownicyGrid!=null)PracownicyGrid.Visible = false;
        }

        private void AdditionalQuery_Click(object sender, EventArgs e)
        {
            AdditionalQuery window = new Kierownik.AdditionalQuery();
            this.Hide();
            if (window.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void PracownicyTB_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(pracownicyQuerry, false, ref PracownicyGrid, flowLayoutPanel1, ref PracownicyAdapter, ref PracownicyDataSet, "Pracownicy", this);
            PracownicyGrid.Visible = !PracownicyGrid.Visible;
            PracownicyGrid.Columns[0].Visible = false;
            if (KlienciGrid!=null)KlienciGrid.Visible = false;
        }
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (PracownicyGrid != null && PracownicyGrid.Visible )
            {
                PracownicyGrid.Rows.RemoveAt(PracownicyGrid.SelectedCells[0].RowIndex);
                Dictionary.UpdateData(ref PracownicyDataSet, ref PracownicyAdapter, "Pracownicy", ref PracownicyGrid, pracownicyQuerry, this,flowLayoutPanel1);
            }
            else if (KlienciGrid != null && KlienciGrid.Visible )
            {
                KlienciGrid.Rows.RemoveAt(KlienciGrid.SelectedCells[0].RowIndex);
                Dictionary.UpdateData(ref KlienciDataSet, ref KlienciAdapter, "Klienci", ref KlienciGrid, klienciQuerry, this,flowLayoutPanel1);
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (PracownicyGrid != null)
            {
                for (int i = 0; i < PracownicyGrid.Rows.Count; i++)
                {
                    if ( Convert.IsDBNull(PracownicyGrid[4, i].Value))
                    {
                        PracownicyGrid[4, i].Value = false;
                    }
                }
                Dictionary.UpdateData(ref PracownicyDataSet, ref PracownicyAdapter, "Pracownicy", ref PracownicyGrid, pracownicyQuerry, this, flowLayoutPanel1);
            }
            if (KlienciGrid != null) Dictionary.UpdateData(ref KlienciDataSet, ref KlienciAdapter, "Klienci", ref KlienciGrid, klienciQuerry, this,flowLayoutPanel1);
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
/*
Otrzymać listę klientów posortowanych według wartości ich zakupów na wyznaczony termin. (kierownik)
SELECT
    Kl_Imie as ImieKlienta,
    Kl_Nazwisko as NazwiskoKlienta,
    za.Za_NaKiedy as NaKiedyZamowiono,
    li.Li_Cena_Zakupu*Li_IloscTowaru as lacznyKoszt
FROM [SklepMuzycznyV2].[dbo].[Klienci] as kl
INNER JOIN SklepMuzycznyV2.dbo.Zamowienia za on kl.Kl_ID = za.Kl_ID
INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow li on li.Za_ID = za.Za_ID
Where za.Za_NaKiedy='2017-04-02'
ORDER BY li.Li_Cena_Zakupu*li.Li_IloscTowaru desc, za.Za_NaKiedy


Otrzymać liczbę klientów którzy zamówili towary w kwocie nie mniejszej od ustalonej wartości na określony termin. (kierownik)
SELECT
    Count(Kl_Imie) as LiczbaKlientow
FROM [SklepMuzycznyV2].[dbo].[Klienci] as kl
INNER JOIN SklepMuzycznyV2.dbo.Zamowienia za
    on kl.Kl_ID = za.Kl_ID
INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow li
    on li.Za_ID = za.Za_ID
WHERE Li_Cena_Zakupu*Li_Cena_Zakupu>100 AND za.Za_NaKiedy='2017-04-1'


Otrzymać listę z wartością towarów sprzedanych za określony czas (Kierownik)
SELECT
    tow.To_Nazwa as NazwaTowaru,
    li.Li_Cena_Zakupu as CenaZaSztuke,
    li.Li_IloscTowaru as ZakupionychSztuk,
    za.Za_KiedyKupione
FROM [SklepMuzycznyV2].[dbo].[Towar] as tow
INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow li
    on tow.To_ID = li.To_ID
INNER JOIN SklepMuzycznyV2.dbo.Zamowienia za
    on li.Za_ID=za.Za_ID
where za.Za_KiedyKupione='2017-03-28'
ORDER BY li.Li_Cena_Zakupu asc;


Otrzymać listę brakujących towarów. (Pracownik,Kierownik)
SELECT
    tow.To_Nazwa as NazwaTowaru,
    tow.To_IloscNaStanie-li.Li_IloscTowaru as brakującyTowar
FROM [SklepMuzycznyV2].[dbo].[Towar] as tow
inner join SklepMuzycznyV2.dbo.ListaTowarow as li on li.To_ID=tow.To_ID
where tow.To_IloscNaStanie-li.Li_IloscTowaru<0;


Otrzymać listę towarów do zamówienia z hurtowni (Kierownik,Pracownik)
SELECT
    tow.To_Nazwa as NazwaTowaru,
    tow.To_IloscNaStanie
FROM [SklepMuzycznyV2].[dbo].[Towar] as tow
where tow.To_IloscNaStanie<10
ORDER BY tow.To_IloscNaStanie asc;


Otrzymać dane za sprzedaż wyznaczonego towaru na wyznaczony termin. (Kierownik)
SELECT
    tow.To_Nazwa as NazwaTowaru,
    li.Li_Cena_Zakupu as CenaZaSztuke,
    li.Li_IloscTowaru  as IloscSztuk,
    za.Za_KiedyKupione
FROM [SklepMuzycznyV2].[dbo].[Towar] as tow
INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow li
    on tow.To_ID = li.To_ID
INNER JOIN SklepMuzycznyV2.dbo.Zamowienia za
    on li.Za_ID=za.Za_ID
where za.Za_KiedyKupione='2017-03-20' and tow.To_Nazwa='Untrue'
ORDER BY li.Li_Cena_Zakupu asc;


Otrzymać nazwę i ilość towarów najczęściej zamawianych w sklepie. (kierownik)
SELECT
    tow.To_Nazwa as NazwaTowaru,
    tow.To_IloscNaStanie as IloscNaMagazynie,
    li.Li_IloscTowaru as IloscZamowionychDoTejPory
FROM [SklepMuzycznyV2].[dbo].[Towar] as tow
INNER JOIN SklepMuzycznyV2.dbo.ListaTowarow li
    on tow.To_ID = li.To_ID
INNER JOIN SklepMuzycznyV2.dbo.Zamowienia za
    on li.Za_ID=za.Za_ID
ORDER BY li.Li_IloscTowaru desc;


Otrzymać listę zrealizowanych zamówień oddzielnymi pracownikami sklepu.(Kierownik)
SELECT
    pr.Pr_Imie,
    count(za.Pr_ID)as IloscZlecen
FROM [SklepMuzycznyV2].[dbo].[Pracownicy] as pr
inner join SklepMuzycznyV2.dbo.Zamowienia as za On za.Pr_ID=pr.Pr_ID
where za.Za_CzyZrealizowano=1
Group by pr.Pr_Imie
having count(za.Za_ID)>0
order by IloscZlecen desc


Otrzymać sumę realizowanych zamówień w sklepie na wyznaczony termin. (Kierownik)
SELECT
    za.Za_NaKiedy,
    Count(za.Za_ID) as IloscZlecen
FROM [SklepMuzycznyV2].[dbo].Zamowienia as za
group by za.Za_NaKiedy
having Cast(za.Za_NaKiedy as date) = '2017-04-20'



Otrzymać listę klientów którzy dokonali największą ilość zamówień za wyznaczony odcinek czasu (Kierownik)
SELECT
    kl.Kl_Imie,
    Count(za.Kl_ID)as ileZamowien
FROM [SklepMuzycznyV2].[dbo].Klienci as kl
inner join SklepMuzycznyV2.dbo.Zamowienia as  za on za.Kl_ID=kl.Kl_ID
where za.Za_NaKiedy>'2017-03-20' and za.Za_NaKiedy<'2017-04-10'
group by kl.Kl_Imie
order by ileZamowien desc;
*/