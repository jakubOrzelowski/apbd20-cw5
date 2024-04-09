namespace RestAPI_cw5.EndPoints;

public static class AnimalEndPoints
{
    public static void MapAnimalEndPoints(this WebApplication app)
    {
        app.MapGet("/animals/{id}", (int id) =>
        {
            // 200 - OK
            // 404 - Not Found
            return Results.Ok(id);
        });
    }
}