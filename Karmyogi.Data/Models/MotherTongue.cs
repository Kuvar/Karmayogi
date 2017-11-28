using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class MotherTongue
    {
        public MotherTongue()
        {
            this.PartnerPreferences = new HashSet<PartnerPreference>();
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        public string Language { get; set; }
        public int? IsActive { get; set; }

        [ForeignKey("IsActive")]
        public virtual Status Status { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }
        
    }
}
