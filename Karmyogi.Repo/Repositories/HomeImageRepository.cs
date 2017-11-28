using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class HomeImageRepository : Repository<HomeImage>
    {
        public HomeImageRepository(DbContext _context) : base(_context)
        {

        }
    }
}
