﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class ReligionMap : EntityTypeConfiguration<Religion>
    {
        public ReligionMap()
        {
            ToTable("tblReligions");
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            Property(t => t.ReligionName).HasColumnName("Religion");
            Property(t => t.IsActive);
        }
    }
}