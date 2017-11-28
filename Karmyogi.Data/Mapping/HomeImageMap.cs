using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class HomeImageMap : EntityTypeConfiguration<HomeImage>
    {
        public HomeImageMap()
        {
            this.ToTable("tblHomeImage");

            this.HasKey(t => new { t.Id, t.CreatedBy });

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ImgName);
            this.Property(t => t.ImgUrl);
            this.Property(t => t.IsActive);
            this.Property(t => t.CreatedBy);
            this.Property(t => t.CreatedDate);

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.HomeImages)
                .HasForeignKey(d => d.CreatedBy)
                .WillCascadeOnDelete(false);
        }
    }
}
