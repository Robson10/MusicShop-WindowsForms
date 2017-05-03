using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesktopSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = Dictionary.Dc_borderStyle;
            this.Text = "Logowanie";
            LoginTB.Text = "Bartosz";
            PasswordTB.Text = "Gronostaj";
            this.BackColor = Dictionary.BackColor;
            label1.ForeColor = Dictionary.ForeColor;
            label2.ForeColor = Dictionary.ForeColor;

            Zaloguj.BackColor = Dictionary.ButtonBackColor;
            Zaloguj.ForeColor = Dictionary.ForeColor;
            Exit.BackColor = Dictionary.ButtonBackColor;
            Exit.ForeColor = Dictionary.ForeColor;
            string query = "select Klienci.Kl_ID, Klienci.Kl_Imie,Klienci.Kl_Pesel from SklepMuzycznyV2.dbo.Klienci";
            string query2 = "select Pracownicy.Pr_ID,Pracownicy.Pr_Imie,Pracownicy.Pr_Nazwisko from SklepMuzycznyV2.dbo.Pracownicy";
            BaseOperation(query,query2);
        }
        List<Klienci> klienci = new List<Klienci>();
        List<Pracownicy> pracownicy = new List<Pracownicy>();
        private void BaseOperation(string query,string query2, string connectionString = "Data Source=DESKTOP-KL9U024; Initial Catalog=SklepMuzycznyV2;Integrated Security=SSPI")
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow x = dt.Rows[i];
                    klienci.Add(new Klienci() { Kl_ID = x.Field<Int32>(0), Kl_Imie = x.Field<string>(1), Kl_Pesel = x.Field<string>(2) });
                }
            }
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query2, sqlConn))
            {
                sqlConn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow x = dt.Rows[i];
                    pracownicy.Add(new Pracownicy() { Pr_ID = x.Field<Int32>(0), Pr_Imie = x.Field<string>(1), Pr_Nazwisko= x.Field<string>(2) });
                }
            }
        }
        private void Zaloguj_Click(object sender, EventArgs e)
        {

            if (LoginTB.Text.Equals("Admin") && PasswordTB.Text.Equals("123"))
                LogAsAdmin();
            else if (LoginTB.Text.Equals("Kierownik") && PasswordTB.Text.Equals("123"))
                LogAsBoss();
            else if (LogAsEmployee()) { }
            else if (LogAsClient()) { }
            else
                MessageBox.Show("Błędne dane. Spróbuj ponownie.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogAsAdmin()
        {
            Administrator.AdminForm AdminWindow = new Administrator.AdminForm();
            this.Hide();
            if (AdminWindow.ShowDialog() == DialogResult.OK)
            {
                LoginTB.Text = "";
                PasswordTB.Text = "";
                this.Show();
            }
        }
        private void LogAsBoss()
        {
            Kierownik.KierownikForm KierownikWindow = new Kierownik.KierownikForm();
            this.Hide();
            if (KierownikWindow.ShowDialog() == DialogResult.OK)
            {
                LoginTB.Text = "";
                PasswordTB.Text = "";
                this.Show();
            }
        }
        private bool LogAsEmployee()
        {
            for (int i = 0; i < pracownicy.Count; i++)
            {
                if (pracownicy[i].Pr_Imie.Equals(LoginTB.Text) && pracownicy[i].Pr_Nazwisko.Equals(PasswordTB.Text))
                {
                    Pracownik.PracownikForm PracownikWindow = new Pracownik.PracownikForm(pracownicy[i]);
                    this.Hide();
                    if (PracownikWindow.ShowDialog() == DialogResult.OK)
                    {
                        LoginTB.Text = "";
                        PasswordTB.Text = "";
                        this.Show();
                    }
                    return true;
                }
            }
            return false;            
        }
        private bool LogAsClient()
        {
            for (int i = 0; i < klienci.Count; i++)
            {
                if (klienci[i].Kl_Imie.Equals(LoginTB.Text) && klienci[i].Kl_Pesel.Equals(PasswordTB.Text))
                {
                    Klient.KlientForm KlientWindow = new Klient.KlientForm(klienci[i]);
                    this.Hide();
                    if (KlientWindow.ShowDialog() == DialogResult.OK)
                    {
                        LoginTB.Text = "";
                        PasswordTB.Text = "";
                        this.Show();
                    }
                    return true;
                }
            }
            return false;
        }
    }
 }
