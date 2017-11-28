using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Karmyogi.Data
{
    [Serializable]
    public class Weight
    {
        public Weight()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        public string WeightText { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
