using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfOracleCodeFirstConsole
{
    public class OracleDbContext : DbContext
    {
        public virtual DbSet<Page> PageEntities { get; set; }
        public virtual DbSet<User> UserEntities { get; set; }
        public virtual DbSet<UserGroup> UserGroupEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TEST");

            base.OnModelCreating(modelBuilder);
        }
    }
}
