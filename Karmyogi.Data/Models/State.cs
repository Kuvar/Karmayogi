using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Table("tblState")]
    public class State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public State()
        {
            PartnerPreferences = new HashSet<PartnerPreference>();
            Cities = new HashSet<City>();
            Users = new HashSet<User>();
            Profiles = new HashSet<Profile>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        [Column("State")]
        public string StateName { get; set; }

        [Column("Country_Id")]
        public int? CountryId { get; set; }

        public int? IsActive { get; set; }

        [ForeignKey("IsActive")]
        public virtual Status Status { get; set; }

        public virtual Country Country { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerPreference> PartnerPreferences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> Cities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
