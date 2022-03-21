using Microsoft.EntityFrameworkCore;
using HES;
public static class ReportDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Report>().HasData(
         new Report
         {
             ID = 1,
             ReporterID = 1,
             TypeOfInfraction = Report.InfractionType.MaskRuleBreak,
             AddressID = 1,
             ProfileID=1





         },
         new Report
         {
             ID = 2,
             ReporterID = 2,
             TypeOfInfraction = Report.InfractionType.SocialDistanceRuleBreak,
             AddressID = 2,
             ProfileID=1


         }
     );


    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Report>(entity =>
         {
             entity.HasKey(e => e.ID);
             entity.HasOne(e => e.Reporter).WithMany(x => x.Reports).HasForeignKey(x => x.ReporterID);
             entity.Property(x => x.TypeOfInfraction);
             entity.HasOne(x => x.Address).WithMany(x => x.Reports).HasForeignKey(x => x.AddressID);
         });
        SetDataToDB(modelBuilder);
    }
}
