using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class PartnerPreferenceMap : EntityTypeConfiguration<PartnerPreference>
    {
        public PartnerPreferenceMap()
        {

            this.Property(t => t.From_Age);
            this.Property(t => t.To_Age);
            this.Property(t => t.Marital_Status);
            this.Property(t => t.Body_Type);
            this.Property(t => t.Complexion);
            this.Property(t => t.HeightId);
            this.Property(t => t.Diet);
            this.Property(t => t.IsManglik);
            this.Property(t => t.Religion_Id);
            this.Property(t => t.Caste_Id);
            this.Property(t => t.Mother_Tongue_Id);
            this.Property(t => t.Last_Degree_Id);
            this.Property(t => t.Occupation_Id);
            this.Property(t => t.Country_of_Residence_Id);
            this.Property(t => t.State_Id);


            this.HasRequired(t => t.Caste)
                .WithMany(t => t.PartnerPreferences)
                .HasForeignKey(d => d.Caste_Id);

            this.HasRequired(t => t.Country)
                .WithMany(t => t.PartnerPreferences)
                .HasForeignKey(d => d.Country_of_Residence_Id);

            this.HasRequired(t => t.Height)
                    .WithMany(t => t.PartnerPreferences)
                    .HasForeignKey(d => d.HeightId);

            this.HasRequired(t => t.LastDegree)
                .WithMany(t => t.PartnerPreferences)
                .HasForeignKey(d => d.Last_Degree_Id);

            this.HasRequired(t => t.MotherTongue)
                .WithMany(t => t.PartnerPreferences)
                .HasForeignKey(d => d.Mother_Tongue_Id);


            this.HasRequired(t => t.Profession)
                    .WithMany(t => t.PartnerPreferences)
                    .HasForeignKey(d => d.Occupation_Id);

            this.HasRequired(t => t.Religion)
                .WithMany(t => t.PartnerPreferences)
                .HasForeignKey(d => d.Religion_Id);

            this.HasRequired(t => t.State)
                .WithMany(t => t.PartnerPreferences)
                .HasForeignKey(d => d.State_Id);
        }
    }
}
