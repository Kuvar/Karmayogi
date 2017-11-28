using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class EducationAndCareer
    {
        [Key, ForeignKey("BasicsAndLifestyle")]
        public int Profile_Id { get; set; }
        public int? Last_Degree_Id { get; set; }
        public int? Occupation_Id { get; set; }
        public string Annual_Income { get; set; }

        public virtual BasicsAndLifestyle BasicsAndLifestyle { get; set; }

        [ForeignKey("Last_Degree_Id")]
        public virtual LastDegree LastDegree { get; set; }

        [ForeignKey("Occupation_Id")]
        public virtual Profession Profession { get; set; }
    }
}
