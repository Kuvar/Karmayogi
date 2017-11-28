using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class LastDegree
    {
        public LastDegree()
        {
            this.PartnerPreferences = new HashSet<PartnerPreference>();
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Column("Last_degree")]
        public string LastDegreeName { get; set; }

        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
