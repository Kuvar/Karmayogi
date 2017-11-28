using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class NationalityRepository : Repository<Nationality>
    {
        public NationalityRepository(DbContext _context) : base(_context)
        {

        }
    }
}
