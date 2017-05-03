using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopSQL.Klient
{
    public partial class KlientZlozZamowienie : Form
    {
        //Klient
        Klienci klient;//trzeba pobierać z wczesniej przy logowaniu
        //Zamowienie
        DateTime KiedyKupiono = new DateTime();
        
        //ListaTowarow
        List<MojTowar> NowaListaTowarow = new List<MojTowar>();
        List<MojTowar> Rachunek = new List<MojTowar>();

        public KlientZlozZamowienie(Klienci _aktualnyKlient)
        {
            InitializeComponent();
            this.FormBorderStyle = Dictionary.Dc_borderStyle;
            fillDefaultComponents();
            klient = _aktualnyKlient;
            aktualizujGrida();
            this.BackColor = Dictionary.BackColor;
            Dictionary.DesignButton(Cofnij);
            Dictionary.DesignButton(Ok);
            Dictionary.DesignButton(Dodaj);
            Dictionary.DesignButton(Anuluj);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            KiedyKupiono =DateTime.Now;

            if (dateTimePicker1.Value < KiedyKupiono.AddDays(0))
            {
                MessageBox.Show("Nasza firma nie jest w stanie dostarczyć zamowienia na dni ktore już przeminęły");
            }
            else if (dateTimePicker1.Value <KiedyKupiono.AddDays(1))
            {
                MessageBox.Show("Nasza firma nie jest w stanie dostarczyć zamowienia na dziś");
            }
            else
            {
                var x= dateTimePicker1.Value;
                string kiedyKupiono = "'" + KiedyKupiono.Year + "." + ((KiedyKupiono.Month < 10) ? ("0" + KiedyKupiono.Month.ToString()) : KiedyKupiono.Month.ToString()) + "." + ((KiedyKupiono.Day < 10) ? "0" + KiedyKupiono.Day.ToString() : KiedyKupiono.Day.ToString()) + "'";
                string naKiedy = "'" + x.Year + "." + ((x.Month < 10) ? ("0" + x.Month.ToString()) : x.Month.ToString()) + "." + ((x.Day < 10) ? "0" + x.Day.ToString() : x.Day.ToString()) + "'";

                string query = "insert into SklepMuzycznyV2.dbo.Zamowienia (Kl_ID,Za_NaKiedy,Za_KiedyKupione,Za_CzyZrealizowano)"+
                        "values("+klient.Kl_ID+","+naKiedy+","+ kiedyKupiono + "," + 0+")";
                Dictionary.InsertData(query, "Zamowienia");
                DataGridView temp = new DataGridView();
                SqlDataAdapter tempAdap = new SqlDataAdapter();
                DataSet tempDataset = new DataSet();
                Dictionary.SelectData("select * from SklepMuzycznyV2.dbo.Zamowienia where Zamowienia.Kl_ID=" + klient.Kl_ID,false,ref temp,new Panel(),ref tempAdap,ref tempDataset,"Zamowienia",this);
                int idZamowienia = tempDataset.Tables[0].Rows[tempDataset.Tables[0].Rows.Count-1].Field<int>(0);
                for (int i = 0; i < Rachunek.Count; i++)
                {
                    query = "insert into SklepMuzycznyV2.dbo.ListaTowarow(Za_ID, To_ID, Li_IloscTowaru, Li_Cena_Zakupu)" +
                        "values(" +idZamowienia +"," + Rachunek[i].ID + "," + Rachunek[i].IloscTowaru+","+ Rachunek[i].Cena.ToString().Replace(",",".") + ")";
                    Dictionary.InsertData(query, "ListaTowarow");
                }
            }
        }
        private void fillDefaultComponents()
        {
            string przeglądanieListyTowarów = "select Towar.To_ID,Towar.To_Nazwa,Towar.To_CenaAktualna from Towar";
            BaseOperation(dataGridView1, przeglądanieListyTowarów,1);
        }
        private void BaseOperation( DataGridView Grid, string query, int ListType, string connectionString = "Data Source=DESKTOP-KL9U024; Initial Catalog=SklepMuzycznyV2;Integrated Security=SSPI")
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Grid.DataSource = dt;
                if (ListType == 1)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow x = dt.Rows[i];
                        NowaListaTowarow.Add(new MojTowar(x.Field<Int32>(0), x.Field<string>(1), x.Field<decimal>(2)));
                        comboBox1.Items.Add(NowaListaTowarow[i].Nazwa);
                    }
                }
            }
        }
        private void aktualizujGrida()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = (Rachunek);
            //dataGridView1.Columns[0].Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CenaTB.Text = (numericUpDown1.Value * NowaListaTowarow[comboBox1.SelectedIndex].Cena).ToString() + " Zł";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex>-1)
            CenaTB.Text = (numericUpDown1.Value * NowaListaTowarow[comboBox1.SelectedIndex].Cena).ToString() + " Zł";
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 && numericUpDown1.Value > 0)
            {
                NowaListaTowarow[comboBox1.SelectedIndex].IloscTowaru = (int)numericUpDown1.Value;
                try
                {
                    Rachunek.Find(x => x.Nazwa.Equals(comboBox1.Items[comboBox1.SelectedIndex].ToString())).IloscTowaru = (int)numericUpDown1.Value;
                }
                catch
                {
                    Rachunek.Add(NowaListaTowarow[comboBox1.SelectedIndex]);
                }
                aktualizujGrida();
            }
        }

        private void Cofnij_Click(object sender, EventArgs e)
        {
            if (Rachunek.Count > 0)
            {
                Rachunek.RemoveAt(Rachunek.Count - 1);
                aktualizujGrida();
            }
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
    class MojTowar
    {
        public MojTowar(int _id, string _nazwa, decimal cena )
        {
            ID = _id;
            Nazwa = _nazwa;
            Cena = Convert.ToDecimal(cena.ToString());//.Substring(0, cena.ToString().Length-2));
        }
        public int ID { get; private set; }
        public string Nazwa { get; private set; }
        public decimal Cena { get; private set; }
        public int IloscTowaru { get; set; }
    }
}
