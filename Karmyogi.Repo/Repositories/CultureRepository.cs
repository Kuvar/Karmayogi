using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class CultureRepository : Repository<Culture>
    {
        public CultureRepository(DbContext _context) : base(_context)
        {

        }
    }
}
