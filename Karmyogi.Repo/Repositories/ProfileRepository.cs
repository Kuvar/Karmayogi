using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

using Karmyogi.Data;

namespace Karmyogi.Repo
{
    public class ProfileRepository : Repository<Profile>
    {
        public ProfileRepository(DbContext _context) : base(_context)
        {

        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            return Get(includeProperties: "Role,Caste,LiveInCountry,BornInCountry,GrewInCountry,State,City,Height,LastDegree,MotherTongue,Nationality,PartnerPreference,Profession,Religion,Weight");
        }
        public IEnumerable<Profile> ProfileSearch(SearchModel model)
        {
            try
            {
                DateTime birthTo = DateTime.Today.AddYears(-model.AgeTo);
                DateTime birthFrom = DateTime.Today.AddYears(-model.AgeFrom);

                return Get(c => (model.LookingFor == "" || c.Gender == model.LookingFor)
                         && (model.StateId == 0 || c.LiveInStateId == model.StateId)
                         && (model.ReligionId == 0 || c.Religion_Id == model.ReligionId)
                         && (model.CasteId == 0 || c.Caste_Id == model.CasteId), includeProperties: "Role,Caste,LiveInCountry,BornInCountry,GrewInCountry,State,City,Height,LastDegree,MotherTongue,Nationality,PartnerPreference,Profession,Religion,Weight")
                         .Where(c => c.Date_of_Birth.Value.Date <= birthFrom.Date && c.Date_of_Birth.Value.Date >= birthTo.Date);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public Profile ViewProfile(string securityKey)
        {
            try
            {
                return Get(includeProperties: "Role,Caste,LiveInCountry,BornInCountry,GrewInCountry,State,City,Height,LastDegree,MotherTongue,Nationality,PartnerPreference,Profession,Religion,Weight")
                    .FirstOrDefault( c=>c.SecurityKey == securityKey);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
