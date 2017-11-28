using Karmyogi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Repo
{
    public class KarmyogiService 
    {
        IUnitOfWork _unitOfWork;
        private PartnerPreferenceRepository partnerPreferenceRepository;
        private ProfileImageRepository profileImageRepository;
        private ProfileRepository profileRepository;
        private ViewedProfileRepository viewedProfileRepository;

        private AgeRepository ageRepository;
        private CasteRepository casteRepository;
        private ChildrenRepository childrenRepository;
        private CityRepository cityRepository;
        private CountryRepository countryRepository;
        private CultureRepository cultureRepository;
        private DbErrorLogRepository dbErrorLogRepository;
        private GotraRepository gotraRepository;
        private HeightRepository heightRepository;
        private HomeImageRepository homeImageRepository;
        private LastDegreeRepository lastDegreeRepository;
        private MotherTongueRepository motherTongueRepository;
        private NationalityRepository nationalityRepository;
        private ProfessionRepository professionRepository;
        private ReligionRepository religionRepository;
        private RoleRepository roleRepository;
        private StateRepository stateRepository;
        private StatusRepository statusRepository;
        private UserRepository userRepository;
        private UserDeletedRepository userDeletedRepository;
        private WeightRepository weightRepository;

        public PartnerPreferenceRepository PartnerPreference { get => partnerPreferenceRepository; set => partnerPreferenceRepository = value; }
        public ProfileImageRepository ProfileImage { get => profileImageRepository; set => profileImageRepository = value; }
        public ProfileRepository Profile { get => profileRepository; set => profileRepository = value; }
        public ViewedProfileRepository ViewedProfile { get => viewedProfileRepository; set => viewedProfileRepository = value; }

        public KarmyogiService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this.PartnerPreference = unitOfWork.partnerPreferenceRepository;
            this.ProfileImage = unitOfWork.profileImageRepository;

            this.ageRepository = unitOfWork.ageRepository;
            this.casteRepository = unitOfWork.casteRepository;
            this.childrenRepository = unitOfWork.childrenRepository;
            this.cityRepository = unitOfWork.cityRepository;
            this.countryRepository = unitOfWork.countryRepository;
            this.cultureRepository = unitOfWork.cultureRepository;
            this.dbErrorLogRepository = unitOfWork.dbErrorLogRepository;
            this.gotraRepository = unitOfWork.gotraRepository;
            this.heightRepository = unitOfWork.heightRepository;
            this.homeImageRepository = unitOfWork.homeImageRepository;
            this.lastDegreeRepository = unitOfWork.lastDegreeRepository;
            this.motherTongueRepository = unitOfWork.motherTongueRepository;
            this.nationalityRepository = unitOfWork.nationalityRepository;
            this.professionRepository = unitOfWork.professionRepository;
            this.roleRepository = unitOfWork.roleRepository;
            this.religionRepository = unitOfWork.religionRepository;
            this.stateRepository = unitOfWork.stateRepository;
            this.statusRepository = unitOfWork.statusRepository;
            this.userRepository = unitOfWork.userRepository;
            this.userDeletedRepository = unitOfWork.userDeletedRepository;
            this.weightRepository = unitOfWork.weightRepository;
            this.Profile = unitOfWork.profileRepository;
            this.ViewedProfile = unitOfWork.viewedProfileRepository;
        }

        #region Roles Region
        public IEnumerable<Role> AllRoles(Expression<Func<Role, bool>> filter = null, Func<IQueryable<Role>, IOrderedQueryable<Role>> orderBy = null, string includeProperties = "")
        {
            return roleRepository.Get(filter, orderBy, includeProperties);
        }

        public Role GetRoleById(int id)
        {
            return roleRepository.GetById(id);
        }

        public void InsertRole(Role role)
        {
            roleRepository.Insert(role);
        }

        public void UpdateRole(Role role)
        {
            roleRepository.Update(role);
        }

        public void DeleteRole(Role role)
        {
            roleRepository.Delete(role);
        }
        #endregion

        #region Country Region
        public IEnumerable<Country> AllCountries(Expression<Func<Country, bool>> filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>> orderBy = null, string includeProperties = "")
        {
            return countryRepository.Get(filter, orderBy, includeProperties);
        }

        public Country GetCountryById(int id)
        {
            return countryRepository.GetById(id);
        }

        public void InsertCountry(Country country)
        {
            countryRepository.Insert(country);
        }

        public void UpdateCountry(Country country)
        {
            countryRepository.Update(country);
        }

        public void DeleteCountry(Country country)
        {
            countryRepository.Delete(country);
        }
        #endregion

        #region State Region
        public IEnumerable<State> AllStates(Expression<Func<State, bool>> filter = null, Func<IQueryable<State>, IOrderedQueryable<State>> orderBy = null, string includeProperties = "")
        {
            return stateRepository.Get(filter, orderBy, includeProperties);
        }

        public State GetStateById(int id)
        {
            return stateRepository.GetById(id);
        }

        public IEnumerable<State> GetStateByCountryId(int id)
        {
            try
            {
                var t = stateRepository.Get(c => c.CountryId == id);
                return t;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public void InsertState(State obj)
        {
            stateRepository.Insert(obj);
        }

        public void UpdateState(State obj)
        {
            stateRepository.Update(obj);
        }

        public void DeleteState(State obj)
        {
            stateRepository.Delete(obj);
        }
        #endregion

        #region City Region
        public IEnumerable<City> AllCities(Expression<Func<City, bool>> filter = null, Func<IQueryable<City>, IOrderedQueryable<City>> orderBy = null, string includeProperties = "")
        {
            return cityRepository.Get(filter, orderBy, includeProperties);
        }

        public State GetCityById(int id)
        {
            return stateRepository.GetById(id);
        }
        

        public void InsertCity(City obj)
        {
            cityRepository.Insert(obj);
        }

        public void UpdateCity(City obj)
        {
            cityRepository.Update(obj);
        }

        public void DeleteCity(City obj)
        {
            cityRepository.Delete(obj);
        }
        #endregion

        #region Religion Region
        public IEnumerable<Religion> AllReligions(Expression<Func<Religion, bool>> filter = null, Func<IQueryable<Religion>, IOrderedQueryable<Religion>> orderBy = null, string includeProperties = "")
        {
            return religionRepository.Get(filter, orderBy, includeProperties);
        }
        #endregion

        #region Caste Region

        public IEnumerable<Caste> GetCasteByReligionId(int id)
        {
            return casteRepository.Get(c => c.Religion_Id == id);
        }

        public IEnumerable<Caste> GetCasteById(int id)
        {
            return casteRepository.Get(c => c.Id == id);
        }
        #endregion
    }
}
