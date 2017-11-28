using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class HeightRepository : Repository<Height>
    {
        public HeightRepository(DbContext _context) : base(_context)
        {

        }
    }
}
