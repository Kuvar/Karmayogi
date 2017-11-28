using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    [Serializable]
    public class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
            this.States = new HashSet<State>();
            this.UsersLiveIn = new HashSet<User>();
            this.UsersBornIn = new HashSet<User>();
            this.UsersGrewIn = new HashSet<User>();
            this.ProfileLiveIn = new HashSet<Profile>();
            this.ProfileBornIn = new HashSet<Profile>();
            this.ProfileGrewIn = new HashSet<Profile>();

            this.PartnerPreferences = new HashSet<PartnerPreference>();
        }

        [Key]
        public int Id { get; set; }
        public string Country_nm { get; set; }
        public int? IsActive { get; set; }

        [ForeignKey("IsActive")]
        public virtual Status Status { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<User> UsersLiveIn { get; set; }
        public virtual ICollection<User> UsersBornIn { get; set; }
        public virtual ICollection<User> UsersGrewIn { get; set; }

        public virtual ICollection<Profile> ProfileLiveIn { get; set; }
        public virtual ICollection<Profile> ProfileBornIn { get; set; }
        public virtual ICollection<Profile> ProfileGrewIn { get; set; }


        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }
        
    }
}
