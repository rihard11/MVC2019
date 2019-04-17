using AdresarAdresarWcfService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdresarWcfService.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("AdresarBaza")
        {
        }

        public virtual DbSet<Kontakt> Kontakti { get; set; }
    }
}