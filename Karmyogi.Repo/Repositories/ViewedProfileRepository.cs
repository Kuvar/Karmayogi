using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

using Karmyogi.Data;

namespace Karmyogi.Repo
{
    public class ViewedProfileRepository : Repository<ViewedProfile>
    {
        public ViewedProfileRepository(DbContext _context) : base(_context)
        {

        }

        public void ViewedProfile(int viewedBy, int viewedToWhom)
        {
            var viewed = Get(c => c.ViewedById == viewedBy && c.ViewedToWhomId == viewedToWhom);

            if (viewed != null && viewed.Count() == 0)
            {

            }
        }
    }
}
