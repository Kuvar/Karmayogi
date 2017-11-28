using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    [Serializable]
    public class Culture
    {
        public Culture()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        public string CultureName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
