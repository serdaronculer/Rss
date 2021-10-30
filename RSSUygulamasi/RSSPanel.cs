using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace RSSUygulamasi
{
    public partial class RSSPanel : Form
    {
        public RSSPanel()
        {
            InitializeComponent();
            listBox2.HorizontalScrollbar = true;
           
        }
        SqlConnection conn = csSqlConnection.baglanti();
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        List<RssKanal> KanalListe;
        frmRssEkle frmRssEkle;
        frmRssSil frmRssSil;

        private void RSSPanel_Load(object sender, EventArgs e)
        {

            //ımageList1.ImageSize = new Size(30, 30);
            //WebClient w = new WebClient();
            //byte[] veri = w.DownloadData("https://isbh.tmgrup.com.tr/sbh/v5/i/logoBig.png");
            //MemoryStream stream = new MemoryStream(veri);
            //Image im = Image.FromStream(stream);
            //ımageList1.Images.Add(im);
            //listView1.Items.Add("test", 0);
            //listView1.LargeImageList = ımageList1;

            listeyiDoldur();   // Veritabanında ki Rss adreslerini <RssKanal> KanalListe listesine doldur
            listele();        // Listbox1 içerisine Kanal Listelerini ekle.

       

        }

       private void listele()
        {
            List<RssKanalBilgi> liste = XmlCevir();
            listBox1.DisplayMember = "kanalAdi";

            foreach (var item in liste)
            {

                listBox1.Items.Add(item);

            }
        }

        private void RSSPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(Form1)).FirstOrDefault();       
            form.Close();
        }

        public void listeyiDoldur()
        {
            conn.Open();
            komut = new SqlCommand("select * from Kanallars", conn);
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            KanalListe = dt.AsEnumerable().Select(x => new RssKanal()
            {
                id = Convert.ToInt32(x["id"]),
                rssAdi = x["kanalAdi"].ToString()
            }
            ).ToList();
        }


         List<RssKanalBilgi> XmlCevir()
        {
           
            List<XElement> rows = null;
            List<XElement> rows2 = null;
            List<RssKanalBilgi> liste = new List<RssKanalBilgi>();
            foreach (var item in KanalListe)
            {
                RssKanalBilgi kanalBilgi = new RssKanalBilgi();
                XDocument XMLKaynak = XDocument.Load(item.rssAdi);

                rows = XMLKaynak.Descendants("channel").ToList();
                rows2 = XMLKaynak.Descendants("item").ToList();

                foreach (var item2 in rows2)
                {
                    RssKanalIcerik icerik = new RssKanalIcerik();
                    icerik.baslik = item2.Element("title").Value.ToString();
                    icerik.link = item2.Element("link").Value.ToString();
                    icerik.aciklama = item2.Element("description").Value.ToString();

                    foreach (var item3 in rows)
                    {
                        kanalBilgi.kanalAdi= item3.Element("title").Value.ToString();
                        icerik.kanalAdi= item3.Element("title").Value.ToString();
                    }
                    kanalBilgi.ekle(icerik);
                }
                liste.Add(kanalBilgi);
            }
            return liste;
           
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            RssKanalBilgi kanallar = new RssKanalBilgi();
            kanallar = listBox1.SelectedItem as RssKanalBilgi;
            List<RssKanalIcerik> listesi = kanallar.kanalIcerigi;
           
            foreach (var item in listesi)
            {
                listBox2.Items.Add(item);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            IcerikVer();
        }

        private void IcerikVer()
        {
            RssKanalIcerik kanalIcerik = new RssKanalIcerik();
            kanalIcerik = listBox2.SelectedItem as RssKanalIcerik;
            string baslik = string.Format($"<p style='color:red; font-size:36px'>{kanalIcerik.baslik}</p>\n");
            string link = string.Format($"<a href={kanalIcerik.link}>Devamını okumak için...");
            webBrowser1.DocumentText = string.Format(baslik+"<br>" + kanalIcerik.aciklama+ "<br><br>" + link);
        }

        private void rSSEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRssEkle = new frmRssEkle();
            frmRssEkle.ShowDialog();
        }

        private void rSSSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRssSil = new frmRssSil();
            frmRssSil.ShowDialog();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listeyiDoldur();   
            listele();
        }
    }
}
