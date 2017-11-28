using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Table("tblProfile")]
    public class Profile
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileID { get; set; }

        [StringLength(100)]
        public string F_Name { get; set; }

        [StringLength(100)]
        public string M_Name { get; set; }

        [StringLength(100)]
        public string L_Name { get; set; }

        [StringLength(50)]
        public string Marital_Status { get; set; }

        public int Mother_TongueId { get; set; }

        [StringLength(50)]
        public string Body_Type { get; set; }

        [StringLength(50)]
        public string Complexion { get; set; }

        public int WeightId { get; set; }

        public int HeightId { get; set; }

        [StringLength(10)]
        public string Blood_Group { get; set; }

        [StringLength(10)]
        public string Physical_Status { get; set; }

        [StringLength(50)]
        public string Diet { get; set; }

        [StringLength(10)]
        public string Smoke { get; set; }

        [StringLength(10)]
        public string Drink { get; set; }

        public DateTime? Created_Date { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(7)]
        public string Gender { get; set; }

        public int NationalityId { get; set; }

        public int LiveInCountryId { get; set; }

        public int BornInCountryId { get; set; }

        public int GrewInCountryId { get; set; }

        public int LiveInStateId { get; set; }

        public int LiveInCityId { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        public int UserInRole { get; set; }

        [Required]
        [StringLength(20)]
        public string Contact_No { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; }

        public int? Last_Degree_Id { get; set; }

        public int? Occupation_Id { get; set; }

        [StringLength(50)]
        public string Annual_Income { get; set; }

        [StringLength(100)]
        public string Fathers_Occupation { get; set; }

        [StringLength(100)]
        public string Mothers_Occupation { get; set; }

        public int? No_of_Brothers { get; set; }

        public int? No_of_Sisters { get; set; }

        public TimeSpan? Time_of_Birth { get; set; }

        public int? Religion_Id { get; set; }

        public int? Caste_Id { get; set; }

        public DateTime? Date_of_Birth { get; set; }

        [StringLength(50)]
        public string Raasi { get; set; }

        [StringLength(50)]
        public string Place_of_Birth { get; set; }

        public Int64 DisplayID { get; set; }

        [StringLength(50)]
        public string SecurityKey { get; set; }

        public virtual Role Role { get; set; }

        public virtual Caste Caste { get; set; }

        public virtual City City { get; set; }

        [ForeignKey("LiveInCountryId")]
        public virtual Country LiveInCountry { get; set; }

        [ForeignKey("BornInCountryId")]
        public virtual Country BornInCountry { get; set; }

        [ForeignKey("GrewInCountryId")]
        public virtual Country GrewInCountry { get; set; }

        public virtual Height Height { get; set; }

        public virtual LastDegree LastDegree { get; set; }

        public virtual MotherTongue MotherTongue { get; set; }

        public virtual Nationality Nationality { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Required]
        [ForeignKey("ProfileID")]
        public virtual PartnerPreference PartnerPreference { get; set; }

        public virtual Profession Profession { get; set; }

        public virtual Religion Religion { get; set; }

        public virtual State State { get; set; }

        public virtual Weight Weight { get; set; }

        public virtual ICollection<ProfileImage> ProfileImages { get; set; }
        public virtual ICollection<ViewedProfile> ProfilesViewedBy { get; set; }       
        public virtual ICollection<ViewedProfile> ProfilesViewedToWhom { get; set; }
    }
}
