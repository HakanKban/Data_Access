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

namespace ConnectedMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server = .\\SQLEXPRESS; Database = NORTHWND; Trusted_Connection = True;");
        SqlCommand command;

   

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunGuncelle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            UrunSil();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            UrunAra();
        }
        void UrunEkle()
        {
            try
            {
                ConnectionControl();
                command = new SqlCommand("insert into products(ProductName,UnitPrice,UnitsInStock,Discontinued) Values(@PName,@Price,@Stock,0)", connection);
                command.Parameters.AddWithValue("@PName", txtUrunAdiEkle.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtFiyatEkle.Text));
                command.Parameters.AddWithValue("@Stock", Convert.ToInt16(txtStokEkle.Text));
                command.ExecuteNonQuery();
                ConnectionControl();

                MessageBox.Show($"{txtUrunAdiEkle.Text} adlı ürün stoklara eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UrunListele();
        }
        void UrunGuncelle()
        {
            try
            {
                ConnectionControl();
                command = new SqlCommand("update products set UnitPrice=@Price,UnitsInStock=@Stock where Productname=@PName", connection);
                command.Parameters.AddWithValue("@PName", txtUrunAdiGuncelle.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtFiyatGuncelle.Text));
                command.Parameters.AddWithValue("@Stock", Convert.ToInt16(txtStokGuncelle.Text));
                command.ExecuteNonQuery();
                ConnectionControl();

                MessageBox.Show($"{txtUrunAdiGuncelle.Text} adlı ürün bilgileri güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UrunListele();
        }
        void UrunListele()
        {
            try
            {
                ConnectionControl();
                command = new SqlCommand("select ProductName,UnitPrice,UnitsInStock,ProductID from Products", connection);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    listView1.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem kayit = new ListViewItem();
                        kayit.Text = dr["ProductID"].ToString();
                        kayit.SubItems.Add(dr["ProductName"].ToString());
                        kayit.SubItems.Add(dr["UnitPrice"].ToString());
                        kayit.SubItems.Add(dr["UnitsInStock"].ToString());
                        listView1.Items.Add(kayit);
                    }
                }
                ConnectionControl();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void UrunSil()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int id = int.Parse(listView1.SelectedItems[0].Text);
                command = new SqlCommand("delete from Products where ProductID=@PId", connection);
                command.Parameters.AddWithValue("@PId", id);
                command.ExecuteNonQuery();

                MessageBox.Show($"ID numarası {id} olan ürün, ürün listesinden kaldırıldı.");
                ConnectionControl();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UrunListele();
        }

        void UrunAra()
        {
            try
            {
                ConnectionControl();

                string text = txtAra.Text;
                command = new SqlCommand($"select ProductID,ProductName,UnitPrice,UnitsInStock from Products where ProductName like '%{text}%'", connection);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    listView1.Items.Clear();
                    while (dr.Read())
                    {
                        ListViewItem kayit = new ListViewItem();
                        kayit.Text = dr["ProductID"].ToString();
                        kayit.SubItems.Add(dr["ProductName"].ToString());
                        kayit.SubItems.Add(dr["UnitPrice"].ToString());
                        kayit.SubItems.Add(dr["UnitsInStock"].ToString());
                        listView1.Items.Add(kayit);
                    }
                }
                ConnectionControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
                connection.Close();
        }

        void ConnectionClosee()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
