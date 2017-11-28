using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class EducationAndCareerMap : EntityTypeConfiguration<EducationAndCareer>
    {
        public EducationAndCareerMap()
        {
            this.ToTable("tbl_New_Education_and_Career");

            this.HasKey(t => t.Profile_Id);

            this.Property(t => t.Profile_Id);

            this.Property(t => t.Last_Degree_Id);
            this.Property(t => t.Occupation_Id);
            this.Property(t => t.Annual_Income);

            // Relationships

            this.HasRequired(t => t.LastDegree)
                .WithMany(t => t.EducationAndCareers)
                .HasForeignKey(d => d.Last_Degree_Id);

            this.HasRequired(t => t.Profession)
                .WithMany(t => t.EducationAndCareers)
                .HasForeignKey(d => d.Occupation_Id);
        }
    }
}
