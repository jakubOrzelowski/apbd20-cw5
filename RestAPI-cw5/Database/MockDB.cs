using RestAPI_cw5.Models;

namespace RestAPI_cw5.Database;

public class MockDB
{
    private static List<Animal> Animals { get; set; } = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal(),
        new Animal(),
    };
    private static List<Visit> Visits { get; set; } = new List<Visit>();

    public static List<Animal> GetAnimals()
    {
        return Animals;
    }

    public static Animal GetAnimalById(int id)
    {
        return Animals.FirstOrDefault(a => a.Id == id);
    }

    public static void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public static bool UpdateAnimal(int id, Animal updatedAnimal)
    {
        var animalIndex = Animals.FindIndex(a => a.Id == id);
        if (animalIndex != -1)
        {
            updatedAnimal.Id = id;
            Animals[animalIndex] = updatedAnimal;
            return true;
        }

        return false;
    }

    public static bool DeleteAnimal(int id)
    {
        var animalToRemove = Animals.FirstOrDefault(a => a.Id == id);
        if (animalToRemove != null)
        {
            Animals.Remove(animalToRemove);
            return true;
        }

        return false;
    }

    public static List<Visit> GetVisitsForAnimal(int animalId)
    {
        return Visits.Where(v => v.Animal.Id == animalId).ToList();
    }

    public static void AddVisit(Visit visit)
    {
        visit.Id = Visits.Count + 1;
        Visits.Add(visit);
    }
    
}