using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesktopSQL.Administrator
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.FormBorderStyle = Dictionary.Dc_borderStyle;
            this.BackColor = Dictionary.BackColor;
            Dictionary.DesignButton(CloseBT);
            Dictionary.DesignButton(LogoutBT);
            Dictionary.DesignButton(PracownicyBT);
            Dictionary.DesignButton(KlienciBT);
            Dictionary.DesignButton(ZamowienieTB);
            Dictionary.DesignButton(ListaTowarówBT);
            Dictionary.DesignButton(TowarBT);
            Dictionary.DesignButton(UtowrBT);
            Dictionary.DesignButton(TypBT);
            Dictionary.DesignButton(WykonawcaBT);
            Dictionary.DesignButton(GatunekBT);
            Dictionary.DesignButton(TowarGatunekBT);
            Dictionary.DesignButton(UpdateBT);
        }
        
        string pracownicyQuerry = "SELECT * FROM[SklepMuzycznyV2].[dbo].[Pracownicy]";
        string towarQuerry = "select * from SklepMuzycznyV2.dbo.Towar";
        string utworQuerry = "select * from SklepMuzycznyV2.dbo.Utwor";
        string typQuerry = "select * from SklepMuzycznyV2.dbo.Typ";
        string wykonawcaQuerry = "select * from SklepMuzycznyV2.dbo.Wykonawca";
        string gatunekQuerry = "select * from SklepMuzycznyV2.dbo.Gatunek";
        string towarWykonawcaQuerry = "select * from SklepMuzycznyV2.dbo.TowarWykonawca";
        string listaTowarowQuerry = "select * from SklepMuzycznyV2.dbo.ListaTowarow";
        string zamowienieQuerry = "select * from SklepMuzycznyV2.dbo.Zamowienia";
        string klientQuerry = "select * from SklepMuzycznyV2.dbo.Klienci";
        SqlDataAdapter PracownicyAdapter,KlienciAdapter,ZamowieniaAdapter,ListaTowarowAdapter,TowarAdapter,TowarWykonawcaAdapter,UtworAdapter,TypAdapter,WykonawcaAdapter,GatunekAdapter;
        DataSet PracownicyDataSet, KlienciDataSet, ZamowieniaDataSet, ListaTowarowDataSet, TowarDataSet, TowarWykonawcaDataSet, UtworDataSet, TypDataSet, WykonawcaDataSet, GatunekDataSet;
        DataGridView PracownicyGrid, KlienciGrid, ZamowieniaGrid, ListaTowarowGrid, TowarGrid, TowarWykownawcaGrid, TypGrid, UtworGrid, GatunekGrid, WykonawcyGrid;

        private void AdminForm_Load(object sender, EventArgs e)
        {
  
        }

       private void TowarBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(towarQuerry, false, ref TowarGrid, flowLayoutPanel1, ref TowarAdapter, ref TowarDataSet,"Towar", this);
            TowarGrid.Visible = !TowarGrid.Visible;
        }
        private void UtowrBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(utworQuerry, false, ref UtworGrid, flowLayoutPanel1, ref UtworAdapter, ref UtworDataSet,"Utwor", this);
            UtworGrid.Visible = !UtworGrid.Visible;
        }
        private void TypBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(typQuerry, false, ref TypGrid, flowLayoutPanel1, ref TypAdapter, ref TypDataSet,"Typ", this);
            TypGrid.Visible = !TypGrid.Visible;
        }
        private void WykonawcaBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(wykonawcaQuerry, false, ref WykonawcyGrid, flowLayoutPanel1, ref WykonawcaAdapter, ref WykonawcaDataSet,"Wykonawca", this);
            WykonawcyGrid.Visible = !WykonawcyGrid.Visible;
        }
        private void GatunekBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(gatunekQuerry, false, ref GatunekGrid, flowLayoutPanel1, ref GatunekAdapter, ref GatunekDataSet,"Gatunek", this);
            GatunekGrid.Visible = !GatunekGrid.Visible;
        }
        private void TowarGatunekBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(towarWykonawcaQuerry, false, ref TowarWykownawcaGrid, flowLayoutPanel1, ref TowarWykonawcaAdapter, ref TowarWykonawcaDataSet,"TowarWykonawca", this);
            TowarWykownawcaGrid.Visible = !TowarWykownawcaGrid.Visible;
        }
        private void ListaTowarówBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(listaTowarowQuerry, false, ref ListaTowarowGrid, flowLayoutPanel1, ref ListaTowarowAdapter, ref ListaTowarowDataSet,"ListaTowarow", this);
            ListaTowarowGrid.Visible = !ListaTowarowGrid.Visible;
        }
        private void ZamowienieTB_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(zamowienieQuerry, false, ref ZamowieniaGrid , flowLayoutPanel1, ref ZamowieniaAdapter, ref ZamowieniaDataSet,"Zamowienia", this);
            ZamowieniaGrid.Visible = !ZamowieniaGrid.Visible;
        }
        private void KlienciBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(klientQuerry, false, ref KlienciGrid, flowLayoutPanel1, ref KlienciAdapter, ref KlienciDataSet,"Klienci", this);
            KlienciGrid.Visible = !KlienciGrid.Visible;
        }
        private void PracownicyBT_Click(object sender, EventArgs e)
        {
            Dictionary.SelectData(pracownicyQuerry,false,ref PracownicyGrid,flowLayoutPanel1,ref PracownicyAdapter,ref PracownicyDataSet,"Pracownicy", this);
            PracownicyGrid.Visible = !PracownicyGrid.Visible;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary.UpdateData(ref PracownicyDataSet,ref PracownicyAdapter,"Pracownicy",ref PracownicyGrid,pracownicyQuerry, this,flowLayoutPanel1);
                Dictionary.UpdateData(ref KlienciDataSet, ref KlienciAdapter, "Klienci", ref KlienciGrid, klientQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref ZamowieniaDataSet, ref ZamowieniaAdapter, "Zamowienia", ref ZamowieniaGrid, zamowienieQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref ListaTowarowDataSet, ref ListaTowarowAdapter, "ListaTowarow", ref ListaTowarowGrid, listaTowarowQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref TowarWykonawcaDataSet, ref TowarWykonawcaAdapter, "TowarWykonawca", ref TowarWykownawcaGrid, towarWykonawcaQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref GatunekDataSet, ref GatunekAdapter, "Gatunek", ref GatunekGrid, gatunekQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref WykonawcaDataSet, ref WykonawcaAdapter, "Wykonawca", ref WykonawcyGrid, wykonawcaQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref TypDataSet, ref TypAdapter, "Typ", ref TypGrid, typQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref UtworDataSet, ref UtworAdapter, "Utwor", ref UtworGrid, utworQuerry, this, flowLayoutPanel1);
                Dictionary.UpdateData(ref TowarDataSet, ref TowarAdapter, "Towar", ref TowarGrid, towarQuerry, this, flowLayoutPanel1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
