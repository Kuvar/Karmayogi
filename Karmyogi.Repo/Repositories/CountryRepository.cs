using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class CountryRepository :Repository<Country>
    {
        public CountryRepository(DbContext _context) : base(_context)
        {

        }
    }
}
