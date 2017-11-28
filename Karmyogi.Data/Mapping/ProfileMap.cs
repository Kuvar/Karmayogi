using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class ProfileMap : EntityTypeConfiguration<Profile>
    {
        public ProfileMap()
        {
            //One-To-One Relation
            this.HasOptional(t => t.PartnerPreference)
                .WithRequired(t => t.Profile);

            //One-To-Many Relation
            this.HasRequired(t => t.Caste)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.Caste_Id);

            this.HasRequired(t => t.City)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.LiveInCityId);

            this.HasRequired(t => t.LastDegree)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.Last_Degree_Id);

            this.HasRequired(t => t.Profession)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.Occupation_Id);

            this.HasRequired(t => t.MotherTongue)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.Mother_TongueId);

            this.HasRequired(t => t.State)
               .WithMany(t => t.Profiles)
               .HasForeignKey(t => t.LiveInStateId);

            this.HasRequired(t => t.Role)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.UserInRole);

            this.HasRequired(t => t.Religion)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.Religion_Id);

            this.HasRequired(t => t.BornInCountry)
                .WithMany(t => t.ProfileBornIn)
                .HasForeignKey(t => t.BornInCountryId);

            this.HasRequired(t => t.GrewInCountry)
                .WithMany(t => t.ProfileGrewIn)
                .HasForeignKey(t => t.GrewInCountryId);

            this.HasRequired(t => t.LiveInCountry)
                .WithMany(t => t.ProfileLiveIn)
                .HasForeignKey(t => t.LiveInCountryId);

            this.HasRequired(t => t.Nationality)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.NationalityId);

            this.HasRequired(t => t.Height)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.HeightId);

            this.HasRequired(t => t.Weight)
                .WithMany(t => t.Profiles)
                .HasForeignKey(t => t.WeightId);

            // Many-To-Many Relation
            this.HasMany(e => e.ProfilesViewedBy)
                .WithRequired(e => e.ProfileViewedBy)
                .HasForeignKey(e => e.ViewedById)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.ProfilesViewedToWhom)
                .WithRequired(e => e.ProfileViewedToWhom)
                .HasForeignKey(e => e.ViewedToWhomId)
                .WillCascadeOnDelete(false);

        }
    }
}
