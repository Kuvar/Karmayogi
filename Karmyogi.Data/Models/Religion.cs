using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class Religion
    {
        public Religion()
        {
            this.Castes = new HashSet<Caste>();
            this.Users = new HashSet<User>();
            this.PartnerPreferences = new HashSet<PartnerPreference>();
        }

        [Key]
        public int Id { get; set; }
        public string ReligionName { get; set; }
        public int? IsActive { get; set; }

        [ForeignKey("IsActive")]
        public virtual Status Status { get; set; }

        public virtual ICollection<Caste> Castes { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }       
    }
}
