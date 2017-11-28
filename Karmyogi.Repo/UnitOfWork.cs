
using System;
using Karmyogi.Data;
using System.Data.Entity;
using System.Linq;
using System.Transactions;

namespace Karmyogi.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private bool _disposed;

        
        public PartnerPreferenceRepository _partnerPreferenceRepository;
        public ProfileImageRepository _profileImageRepository;
        public ProfileRepository _profileRepository;
        public ViewedProfileRepository _viewedProfileRepository;

        public AgeRepository _ageRepository;
        public CasteRepository _casteRepository;
        public ChildrenRepository _childrenRepository;
        public CityRepository _cityRepository;
        public CountryRepository _countryRepository;
        public CultureRepository _cultureRepository;
        public DbErrorLogRepository _dbErrorLogRepository;
        public GotraRepository _gotraRepository;
        public HeightRepository _heightRepository;
        public HomeImageRepository _homeImageRepository;
        public LastDegreeRepository _lastDegreeRepository;
        public MotherTongueRepository _motherTongueRepository;
        public NationalityRepository _nationalityRepository;
        public ProfessionRepository _professionRepository;
        public ReligionRepository _religionRepository;
        public RoleRepository _roleRepository;
        public StateRepository _stateRepository;
        public StatusRepository _statusRepository;
        public UserRepository _userRepository;
        public UserDeletedRepository _userDeletedRepository;
        public WeightRepository _weightRepository;


        public UnitOfWork(IDbContextFactory dbContextFactory)
        {
            _dbContext = dbContextFactory.GetDbContext();
        }

        public PartnerPreferenceRepository partnerPreferenceRepository
        {
            get { return _partnerPreferenceRepository ?? (_partnerPreferenceRepository = new PartnerPreferenceRepository(_dbContext)); }
        }
        public ProfileImageRepository profileImageRepository
        {
            get { return _profileImageRepository ?? (_profileImageRepository = new ProfileImageRepository(_dbContext)); }
        }
        public ProfileRepository profileRepository
        {
            get { return _profileRepository ?? (_profileRepository = new ProfileRepository(_dbContext)); }
        }
        public ViewedProfileRepository viewedProfileRepository
        {
            get { return _viewedProfileRepository ?? (_viewedProfileRepository = new ViewedProfileRepository(_dbContext)); }
        }


        public AgeRepository ageRepository
        {
            get { return _ageRepository ?? (_ageRepository = new AgeRepository(_dbContext)); }
        }
        public CasteRepository casteRepository
        {
            get { return _casteRepository ?? (_casteRepository = new CasteRepository(_dbContext)); }
        }
        public ChildrenRepository childrenRepository
        {
            get { return _childrenRepository ?? (_childrenRepository = new ChildrenRepository(_dbContext)); }
        }
        public CityRepository cityRepository
        {
            get { return _cityRepository ?? (_cityRepository = new CityRepository(_dbContext)); }
        }
        public CountryRepository countryRepository
        {
            get { return _countryRepository ?? (_countryRepository = new CountryRepository(_dbContext)); }
        }
        public CultureRepository cultureRepository
        {
            get { return _cultureRepository ?? (_cultureRepository = new CultureRepository(_dbContext)); }
        }
        public DbErrorLogRepository dbErrorLogRepository
        {
            get { return _dbErrorLogRepository ?? (_dbErrorLogRepository = new DbErrorLogRepository(_dbContext)); }
        }
        public GotraRepository gotraRepository
        {
            get { return _gotraRepository ?? (_gotraRepository = new GotraRepository(_dbContext)); }
        }
        public HeightRepository heightRepository
        {
            get { return _heightRepository ?? (_heightRepository = new HeightRepository(_dbContext)); }
        }
        public HomeImageRepository homeImageRepository
        {
            get { return _homeImageRepository ?? (_homeImageRepository = new HomeImageRepository(_dbContext)); }
        }
        public LastDegreeRepository lastDegreeRepository
        {
            get { return _lastDegreeRepository ?? (_lastDegreeRepository = new LastDegreeRepository(_dbContext)); }
        }
        public MotherTongueRepository motherTongueRepository
        {
            get { return _motherTongueRepository ?? (_motherTongueRepository = new MotherTongueRepository(_dbContext)); }
        }
        public NationalityRepository nationalityRepository
        {
            get { return _nationalityRepository ?? (_nationalityRepository = new NationalityRepository(_dbContext)); }
        }
        public ProfessionRepository professionRepository
        {
            get { return _professionRepository ?? (_professionRepository = new ProfessionRepository(_dbContext)); }
        }
        public ReligionRepository religionRepository
        {
            get { return _religionRepository ?? (_religionRepository = new ReligionRepository(_dbContext)); }
        }
        public RoleRepository roleRepository
        {
            get { return _roleRepository ?? (_roleRepository = new RoleRepository(_dbContext)); }
        }
        public StateRepository stateRepository
        {
            get { return _stateRepository ?? (_stateRepository = new StateRepository(_dbContext)); }
        }
        public StatusRepository statusRepository
        {
            get { return _statusRepository ?? (_statusRepository = new StatusRepository(_dbContext)); }
        }
        public UserRepository userRepository
        {
            get { return _userRepository ?? (_userRepository = new UserRepository(_dbContext)); }
        }
        public UserDeletedRepository userDeletedRepository
        {
            get { return _userDeletedRepository ?? (_userDeletedRepository = new UserDeletedRepository(_dbContext)); }
        }
        public WeightRepository weightRepository
        {
            get { return _weightRepository ?? (_weightRepository = new WeightRepository(_dbContext)); }
        }

        public void Save()
        {
            if (_dbContext.GetValidationErrors().Any())
            {
                // TODO: move validation errors into domain level exception and then throw it instead of EF related one 
            }

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            {
                //TODO: perform all save operations from different contexts used
                _dbContext.SaveChanges();

                //end of transaction scope
                scope.Complete();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
