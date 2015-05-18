using ProjectAll_Infrastructure_EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAll_Infrastructure_EntityFramework
{
    public class dbContext : DbContext
    {
        static dbContext()
        {
            Database.SetInitializer<dbContext>(null);
        }
        public dbContext()
            : base("TapMenuContext")
        {

        }

        public DbSet<categorias> TB_Categorias();
        public DbSet<produtos> TB_Produtos();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add();
        }
    }
}
