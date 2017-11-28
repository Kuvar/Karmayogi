using Karmyogi.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Repo
{
    public class GotraRepository : Repository<Gotra>
    {
        public GotraRepository(DbContext _context) : base(_context)
        {

        }
    }
}
