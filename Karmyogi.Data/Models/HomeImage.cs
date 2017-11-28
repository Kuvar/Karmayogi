using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class HomeImage
    {
        [Key]
        public int Id { get; set; }
        public string ImgName { get; set; }
        public string ImgUrl { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        
        [ForeignKey("CreatedBy")]
        public virtual User User { get; set; }
    }
}
