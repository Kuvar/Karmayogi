using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class UserDeletedRepository : Repository<UserDeleted>
    {
        public UserDeletedRepository(DbContext _context) : base(_context)
        {

        }
    }
}
