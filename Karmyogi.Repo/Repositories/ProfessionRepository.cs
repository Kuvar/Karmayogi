using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class ProfessionRepository : Repository<Profession>
    {
        public ProfessionRepository(DbContext _context) : base(_context)
        {

        }
    }
}
