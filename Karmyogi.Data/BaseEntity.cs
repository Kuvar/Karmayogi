using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [NotMapped]
        public DateTime AddedDate { get; set; }

        [NotMapped]
        public DateTime ModifiedDate { get; set; }

        [NotMapped]
        public string IPAddress { get; set; }
    }
}
