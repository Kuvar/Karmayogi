using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class DbContextFactory : IDbContextFactory
    {
        private readonly DbContext _context;

        public DbContextFactory()
        {
            _context = new KarmyogiContext();
        }
        public DbContext GetDbContext()
        {
            return _context;
        }
    }
}
