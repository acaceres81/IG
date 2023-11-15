using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace cookpad.Models
{
    internal class BotoaDBContext : DbContext
    {
        public BotoaDBContext() : base(nameOrConnectionString: "BotoaDBContext")
        { }
        public DbSet<Errezeta> Errezeta { get; set; }
        public DbSet<Erabiltzailea> Erabiltzailea { get; set; }
        public DbSet<Botoa> Botoa { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
