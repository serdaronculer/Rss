using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSUygulamasi.context
{
    class RSSDbContext:DbContext
    {
        public DbSet<Kanallar> Kanallar { get; set; }
        public DbSet<VeriTabaniBilgisi> VeritabanBilgisi { get; set; }
    }
}
