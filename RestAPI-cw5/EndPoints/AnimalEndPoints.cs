using RestAPI_cw5.Database;
using RestAPI_cw5.Models;

namespace RestAPI_cw5.EndPoints;

public static class AnimalEndPoints
{
    public static void MapAnimalEndPoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            var animals = MockDB.GetAnimals();
            return Results.Ok(animals);
        });


        app.MapGet("/animals/{id}", (int id) =>
        {
            var animal = MockDB.GetAnimalById(id);
            if (animal != null)
                return Results.Ok(animal);
            else
                return Results.NotFound();
        });
        
        app.MapPost("/animals", (Animal animal) =>
        {
            MockDB.AddAnimal(animal);
            return Results.Created($"/animals/{animal.Id}", animal);
        });
        
        
        // edycja animala
        app.MapPut("/animals/{id}", (int id, Animal animal) =>
        {
            if (MockDB.UpdateAnimal(id, animal))
            {
                return Results.Ok(animal);
            }
            else
            {
                return Results.NotFound();
            }
        });
        
        // usuwanie animala
        app.MapDelete("/animals/{id}", (int id) =>
        {
            if (MockDB.DeleteAnimal(id))
            {
                return Results.NoContent();
            }
            else
            {
                return Results.NotFound();
            }
        });
        
        app.MapGet("/animals/{id}/visits", (int id) =>
        {
            var visits = MockDB.GetVisitsForAnimal(id);
            return Results.Ok(visits);
        });

        app.MapPost("/animals/{id}/visits", (int id, Visit visit) =>
        {
            var animal = MockDB.GetAnimalById(id);
            if (animal != null)
            {
                visit.Animal = animal;
                MockDB.AddVisit(visit);
                return Results.Created($"/animals/{id}/visits/{visit.Id}", visit);
            }
            else
            {
                return Results.NotFound();
            }
        });
    }
}
