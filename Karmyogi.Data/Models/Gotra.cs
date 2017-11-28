using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Karmyogi.Data
{
    [Serializable]
    public class Gotra
    {
        public Gotra()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        public string GotraName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
