using RSSUygulamasi.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RSSUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        SqlConnection conn = csSqlConnection.baglanti();
      
        RSSPanel rssform = new RSSPanel();


        private void btnVeritabaniBagla_Click(object sender, EventArgs e)
        {
            try
            {   
                {
                    using (RSSDbContext context = new RSSDbContext())
                    {
                        context.Database.Create();

                    }
                    MessageBox.Show("Veri tabanı başarıyla oluşturuldu", "Veri Tabanı Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
          
            catch (Exception ex)
            {
                MessageBox.Show("Böyle bir veritabanı mevcut\n" + ex.Message);

            }
            
        }
        
       

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                conn.Close();
                rssform.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
