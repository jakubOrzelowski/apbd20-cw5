namespace RestAPI_cw5.Models;

public class Visit
{
    public int Id { get; set; }
    public Animal Animal { get; set; }
    public DateTime VisitDate { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
}