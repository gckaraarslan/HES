using Microsoft.EntityFrameworkCore;
public static class AddressDatabaseBuilder
{


    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
          {
              entity.HasKey(e => e.Id);
              entity.Property(e => e.Name).IsRequired();
              entity.Property(e => e.OpenAddress1);
              entity.HasOne(e => e.City).WithMany(e => e.Addresses).HasForeignKey(e => e.CityId);
              
              entity.HasOne(e => e.District).WithMany(e => e.Addresses).HasForeignKey(e => e.DistrictId);


          });
     


        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            
        });

        modelBuilder.Entity<District>(entity =>
       {
           entity.HasKey(e => e.Id);

           entity.Property(e => e.Name);
           entity.HasOne(c => c.City).WithMany(c => c.District).HasForeignKey(c => c.CityId);
       });

        modelBuilder.Entity<Address>().HasData(
     new Address
     {
         Id = 1,
         Name = "Can İş",
         OpenAddress1 = "Acıbadem meydan",
        
         CityId = 2,
         DistrictId = 2

     },
     new Address
     {
         Id = 2,
         Name = "Muhammed iş",
         OpenAddress1 = "Acıbadem meydan",
        
         CityId = 2,
         DistrictId = 1

     },
     new Address
     {
         Id = 3,
         Name = "Oğuz iş",
         OpenAddress1 = "Acıbadem meydan",
        
         CityId = 3,
         DistrictId = 3

     },
     new Address
     {
         Id = 4,
         Name = "Furkan iş",
         OpenAddress1 = "Acıbadem meydan",       
         CityId = 3,
         DistrictId = 2

     },
      new Address
      {
          Id = 5,
          Name = "Cafer iş",
          OpenAddress1 = "Acıbadem meydan ",
         CityId = 3,
          DistrictId = 1

      }
     );
        modelBuilder.Entity<City>().HasData(
            new City
            {
                Id = 1,
                Name = "Ankara",

            },
              new City
              {
                  Id = 2,
                  Name = "Istanbul",
              },
              new City
              {
                  Id = 3,
                  Name = "Bartın",
              }


        );


        modelBuilder.Entity<District>().HasData(
          new District
          {
              Id = 1,
              Name = "Kecioren",
              CityId = 1

          },
          new District
          {
              Id = 2,
              Name = "Mamak",
              CityId = 1

          },
          new District
          {
              Id = 3,
              Name = "Bagcılar",
              CityId = 2

          },
          new District
          {
              Id = 4,
              Name = "Besiktas",
              CityId = 2

          }
       );
       SetDataToDB(modelBuilder);
    }
}