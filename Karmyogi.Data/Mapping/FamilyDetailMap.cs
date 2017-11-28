using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class FamilyDetailMap : EntityTypeConfiguration<FamilyDetail>
    {
        public FamilyDetailMap()
        {
            this.ToTable("tbl_New_Family_Details");

            this.HasKey(t => t.Profile_Id);

            this.Property(t => t.Profile_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Fathers_Occupation);
            this.Property(t => t.Mothers_Occupation);
            this.Property(t => t.No_of_Brothers);
            this.Property(t => t.No_of_Sisters);
            
            // Relationships
            this.HasRequired(t => t.BasicsAndLifestyle)
                .WithOptional(t => t.FamilyDetail);
        }
    }
}
