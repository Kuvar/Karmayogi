using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class ProfessionMap : EntityTypeConfiguration<Profession>
    {
        public ProfessionMap()
        {
            this.ToTable("tblProfession");

            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ProfessionName).HasColumnName("Profession");
        }
    }
}
