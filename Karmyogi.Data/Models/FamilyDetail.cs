using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class FamilyDetail
    {
        [Key, ForeignKey("BasicsAndLifestyle")]
        public int Profile_Id { get; set; }
        public string Fathers_Occupation { get; set; }
        public string Mothers_Occupation { get; set; }
        public int? No_of_Brothers { get; set; }
        public int? No_of_Sisters { get; set; }

        [Required]
        public virtual BasicsAndLifestyle BasicsAndLifestyle { get; set; }
    }
}
