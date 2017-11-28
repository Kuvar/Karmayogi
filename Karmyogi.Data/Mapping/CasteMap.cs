using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class CasteMap : EntityTypeConfiguration<Caste>
    {
        public CasteMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            Property(t => t.CasteName).HasColumnName("Caste");
            Property(t => t.Religion_Id);
            Property(t => t.IsActive);

            ToTable("tblCaste");

            // Relationships
            this.HasRequired(t => t.Religion)
                .WithMany(t => t.Castes)
                .HasForeignKey(d => d.Religion_Id);

            this.HasRequired(t => t.Status)
                .WithMany(t => t.Castes)
                .HasForeignKey(d => d.IsActive);
        }
    }
}
