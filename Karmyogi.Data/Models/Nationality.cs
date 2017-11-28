using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class Nationality
    {
        public Nationality()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Column("Nationality")]
        public string NationalityName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
