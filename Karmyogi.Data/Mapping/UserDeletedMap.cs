using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class UserDeletedMap : EntityTypeConfiguration<UserDeleted>
    {
        public UserDeletedMap()
        {
            this.ToTable("tblUserDelete");

            this.HasKey(t => new { t.DelId, t.fk_User_ID });

            this.Property(t => t.DelId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.fk_User_ID);
            this.Property(t => t.DeletedDate);
            this.Property(t => t.DeletedReason);
            this.Property(t => t.DeletedBy);
            this.Property(t => t.ActivatedBy);
            this.Property(t => t.ActivatedDate);
            this.Property(t => t.IsActive);
            this.Property(t => t.IsDeleted);

            // Relationships
            //this.HasRequired(t => t.User)
            //    .WithMany(t => t.UserDeletes)
            //    .HasForeignKey(d => d.fk_User_ID)
            //    .WillCascadeOnDelete(false);
        }
    }
}
