using RestAPI_cw5.Database;
using RestAPI_cw5.Models;

namespace RestAPI_cw5.EndPoints;

public static class AnimalEndPoints
{
    public static void MapAnimalEndPoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            var animals = StaticData.Animals;
            return Results.Ok(animals);
        });


        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);
        });
        
        app.MapPost("/animals", (Animal animal) =>
        {
            return Results.Ok();
        });
    }
}
