using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Karmyogi.Repo
{
    public class AdminSearchModel
    {
        public string Name { get; set; }
        public string LookingFor { get; set; }
        public int ReligionId { get; set; }
        public int MotherTougueId { get; set; }
        public int CasteId { get; set; }
        public int StateId { get; set; }
        
        [Range(18, 49)]
        public int AgeFrom { get; set; }

        [Range(19, 50)]
        public int AgeTo { get; set; }

        public IEnumerable<SelectListItem> LookingForList { get; set; }
        public IEnumerable<SelectListItem> Religions { get; set; }
        public IEnumerable<SelectListItem> MotherTougues { get; set; }
        public IEnumerable<SelectListItem> Castes { get; set; }
        public IEnumerable<SelectListItem> States { get; set; }
    }
}
