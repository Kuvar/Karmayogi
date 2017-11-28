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
    public class BasicsAndLifestyle
    {
        public BasicsAndLifestyle()
        {
            this.EducationAndCareer = new EducationAndCareer();
            this.FamilyDetail = new FamilyDetail();
            //this.PartnerPreference = new PartnerPreference();
            this.ReligiousAndAstroBackground = new ReligiousAndAstroBackground();
            this.ProfileImages = new HashSet<ProfileImage>();         
        }

        [Key]
        public int Profile_Id { get; set; }
        public string F_Name { get; set; }
        public string M_Name { get; set; }
        public string L_Name { get; set; }
        public string Marital_Status { get; set; }
        public string Body_Type { get; set; }
        public string Complexion { get; set; }
        
        public string Blood_Group { get; set; }
        public string Physical_Status { get; set; }
        public string Diet { get; set; }
        public string Smoke { get; set; }
        public string Drink { get; set; }
        public string Gender { get; set; }
        public DateTime? Created_Date { get; set; }
        public bool? IsActive { get; set; }

        public int Mother_TongueId { get; set; }
        public int WeightId { get; set; }
        public int HeightId { get; set; }

        public int NationalityId { get; set; }
        public int LiveInCountryId { get; set; }
        public int BornInCountryId { get; set; }
        public int GrewInCountryId { get; set; }
        public int LiveInStateId { get; set; }
        public int LiveInCityId { get; set; }

        [ForeignKey("HeightId")]
        public virtual Height Height { get; set; }

        [ForeignKey("Mother_TongueId")]
        public virtual MotherTongue MotherTongue { get; set; }

        [ForeignKey("WeightId")]
        public virtual Weight Weight { get; set; }

        [ForeignKey("NationalityId")]
        public virtual Nationality Nationality { get; set; }

        [ForeignKey("LiveInCountryId")]
        public virtual Country LiveInCountry { get; set; }

        [ForeignKey("BornInCountryId")]
        public virtual Country BornInCountry { get; set; }

        [ForeignKey("GrewInCountryId")]
        public virtual Country GrewInCountry { get; set; }
        [ForeignKey("LiveInStateId")]
        public virtual State LiveInState { get; set; }

        [ForeignKey("LiveInCityId")]
        public virtual City LiveInCity { get; set; }

        
        public virtual EducationAndCareer EducationAndCareer { get; set; }

        public virtual FamilyDetail FamilyDetail { get; set; }

        //public virtual PartnerPreference PartnerPreference { get; set; }

        public virtual ReligiousAndAstroBackground ReligiousAndAstroBackground { get; set; }
        public virtual ICollection<ProfileImage> ProfileImages { get; set; }
    }
}
