using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class LastDegreeRepository : Repository<LastDegree>
    {
        public LastDegreeRepository(DbContext _context) : base(_context)
        {

        }
    }
}
