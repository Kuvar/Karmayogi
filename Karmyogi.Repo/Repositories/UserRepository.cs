using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DbContext _context) : base(_context)
        {

        }
    }
}
