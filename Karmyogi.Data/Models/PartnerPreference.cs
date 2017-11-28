using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Table("tblPartnerPreference")]
    public class PartnerPreference
    {

        [Key, ForeignKey("Profile")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProfileID { get; set; }

        public int? From_Age { get; set; }

        public int? To_Age { get; set; }

        [StringLength(50)]
        public string Marital_Status { get; set; }

        [StringLength(50)]
        public string Body_Type { get; set; }

        [StringLength(50)]
        public string Complexion { get; set; }

        public int? HeightId { get; set; }

        [StringLength(50)]
        public string Diet { get; set; }

        public bool? IsManglik { get; set; }

        public int? Religion_Id { get; set; }

        public int? Caste_Id { get; set; }

        public int? Mother_Tongue_Id { get; set; }

        public int? Last_Degree_Id { get; set; }

        public int? Occupation_Id { get; set; }

        public int? Country_of_Residence_Id { get; set; }

        public int? State_Id { get; set; }

        public virtual Caste Caste { get; set; }

        public virtual Country Country { get; set; }

        public virtual Height Height { get; set; }

        public virtual LastDegree LastDegree { get; set; }

        public virtual MotherTongue MotherTongue { get; set; }

        public virtual Profession Profession { get; set; }

        public virtual Profile Profile { get; set; }

        public virtual Religion Religion { get; set; }

        public virtual State State { get; set; }
    }
}
