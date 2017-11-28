using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class ProfileImage
    {
        public int Id { get; set; }

        [Column("Profile_Id")]
        public int? ProfileID { get; set; } 
        public string PicName { get; set; }
        public bool? IsActive { get; set; }

        [ForeignKey("ProfileID")]
        public virtual Profile Profile { get; set; }
    }
}
