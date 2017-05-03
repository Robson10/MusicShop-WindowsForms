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

namespace DesktopSQL.Pracownik
{
    public partial class DodajTowar : Form
    {
        FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();

        string towarQuerry = "select * from SklepMuzycznyV2.dbo.Towar";
        string utworQuerry = "select * from SklepMuzycznyV2.dbo.Utwor";
        string typQuerry = "select * from SklepMuzycznyV2.dbo.Typ";
        string wykonawcaQuerry = "select * from SklepMuzycznyV2.dbo.Wykonawca";
        string gatunekQuerry = "select * from SklepMuzycznyV2.dbo.Gatunek";
        string towarWykonawcaQuerry = "select * from SklepMuzycznyV2.dbo.TowarWykonawca";
        SqlDataAdapter TowarAdapter, TowarWykonawcaAdapter, UtworAdapter, TypAdapter, WykonawcaAdapter, GatunekAdapter;
        DataSet TowarDataSet, TowarWykonawcaDataSet, UtworDataSet, TypDataSet, WykonawcaDataSet, GatunekDataSet;
        DataGridView TowarGrid, TowarWykownawcaGrid, TypGrid, UtworGrid, GatunekGrid, WykonawcyGrid;
        public DodajTowar()
        {
            InitializeComponent();
            Dictionary.SelectData(towarQuerry, false, ref TowarGrid, flowLayoutPanel1, ref TowarAdapter, ref TowarDataSet, "Towar", this);
            Dictionary.SelectData(utworQuerry, false, ref UtworGrid, flowLayoutPanel1, ref UtworAdapter, ref UtworDataSet, "Utwor", this);
            Dictionary.SelectData(typQuerry, false, ref TypGrid, flowLayoutPanel1, ref TypAdapter, ref TypDataSet, "Typ", this);
            Dictionary.SelectData(wykonawcaQuerry, false, ref WykonawcyGrid, flowLayoutPanel1, ref WykonawcaAdapter, ref WykonawcaDataSet, "Wykonawca", this);
            Dictionary.SelectData(gatunekQuerry, false, ref GatunekGrid, flowLayoutPanel1, ref GatunekAdapter, ref GatunekDataSet, "Gatunek", this);
            Dictionary.SelectData(towarWykonawcaQuerry, false, ref TowarWykownawcaGrid, flowLayoutPanel1, ref TowarWykonawcaAdapter, ref TowarWykonawcaDataSet, "TowarWykonawca", this);
            fillComboTyp();
            fillComboGatunek();
            Dictionary.DesignButton(DodajBT);
            Dictionary.DesignButton(AnulujBT);
            this.BackColor = Dictionary.BackColor;

        }
        List <int> TypId = new List<int>();
        private void fillComboTyp()
        {
            for (int i = 0; i < TypDataSet.Tables[0].Rows.Count; i++)
            {
                ComboTyp.Items.Add(TypDataSet.Tables[0].Rows[i].Field<string>("Ty_Typ"));
                TypId.Add(TypDataSet.Tables[0].Rows[i].Field<int>("Ty_ID"));
            }
        }
        List<int> GatunekId = new List<int>();
        private void fillComboGatunek()
        {
            for (int i = 0; i < GatunekDataSet.Tables[0].Rows.Count; i++)
            {
                ComboGatunek.Items.Add(GatunekDataSet.Tables[0].Rows[i].Field<string>("Ga_Gatunek"));
                GatunekId.Add(GatunekDataSet.Tables[0].Rows[i].Field<int>("Ga_ID"));
            }
        }

        private void DodajBT_Click(object sender, EventArgs e)
        {
            cenaTB.Text = cenaTB.Text.Replace(".", ",");
            if (ComboGatunek.SelectedIndex > 0) ;
            string query1 = "insert into SklepMuzycznyV2.dbo.Towar(Ga_ID,Ty_ID,To_CenaAktualna,To_IloscNaStanie,To_Nazwa) " + "values(" + GatunekId[ComboGatunek.SelectedIndex].ToString() + "," + TypId[ComboTyp.SelectedIndex].ToString() + "," + Convert.ToDecimal(cenaTB.Text).ToString().Replace(",", ".") + "," + CountNum.Value.ToString() + ",'" + NazwaTB.Text + "')";
            Dictionary.InsertData(query1, "Towar");

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            DataGridView x = new DataGridView();
            Dictionary.SelectData("select * from SklepMuzycznyV2.dbo.Towar where Towar.To_Nazwa='"+NazwaTB.Text +"'", false, ref x, flowLayoutPanel1, ref adapter, ref dataset, "Towar", this);
            int To_ID = dataset.Tables[0].Rows[dataset.Tables[0].Rows.Count-1].Field<int>("To_ID");
            adapter = null;
            dataset = null;
            x = null;

            for (int i = 0; i < UtworyGrid.Rows.Count-1; i++)
            {
                if (UtworyGrid.Rows[i].Cells[1].Value == null)
                {
                    string query2 = "insert into SklepMuzycznyV2.dbo.Utwor(To_ID, Ut_Name) " +
                      "values(" + To_ID.ToString() + " ,'" + UtworyGrid.Rows[i].Cells[0].Value.ToString() + "' )";
                    Dictionary.InsertData(query2, "Utwor");
                }
                else
                {
                    string query2 = "insert into SklepMuzycznyV2.dbo.Utwor(To_ID, Ut_Name, Ut_CzasUtworu) " +
                      "values(" + To_ID.ToString() + " ,'" + UtworyGrid.Rows[i].Cells[0].Value.ToString() + "' ," + UtworyGrid.Rows[i].Cells[1].Value.ToString() + ")";
                    Dictionary.InsertData(query2, "Utwor");
                }
                
            }
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void AnulujBT_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
    class MyRow
    {
        public MyRow(string name) { Ut_Name = name; }
        public string Ut_Name { get; set; }
        public string Ut_CzasUtworu { get; set; }
    }
}