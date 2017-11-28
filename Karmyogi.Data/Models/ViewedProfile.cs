using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karmyogi.Data
{
    [Table("tblViewedProfile")]
    public class ViewedProfile
    {
        public long Id { get; set; }

        public int ViewedById { get; set; }

        public int ViewedToWhomId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ViewedDate { get; set; }

        public virtual Profile ProfileViewedBy { get; set; }

        public virtual Profile ProfileViewedToWhom { get; set; }
    }
}
