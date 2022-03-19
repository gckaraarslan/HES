using HES;
public class Reporter{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual ICollection<Report> Reports { get; set; }
    public int ProfileID { get; set; }
    public Profile Profile { get; set; }

    
}