using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class WeightRepository : Repository<Weight>
    {
        public WeightRepository(DbContext _context) : base(_context)
        {

        }
    }
}
