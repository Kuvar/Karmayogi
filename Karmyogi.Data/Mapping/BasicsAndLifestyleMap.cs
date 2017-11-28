using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class BasicsAndLifestyleMap : EntityTypeConfiguration<BasicsAndLifestyle>
    {
        public BasicsAndLifestyleMap()
        {
            this.ToTable("tbl_New_Basics_And_Lifestyle");

            //Prikary Key
            this.HasKey(t => t.Profile_Id);

            //Property
            this.Property(t => t.Profile_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.F_Name);
            this.Property(t => t.M_Name);
            this.Property(t => t.L_Name);
            this.Property(t => t.Marital_Status);
            this.Property(t => t.Mother_TongueId);
            this.Property(t => t.Body_Type);
            this.Property(t => t.Complexion);
            this.Property(t => t.WeightId);
            this.Property(t => t.HeightId);
            this.Property(t => t.Blood_Group);
            this.Property(t => t.Physical_Status);
            this.Property(t => t.Diet);
            this.Property(t => t.Smoke);
            this.Property(t => t.Drink);
            this.Property(t => t.Gender);
            this.Property(t => t.Created_Date);
            this.Property(t => t.IsActive);

            this.HasRequired(c => c.EducationAndCareer).WithRequiredPrincipal(c => c.BasicsAndLifestyle);

            this.HasRequired(t => t.Height)
                .WithMany(t => t.BasicsAndLifestyles)
                .HasForeignKey(t => t.HeightId);

            this.HasRequired(t => t.Weight)
                .WithMany(t => t.BasicsAndLifestyles)
                .HasForeignKey(t => t.WeightId);

            this.HasRequired(t => t.MotherTongue)
                .WithMany(t => t.BasicsAndLifestyles)
                .HasForeignKey(t => t.Mother_TongueId);

            this.HasRequired(t => t.Nationality)
                .WithMany(t => t.BasicsAndLifestyles)
                .HasForeignKey(t => t.NationalityId);

            this.HasRequired(t => t.LiveInCountry)
                .WithMany(t => t.BasicsAndLifeStyleLiveIn)
                .HasForeignKey(t => t.LiveInCountryId);

            this.HasRequired(t => t.BornInCountry)
                .WithMany(t => t.BasicsAndLifeStyleBornIn)
                .HasForeignKey(t => t.BornInCountryId);

            this.HasRequired(t => t.GrewInCountry)
                .WithMany(t => t.BasicsAndLifeStyleGrewIn)
                .HasForeignKey(t => t.GrewInCountryId);

            this.HasRequired(t => t.LiveInState)
                .WithMany(t => t.BasicsAndLifestyles)
                .HasForeignKey(t => t.LiveInStateId);

            this.HasRequired(t => t.LiveInCity)
                .WithMany(t => t.BasicsAndLifestyles)
                .HasForeignKey(t => t.LiveInCityId);

        }
    }
}
