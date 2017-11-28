using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class ChildrenRepository : Repository<Children>
    {
        public ChildrenRepository(DbContext _context) : base(_context)
        {
                
        }
    }
}
