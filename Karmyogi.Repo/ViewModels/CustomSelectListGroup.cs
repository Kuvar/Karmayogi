using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Repo
{
    public class CustomSelectListGroup
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this <see cref="SelectListGroup"/> is disabled. 
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// Represents the value of the optgroup's label.
        /// </summary>
        public string Name { get; set; }
    }
}
