using Microsoft.EntityFrameworkCore;
using HES;
public static class ReporerDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reporter>().HasData(
         new Reporter
         {
             ID = 1,
             FirstName = "galipcan",
             LastName = "karaarslan",
             ProfileID=1





         },
         new Reporter
         {
              ID = 1,
             FirstName = "oğuz",
             LastName = "akın",
             ProfileID=1


         }
     );


    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reporter>(entity =>
         {
             entity.HasKey(e => e.ID);
            entity.Property(x=>x.FirstName);
                   entity.Property(x=>x.LastName);
                   entity.HasOne(x=>x.Profile).WithOne().HasForeignKey<Reporter>(x=>x.ProfileID);
         });
        SetDataToDB(modelBuilder);
    }
}
