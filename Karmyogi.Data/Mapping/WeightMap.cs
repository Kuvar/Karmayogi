using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class WeightMap : EntityTypeConfiguration<Weight>
    {
        public WeightMap()
        {
            this.ToTable("tblWeight");

            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.WeightText)
                .HasColumnName("Weight");
        }
    }
}
