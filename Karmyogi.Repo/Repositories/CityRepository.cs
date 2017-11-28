using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class CityRepository : Repository<City>
    {
        public CityRepository(DbContext _context) : base(_context)
        {

        }
    }
}
