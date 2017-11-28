using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class DbErrorLogRepository : Repository<DbErrorLog>
    {
        public DbErrorLogRepository(DbContext _context) : base(_context)
        {

        }
    }
}
