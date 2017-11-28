using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class ReligiousAndAstroBackgroundMap : EntityTypeConfiguration<ReligiousAndAstroBackground>
    {
        public ReligiousAndAstroBackgroundMap()
        {
            this.ToTable("tbl_New_Religious_and_Astro_Background");

            this.HasKey(t => t.Profile_Id);

            this.Property(t => t.Profile_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            this.Property(t => t.Time_of_Birth);
            this.Property(t => t.Religion_Id);
            this.Property(t => t.Caste_Id);
            this.Property(t => t.Date_of_Birth);
            this.Property(t => t.Raasi);
            this.Property(t => t.Place_of_Birth);

            // Relationships
            this.HasRequired(t => t.BasicsAndLifestyle)
                .WithOptional(t => t.ReligiousAndAstroBackground);

            this.HasRequired(t => t.Caste)
                .WithMany(t => t.ReligiousAndAstroBackgrounds)
                .HasForeignKey(d => d.Caste_Id);

            this.HasRequired(t => t.Religion)
                .WithMany(t => t.ReligiousAndAstroBackgrounds)
                .HasForeignKey(d => d.Religion_Id);
        }
    }
}
