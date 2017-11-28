using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class NationalityMap : EntityTypeConfiguration<Nationality>
    {
        public NationalityMap()
        {
            this.ToTable("tblNationality");

            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.NationalityName);
        }
    }
}
