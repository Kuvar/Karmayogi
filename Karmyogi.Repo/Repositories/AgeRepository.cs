using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class AgeRepository : Repository<Age>
    {
        public AgeRepository(DbContext _context) : base(_context)
        {

        }
    }
}
