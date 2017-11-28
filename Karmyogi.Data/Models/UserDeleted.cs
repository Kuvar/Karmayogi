using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Serializable]
    public class UserDeleted
    {
        [Key]
        public int DelId { get; set; }
        public int? fk_User_ID { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedReason { get; set; }
        public string DeletedBy { get; set; }
        public string ActivatedBy { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("fk_User_ID")]
        public virtual User User { get; set; }
    }
}
