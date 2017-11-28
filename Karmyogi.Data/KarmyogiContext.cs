using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmyogi.Data
{
    public class KarmyogiContext : DbContext
    {
        static KarmyogiContext()
        {
            Database.SetInitializer<KarmyogiContext>(null);
        }

        public KarmyogiContext() : base("name = KarmyogiConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<PartnerPreference> PartnerPreference { get; set; }
        public DbSet<ProfileImage> ProfileImage { get; set; }


        public DbSet<Age> Age { get; set; }
        public DbSet<Caste> Caste { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Culture> Culture { get; set; }
        public DbSet<DbErrorLog> DbErrorLog { get; set; }
        public DbSet<Gotra> Gotra { get; set; }
        public DbSet<Height> Height { get; set; }
        public DbSet<HomeImage> HomeImage { get; set; }
        public DbSet<LastDegree> LastDegree { get; set; }
        public DbSet<MotherTongue> MotherTongue { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Profession> Profession { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserDeleted> UserDeleted { get; set; }
        public DbSet<Weight> Weight { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<ViewedProfile> ViewedProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new PartnerPreferenceMap());
            modelBuilder.Configurations.Add(new ProfileImageMap());
            modelBuilder.Configurations.Add(new AgeMap());
            modelBuilder.Configurations.Add(new CasteMap());
            modelBuilder.Configurations.Add(new ChildrenMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CultureMap());
            modelBuilder.Configurations.Add(new DbErrorLogMap());
            modelBuilder.Configurations.Add(new GotraMap());
            modelBuilder.Configurations.Add(new HeightMap());
            modelBuilder.Configurations.Add(new HomeImageMap());
            modelBuilder.Configurations.Add(new LastDegreeMap());
            modelBuilder.Configurations.Add(new MotherTongueMap());
            modelBuilder.Configurations.Add(new NationalityMap());
            modelBuilder.Configurations.Add(new ProfessionMap());
            modelBuilder.Configurations.Add(new ReligionMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserDeletedMap());
            modelBuilder.Configurations.Add(new WeightMap());

            modelBuilder.Configurations.Add(new ProfileMap());

            //modelBuilder.Entity<Profile>()
            //   .HasOptional(e => e.PartnerPreference)
            //   .WithRequired(e => e.Profile);

        }
    }
}
