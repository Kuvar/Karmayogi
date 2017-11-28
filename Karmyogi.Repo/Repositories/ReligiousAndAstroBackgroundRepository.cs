using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class ReligiousAndAstroBackgroundRepository : Repository<ReligiousAndAstroBackground>
    {
        public ReligiousAndAstroBackgroundRepository(DbContext _context) : base(_context)
        {

        }
    }
}
