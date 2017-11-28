using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Karmyogi.Data
{
    [Serializable]
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
            this.Profiles = new HashSet<Profile>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
