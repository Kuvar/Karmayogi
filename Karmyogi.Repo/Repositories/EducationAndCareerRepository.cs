using Karmyogi.Data;
using System.Data.Entity;

namespace Karmyogi.Repo
{
    public class EducationAndCareerRepository : Repository<EducationAndCareer>
    {
        public EducationAndCareerRepository(DbContext _context) : base(_context)
        {

        }
    }
}
