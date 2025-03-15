namespace Mission10_Cruz.Data;

public class Bowler
{
    [Key]
    public int BowlerID { get; set; }
    public string BowlerLastName { get; set; }
    public string teamName { get; set; }
    public string Adress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Zip { get; set; }
    public int Phone { get; set; }
    
}