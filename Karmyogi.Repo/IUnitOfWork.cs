using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Repo
{
    public interface IUnitOfWork : IDisposable
    {

        PartnerPreferenceRepository partnerPreferenceRepository { get; }
        ProfileImageRepository profileImageRepository { get; }
        ProfileRepository profileRepository { get; }
        ViewedProfileRepository viewedProfileRepository { get; }



        AgeRepository ageRepository { get; }
        CasteRepository casteRepository { get; }
        ChildrenRepository childrenRepository { get; }
        CityRepository cityRepository { get; }
        CountryRepository countryRepository { get; }
        CultureRepository cultureRepository { get; }
        DbErrorLogRepository dbErrorLogRepository { get; }
        GotraRepository gotraRepository { get; }
        HeightRepository heightRepository { get; }
        HomeImageRepository homeImageRepository { get; }
        LastDegreeRepository lastDegreeRepository { get; }
        MotherTongueRepository motherTongueRepository { get; }
        NationalityRepository nationalityRepository { get; }
        ProfessionRepository professionRepository { get; }
        ReligionRepository religionRepository { get; }
        RoleRepository roleRepository { get; }
        StateRepository stateRepository { get; }
        StatusRepository statusRepository { get; }
        UserRepository userRepository { get; }
        UserDeletedRepository userDeletedRepository { get; }
        WeightRepository weightRepository { get; }



        void Save();
    }
}
