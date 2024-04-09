using RestAPI_cw5.Models;

namespace RestAPI_cw5.Database;

public class MockDB
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDB()
    {
        
    }
}