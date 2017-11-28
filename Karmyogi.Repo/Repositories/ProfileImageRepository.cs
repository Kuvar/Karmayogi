using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class ProfileImageRepository : Repository<ProfileImage>
    {
        public ProfileImageRepository(DbContext _context) : base(_context)
        {

        }
    }
}
