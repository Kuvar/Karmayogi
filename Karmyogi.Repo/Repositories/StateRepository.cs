using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class StateRepository : Repository<State>
    {
        public StateRepository(DbContext _context) : base(_context)
        {

        }
    }
}
