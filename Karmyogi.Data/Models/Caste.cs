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
    public class Caste
    {
        public Caste()
        {
            this.PartnerPreferences = new HashSet<PartnerPreference>();
            this.Users = new HashSet<User>();
            this.Profiles = new HashSet<Profile>();
        }

        [Key]
        public int Id { get; set; }
        public string CasteName { get; set; }
        public int? Religion_Id { get; set; }
        public int? IsActive { get; set; }

        [ForeignKey("IsActive")]
        public virtual Status Status { get; set; }
        [ForeignKey("Religion_Id")]
        public virtual Religion Religion { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }

    }
}
