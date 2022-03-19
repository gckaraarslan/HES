using Microsoft.EntityFrameworkCore;
using HES;
    public static class ProfileDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
             new Profile
             {
                 Id = 1,
                 HESCode="23232323",
                 PhoneNumber="1234",
                 FirstName="Muhammed",
                 LastName="Bayram",
                 BirtDay="1991",
                 IsSick=false,
                 gender=Profile.Gender.Male,
                 AddressID=1

                 
                


             },
             new Profile
             {
                 Id = 2,
                 HESCode="5555555555",
                 PhoneNumber="155234",
                 FirstName="Galip Can",
                 LastName="Karaarslan",
                 BirtDay="1994",
                 IsSick=false,
                 gender=Profile.Gender.Male,
                 AddressID=2
                 

             }
         );
           
           
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>(entity =>
             {
                 entity.HasKey(e => e.Id);
                 entity.Property(x=>x.HESCode);
                 entity.Property(x=>x.PhoneNumber);
                  entity.Property(x=>x.FirstName);
                 entity.Property(x=>x.LastName);
                entity.Property(x=>x.BirtDay);
                 entity.Property(x=>x.IsSick);
                  entity.Property(x=>x.gender);
                  entity.HasOne(x=>x.Address).WithMany(x=>x.Profiles).HasForeignKey(x=>x.AddressID);
                entity.HasMany(x=>x.Reports).WithOne(x=>x.Profile).HasForeignKey(x=>x.ProfileID);


             });

          


            SetDataToDB(modelBuilder);
        }
    }
