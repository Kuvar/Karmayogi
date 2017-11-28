using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class SearchModel
    {
        public string LookingFor { get; set; }
        public int ReligionId { get; set; }
        public int MotherTougueId { get; set; }
        public int CasteId { get; set; }
        public int StateId { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }        
    }
}
