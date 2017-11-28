using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("tblCountry");
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            Property(t => t.Country_nm).IsUnicode(false);
            Property(t => t.IsActive);

            this.HasRequired(t => t.Status)
                .WithMany(t => t.Countries)
                .HasForeignKey(d => d.IsActive);
        }
    }
}
