using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Karmyogi.Data
{
    [Serializable]
    public class Height
    {
        public Height()
        {
            this.Users = new HashSet<User>();
            this.PartnerPreferences = new HashSet<PartnerPreference>();                                                                                                                                                                                                                                                                         
        }

        [Key]
        public int Id { get; set; }
        public string HeightText { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
