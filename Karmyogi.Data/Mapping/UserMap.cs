using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Karmyogi.Data
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("tblUser");

            this.HasKey(t =>  t.UserId );

            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FirstName);        //public string FirstName { get; set; }
            this.Property(t => t.LastName);         //public string LastName { get; set; }
            this.Property(t => t.EmailId);          //public string EmailId { get; set; }
            this.Property(t => t.MobileNo);         //public string MobileNo { get; set; }
            this.Property(t => t.Password);         //public string Password { get; set; }
            this.Property(t => t.Gender);           //public string Gender { get; set; }
            this.Property(t => t.MaritalStatus);    //public string MaritalStatus { get; set; }
            this.Property(t => t.HaveChildren);     //public int? HaveChildren { get; set; }
            this.Property(t => t.DOB);              //public DateTime? DOB { get; set; }
            this.Property(t => t.TOB);              //public TimeSpan? TOB { get; set; }
            this.Property(t => t.ReligionId)
                .HasColumnName("Religion");         //public int? ReligionId { get; set; }
            this.Property(t => t.CasteId)
                .HasColumnName("Caste");            //public int? CasteId { get; set; }
            this.Property(t => t.Manglik);          //public string Manglik { get; set; }
            this.Property(t => t.CultureId)
                .HasColumnName("Culture");          //public int? CultureId { get; set; }
            this.Property(t => t.GotraId)
                .HasColumnName("Gotra");            //public int? GotraId { get; set; }
            this.Property(t => t.Language);         //public int? Language { get; set; }
            this.Property(t => t.LastdegreeId)
                .HasColumnName("Lastdegree");       //public int? LastdegreeId { get; set; }
            this.Property(t => t.ProfessionId)
                .HasColumnName("Profession");     //public int? ProfessionId { get; set; }
            this.Property(t => t.FamilyStatus);     //public string FamilyStatus { get; set; }
            this.Property(t => t.LiveIn);           //public int? LiveIn { get; set; }
            this.Property(t => t.StateId)
                .HasColumnName("State");          //public int? StateId { get; set; }
            this.Property(t => t.CityId)
                .HasColumnName("City");           //public int? CityId { get; set; }
            this.Property(t => t.Zip);              //public string Zip { get; set; }
            this.Property(t => t.Address);          //public string Address { get; set; }
            this.Property(t => t.BornIn);           //public int? BornIn { get; set; }
            this.Property(t => t.GrewIn);           //public int? GrewIn { get; set; }
            this.Property(t => t.NationalityId)
                .HasColumnName("Nationality");    //public int? NationalityId { get; set; }
            this.Property(t => t.HightId)
                .HasColumnName("Hight");          //public int? HightId { get; set; }
            this.Property(t => t.WeightId)
                .HasColumnName("Weight");         //public int? WeightId { get; set; }
            this.Property(t => t.Built);            //public string Built { get; set; }
            this.Property(t => t.Complexion);       //public string Complexion { get; set; }
            this.Property(t => t.EyeColor);         //public string EyeColor { get; set; }
            this.Property(t => t.HairColor);        //public string HairColor { get; set; }
            this.Property(t => t.NormalyEat);       //public string NormalyEat { get; set; }
            this.Property(t => t.FatherName);       //public string FatherName { get; set; }
            this.Property(t => t.MySelf);           //public string MySelf { get; set; }
            this.Property(t => t.RegistrationDate); //public DateTime? RegistrationDate { get; set; }
            this.Property(t => t.ActivationDate);   //public DateTime? ActivationDate { get; set; }
            this.Property(t => t.UserImage);        //public string UserImage { get; set; }
            this.Property(t => t.IsActive);         //public int? IsActive { get; set; }
            this.Property(t => t.IsDeleted);        //public bool? IsDeleted { get; set; }
            this.Property(t => t.RoleID);           //public int? RoleID { get; set; }

            // Relationships

            //public virtual Role Role { get; set; }
            this.HasRequired(t => t.Role)
                    .WithMany(t => t.Users)
                    .HasForeignKey(d => d.RoleID);

            //public virtual Status Status { get; set; }
            this.HasRequired(t => t.Status)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.IsActive);

            //public virtual Caste Caste { get; set; }
            this.HasRequired(t => t.Caste)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CasteId);

            //public virtual Children Children { get; set; }
            this.HasRequired(t => t.Children)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.HaveChildren);

            //public virtual City City { get; set; }
            this.HasRequired(t => t.City)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CityId);

            //public virtual Country LiveInCountry { get; set; }
            this.HasRequired(t => t.LiveInCountry)
                .WithMany(t => t.UsersLiveIn)
                .HasForeignKey(d => d.LiveIn)
                .WillCascadeOnDelete(false);

            //public virtual Country BornInCountry { get; set; }
            this.HasRequired(t => t.BornInCountry)
                .WithMany(t => t.UsersBornIn)
                .HasForeignKey(d => d.BornIn)
                .WillCascadeOnDelete(false);

            //public virtual Country GrewInCountry { get; set; }
            this.HasRequired(t => t.GrewInCountry)
                .WithMany(t => t.UsersGrewIn)
                .HasForeignKey(d => d.GrewIn)
                .WillCascadeOnDelete(false);

            //public virtual Culture Culture { get; set; }
            this.HasRequired(t => t.Culture)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CultureId);

            //public virtual Gotra Gotra { get; set; }
            this.HasRequired(t => t.Gotra)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.GotraId);

            //public virtual Height Hight { get; set; }
            this.HasRequired(t => t.Hight)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.HightId);

            //public virtual LastDegree LastDegree { get; set; }
            this.HasRequired(t => t.LastDegree)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.LastdegreeId);

            //public virtual MotherTongue MotherTongue { get; set; }
            this.HasRequired(t => t.MotherTongue)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.Language);

            //public virtual Nationality Nationality { get; set; }
            this.HasRequired(t => t.Nationality)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.NationalityId);

            //public virtual Profession Profession { get; set; }
            this.HasRequired(t => t.Profession)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.ProfessionId);

            //public virtual Religion Religion { get; set; }
            this.HasRequired(t => t.Religion)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.ReligionId);

            //public virtual State State { get; set; }
            this.HasRequired(t => t.State)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.StateId);

            //public virtual Weight Weight { get; set; }
            this.HasRequired(t => t.Weight)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.WeightId);

        }
    }
}
