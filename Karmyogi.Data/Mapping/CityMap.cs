using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("tblCity");

            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            Property(t => t.CityName).HasColumnName("City");
            Property(t => t.CountryId);
            Property(t => t.StateId);
            Property(t => t.IsActive);

            // Relationships
            this.HasRequired(t => t.State)
                .WithMany(t => t.Cities)
                .HasForeignKey(d => d.StateId)
                .WillCascadeOnDelete(false);

            this.HasRequired(t => t.Country)
                .WithMany(t => t.Cities)
                .HasForeignKey(d => d.CountryId)
                .WillCascadeOnDelete(false);

            this.HasRequired(t => t.Status)
                .WithMany(t => t.Cities)
                .HasForeignKey(d => d.IsActive)
                .WillCascadeOnDelete(false);
        }
    }
}
