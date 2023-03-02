using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext(): base("Asp_Net_MVS_CS") { }

        public DbSet<Categoria>Categorias { get; set; }
        public DbSet<Fabricante> Fabicates { get; set; }
    }
}