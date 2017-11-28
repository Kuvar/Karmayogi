using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class ChildrenMap : EntityTypeConfiguration<Children>
    {
        public ChildrenMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            Property(t => t.ChildrenType).HasColumnName("Children");
            ToTable("tblChildren");
        }
    }
}
