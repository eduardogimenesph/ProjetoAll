using ProjectAll_Infrastructure_EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAll_Infrastructure_EntityFramework.Mapping
{
    public class TB_CategoriaMap : EntityTypeConfiguration<categorias>
    {
        public TB_CategoriaMap()
        {
            this.HasKey(t => t.idCategoria);

            this.Property(t => t.nomeCategoria).HasMaxLength(200);


            this.ToTable("categorias");
            this.Property(t => t.idCategoria).HasColumnName("idCategoria");
            this.Property(t => t.nomeCategoria).HasColumnName("nomeCategoria");
        }
    }
}
