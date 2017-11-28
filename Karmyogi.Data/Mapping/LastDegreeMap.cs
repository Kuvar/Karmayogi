using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class LastDegreeMap : EntityTypeConfiguration<LastDegree>
    {
        public LastDegreeMap()
        {
            this.ToTable("tblLastDegree");

            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.LastDegreeName);
        }
    }
}
