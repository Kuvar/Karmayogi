using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class FamilyDetailRepository : Repository<FamilyDetail>
    {
        public FamilyDetailRepository(DbContext _context) : base(_context)
        {

        }
    }
}
