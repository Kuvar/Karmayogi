using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class MotherTongueRepository : Repository<MotherTongue>
    {
        public MotherTongueRepository(DbContext _context) : base(_context)
        {

        }
    }
}
