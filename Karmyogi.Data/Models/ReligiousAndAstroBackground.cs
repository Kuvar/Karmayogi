using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class ReligiousAndAstroBackground
    {
        [Key, ForeignKey("BasicsAndLifestyle")]
        public int Profile_Id { get; set; }
        public TimeSpan? Time_of_Birth { get; set; }
        public int? Religion_Id { get; set; }
        public int? Caste_Id { get; set; }
        public DateTime? Date_of_Birth { get; set; }
        public string Raasi { get; set; }
        public string Place_of_Birth { get; set; }

        public virtual BasicsAndLifestyle BasicsAndLifestyle { get; set; }

        [ForeignKey("Caste_Id")]
        public virtual Caste Caste { get; set; }

        [ForeignKey("Religion_Id")]
        public virtual Religion Religion { get; set; }
    }
}
