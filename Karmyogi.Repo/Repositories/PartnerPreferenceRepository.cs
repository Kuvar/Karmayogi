using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class PartnerPreferenceRepository : Repository<PartnerPreference>
    {
        public PartnerPreferenceRepository(DbContext _context) : base(_context)
        {

        }
    }
}
