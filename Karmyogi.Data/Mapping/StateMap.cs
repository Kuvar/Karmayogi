using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            ToTable("tblState");

            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            //Property(t => t.StateName).HasColumnName("State");
            //Property(t => t.CountryId).HasColumnName("Country_Id");
            //Property(t => t.IsActive);

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.States)
                .HasForeignKey(d => d.CountryId)
                .WillCascadeOnDelete(false);


            this.HasRequired(t => t.Status)
                .WithMany(t => t.States)
                .HasForeignKey(d => d.IsActive);
        }
    }
}
