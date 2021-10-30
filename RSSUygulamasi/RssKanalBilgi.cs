using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSUygulamasi
{
     class RssKanalBilgi
    {
        public  string kanalAdi { get; set; }

      public  List<RssKanalIcerik> kanalIcerigi = new List<RssKanalIcerik>();

        public void ekle(RssKanalIcerik icerigi)
        {
            kanalIcerigi.Add(icerigi);
        }
    }
}
