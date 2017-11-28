using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class ProfileImageMap : EntityTypeConfiguration<ProfileImage>
    {
        public ProfileImageMap()
        {
            this.ToTable("tbl_New_Profile_Image");

            this.HasKey(t => t.Id);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ProfileID);
            this.Property(t => t.PicName).HasColumnName("Pic_Name");
            this.Property(t => t.IsActive);

            // Relationships
            this.HasRequired(t => t.Profile)
                .WithMany(t => t.ProfileImages)
                .HasForeignKey(d => d.ProfileID);
        }
    }
}
