using Karmyogi.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Karmyogi.Repo
{
    public class BasicsAndLifestyleRepository : Repository<BasicsAndLifestyle>
    {
        public BasicsAndLifestyleRepository(DbContext _context): base(_context)
        {

        }

        #region Custom Methods


        public virtual ObjectResult<User> GetSearchUsers()
        {
            var userId = new ObjectParameter("UserId", 1);

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<User>("GetSearchUsers", userId);
        }

        public IEnumerable<BasicsAndLifestyle> ProfileSearch(SearchModel model)
        {
            DateTime birthTo = DateTime.Today.AddYears(-model.AgeTo);
            DateTime birthFrom = DateTime.Today.AddYears(-model.AgeFrom);
            var data = Get(includeProperties: "EducationAndCareer");

            var d = Get(c => (model.LookingFor == "" || c.Gender == model.LookingFor)
                && (model.StateId == 0 || c.LiveInStateId == model.StateId)
                && (model.ReligionId == 0 || c.ReligiousAndAstroBackground.Profile_Id == model.ReligionId)
                && (model.CasteId == 0 || c.ReligiousAndAstroBackground.Caste_Id == model.CasteId)
                && (model.AgeFrom == 0 || c.ReligiousAndAstroBackground.Date_of_Birth >= birthFrom)
                && (model.AgeTo == 0 || c.ReligiousAndAstroBackground.Date_of_Birth <= birthTo),
                includeProperties: "EducationAndCareers,FamilyDetails,PartnerPreferences,ProfileImages,ReligiousAndAstroBackgrounds");

            return d;
        }

        #endregion
    }
}
