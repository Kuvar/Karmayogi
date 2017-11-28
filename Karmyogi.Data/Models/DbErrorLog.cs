using System;
using System.ComponentModel.DataAnnotations;

namespace Karmyogi.Data
{
    [Serializable]
    public class DbErrorLog
    {
        [Key]
        public int DbErrorId { get; set; }
        public int DbErrorNumber { get; set; }
        public string DbErrorMsg { get; set; }
        public System.DateTime DbErrorDate { get; set; }
        public string DbErrorLocation { get; set; }
    }
}
