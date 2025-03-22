using Microsoft.AspNetCore.Mvc;
using GadenavneWebservice.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/get-address-by-codes", ([FromQuery] string municipalCode, [FromQuery] string streetCode) =>
{
    try
    {
        var adresse = DataHandler.SelectAddressByCodes(municipalCode, streetCode);

        if (adresse != null)
        {
            var message = new { Adresse = adresse };
            return Results.Ok(message);
        }
        else
        {
            return Results.NotFound("No matching line found.");
        }
    }
    catch (Exception ex)
    {
        return Results.Problem($"An error occurred: {ex.Message}");
    }
});

app.MapGet("/get-addresses-by-name", ([FromQuery] string addressName) =>
{
    try
    {
        var addresses = DataHandler.SelectAddressesByName(addressName);

        if (addresses.Length > 0)
        {
            var message = new { Addresses = addresses };
            return Results.Ok(message);
        }
        else
        {
            return Results.NotFound("No matching addresses found.");
        }
    }
    catch (Exception ex)
    {
        return Results.Problem($"An error occurred: {ex.Message}");
    }
});

app.Run();
