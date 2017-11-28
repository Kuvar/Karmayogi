using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class User
    {
        public User()
        {
            this.HomeImages = new HashSet<HomeImage>();
            this.UserDeletes = new HashSet<UserDeleted>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? DOB { get; set; }
        public TimeSpan? TOB { get; set; }
        public string Built { get; set; }
        public string Complexion { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string NormalyEat { get; set; }
        public string FatherName { get; set; }
        public string MySelf { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string UserImage { get; set; }
        public string FamilyStatus { get; set; }
        public string Zip { get; set; }
        public string Address { get; set; }
        public string Manglik { get; set; }

        public int? ReligionId { get; set; }
        public int? CasteId { get; set; } 
        public int? CultureId { get; set; }
        public int? GotraId { get; set; }
        public int? Language { get; set; }
        public int? LastdegreeId { get; set; }
        public int? ProfessionId { get; set; }
        public int? HaveChildren { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public int? LiveIn { get; set; }
        public int? BornIn { get; set; }
        public int? GrewIn { get; set; }
        public int? NationalityId { get; set; }
        public int? HightId { get; set; }
        public int? WeightId { get; set; }       
        public int? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? RoleID { get; set; }

        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }

        [ForeignKey("IsActive")]
        public virtual Status Status { get; set; }

        [ForeignKey("CasteId")]
        public virtual Caste Caste { get; set; }

        [ForeignKey("HaveChildren")]
        public virtual Children Children { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        [ForeignKey("LiveIn")]
        public virtual Country LiveInCountry { get; set; }

        [ForeignKey("BornIn")]
        public virtual Country BornInCountry { get; set; }

        [ForeignKey("GrewIn")]
        public virtual Country GrewInCountry { get; set; }

        [ForeignKey("CultureId")]
        public virtual Culture Culture { get; set; }

        [ForeignKey("GotraId")]
        public virtual Gotra Gotra { get; set; }

        [ForeignKey("HightId")]
        public virtual Height Hight { get; set; }

        [ForeignKey("LastdegreeId")]
        public virtual LastDegree LastDegree { get; set; }

        [ForeignKey("Language")]
        public virtual MotherTongue MotherTongue { get; set; }

        [ForeignKey("NationalityId")]
        public virtual Nationality Nationality { get; set; }

        [ForeignKey("ProfessionId")]
        public virtual Profession Profession { get; set; }

        [ForeignKey("ReligionId")]
        public virtual Religion Religion { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }

        [ForeignKey("WeightId")]
        public virtual Weight Weight { get; set; }
        
        public virtual ICollection<HomeImage> HomeImages { get; set; }
        public virtual ICollection<UserDeleted> UserDeletes { get; set; }
    }
}
