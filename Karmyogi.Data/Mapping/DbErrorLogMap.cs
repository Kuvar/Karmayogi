using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class DbErrorLogMap : EntityTypeConfiguration<DbErrorLog>
    {
        public DbErrorLogMap()
        {
            this.ToTable("tblDbErrorLog");

            this.HasKey(t => t.DbErrorId);

            this.Property(t => t.DbErrorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DbErrorNumber);

            this.Property(t => t.DbErrorMsg);

            this.Property(t => t.DbErrorDate);

            this.Property(t => t.DbErrorLocation);
        }
    }
}
