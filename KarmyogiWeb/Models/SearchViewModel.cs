using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarmyogiWeb
{
    public class SearchViewModel
    {
        public string LookingFor { get; set; }
        public int ReligionId { get; set; }
        public int MotherTougueId { get; set; }
        public int CasteId { get; set; }
        public int StateId { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }

        public IEnumerable<SelectListItem> LookingForList { get; set; }
        public IEnumerable<SelectListItem> Religions { get; set; }
        public IEnumerable<SelectListItem> MotherTougues { get; set; }
        public IEnumerable<SelectListItem> Castes { get; set; }
        public IEnumerable<SelectListItem> States { get; set; }
    }
}