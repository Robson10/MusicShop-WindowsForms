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
    public partial class DodajWykonawce : Form
    {
        public DodajWykonawce()
        {
            InitializeComponent();
            Dictionary.DesignButton(Anuluj);
            Dictionary.DesignButton(Dodaj);
            this.BackColor = Dictionary.BackColor;
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            Dictionary.InsertData("insert into SklepMuzycznyV2.dbo.Wykonawca(Wy_Imie, Wy_Nazwisko) values('"+ImieTB.Text+"','"+NazwiskoTB.Text+"')","Wykonawca");
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
