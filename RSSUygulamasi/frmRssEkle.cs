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

namespace RSSUygulamasi
{
    public partial class frmRssEkle : Form
    {
        public frmRssEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = csSqlConnection.baglanti();
        SqlCommand komut;
       

        private void btnRssEkle_Click(object sender, EventArgs e)
        {
        
            try
            {
                if (conn.State==ConnectionState.Closed)

                    if (!string.IsNullOrEmpty(txtRssEkle.Text))
                    
                        conn.Open();
                        komut = new SqlCommand("insert into Kanallars (kanalAdi) values (@kanalAdi)", conn);
                        komut.Parameters.AddWithValue("kanalAdi", txtRssEkle.Text);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Rss ekleme işlemi başarılı");
                        txtRssEkle.Text = string.Empty;
                               
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
            finally
            {
                conn.Close();
                
            }
        }
    }
}
