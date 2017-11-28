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
    public class City
    {
        public City()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }       
        public int? IsActive { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        [ForeignKey("StateId")]
        public virtual State State { get; set; }
        [ForeignKey("IsActive")]
        public virtual Status Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
