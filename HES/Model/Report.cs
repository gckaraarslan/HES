
using HES;
public class Report
{
    public int ID { get; set; }
    public int ReporterID { get; set; }
    public Reporter Reporter { get; set; }  //anonime de çevirebiliriz....

   public enum InfractionType { MaskRuleBreak, SocialDistanceRuleBreak, HygieneRuleBreak, IsolationRuleBreak }
    public InfractionType TypeOfInfraction {get;set;}
    //public Byte Image{get;set;}       FOTO YÜKLEMEYİ ÖĞRENİNCE EKLİCEZ...
    public int AddressID { get; set; }
    public Address Address { get; set; }

    public int ProfileID { get; set; }
    public Profile Profile { get; set; }





}