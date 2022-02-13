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

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=NORTHWND;Trusted_Connection=True;");
        DataSet ds = new DataSet();
        DataTable dt;
        SqlDataAdapter adp;
        private void Form1_Load(object sender, EventArgs e)
        {
            CalisanlariGetir();
        }
        private void CalisanlariGetir()
        {
            adp = new SqlDataAdapter("select EmployeeID, FirstName, LastName from Employees", baglanti);
            dt = new DataTable();
            adp.Fill(dt);
            ds.Tables.Add(dt);
            dgvListe.DataSource = ds.Tables[0];
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonelAdi.Text != "" && txtPersonelSoyadi.Text != "")
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].Rows.Count + 1, txtPersonelAdi.Text, txtPersonelSoyadi.Text);
                dgvListe.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Çalışan İsim ve Soyisim Bilgilerini Girmelisiniz!");
            }
        }

        private void btnDByeKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelAdi.Text != "" && txtPersonelSoyadi.Text != "")
            {
                adp = new SqlDataAdapter("Insert Into Employees (FirstName,LastName) Values(@eName,@eLastName)", baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@eName", txtPersonelAdi.Text);
                adp.SelectCommand.Parameters.AddWithValue("@eLastName", txtPersonelSoyadi.Text);

                dt = new DataTable();
                adp.Fill(dt);
                ds.Tables.Add(dt);
                dgvListe.DataSource = ds.Tables[0];

                CalisanlariGetir();
            }
            else
            {
                MessageBox.Show("Çalışan İsim ve Soyisim Bilgilerini Girmelisiniz!");
            }
        }
    }
}
