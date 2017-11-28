using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class MotherTongueMap : EntityTypeConfiguration<MotherTongue>
    {
        public MotherTongueMap()
        {
            this.ToTable("tblMother_Tongue");

            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Language);
            this.Property(t => t.IsActive);

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.MotherTongues)
                .HasForeignKey(d => d.IsActive);
        }
    }
}
