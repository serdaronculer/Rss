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
    public partial class frmRssSil : Form
    {
        public frmRssSil()
        {
            InitializeComponent();
        }
        SqlConnection conn = csSqlConnection.baglanti();
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;

        private void frmRssSil_Load(object sender, EventArgs e)
        {
            kayitlariGetir();
        }

        private void kayitlariGetir()
        {
            if (conn.State == ConnectionState.Closed)
            {

                try
                {
                    conn.Open();
                    komut = new SqlCommand("select id,kanalAdi as [Kanal Adı] from Kanallars",conn);
                    da = new SqlDataAdapter(komut);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgwRss.DataSource = dt;

                

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

       

        private void dgwRss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sil();
        }

        private void sil()
        {
            try
            {
                int id = Convert.ToInt32(dgwRss.CurrentRow.Cells[0].Value);

                if (conn.State == ConnectionState.Closed)   
                    komut = new SqlCommand("delete Kanallars where id=@id", conn);
                    komut.Parameters.AddWithValue("id", id);
                    conn.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Rss silme işlemi başarılı");
                   
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
               
            }
            finally
            {
                conn.Close();
                Form form = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(RSSPanel)).FirstOrDefault();
                form.Refresh();

                RSSPanel frm = new RSSPanel();
                
            }
            
        }

        private void frmRssSil_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
