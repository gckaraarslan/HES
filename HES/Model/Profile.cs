namespace HES{
public class Profile
{
    public int Id { get; set; }
    public string HESCode { get; set; }
    public string PhoneNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string BirtDay { get; set; }
    public bool IsSick { get; set; }       

    public enum Gender { Male,Female}
    public Gender gender{get;set;}
    public int AddressID { get; set; }

    public Address Address { get; set; }
    public virtual ICollection<Report> Reports { get; set; }
}
}