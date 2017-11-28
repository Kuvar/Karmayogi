using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Karmyogi.Data
{
    [Serializable]
    public class Status
    {
        public Status()
        {
            this.Castes = new HashSet<Caste>();
            this.Cities = new HashSet<City>();
            this.Countries = new HashSet<Country>();
            this.MotherTongues = new HashSet<MotherTongue>();
            this.Religions = new HashSet<Religion>();
            this.States = new HashSet<State>();
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        public string State { get; set; }

        public virtual ICollection<Caste> Castes { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<MotherTongue> MotherTongues { get; set; }
        public virtual ICollection<Religion> Religions { get; set; }
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
