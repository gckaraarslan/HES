public class Location
{
    public int ID { get; set; }
    public Address Address { get; set; }
    public RiskSitutation RiskLevel {get;set;}

    public enum RiskSitutation { Low,Medium,High }
    
}