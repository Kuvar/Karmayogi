using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Karmyogi.Data
{
    [Serializable]
    public class Profession
    {
        public Profession()
        {
            this.PartnerPreferences = new HashSet<PartnerPreference>();
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        public string ProfessionName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }       
    }
}
