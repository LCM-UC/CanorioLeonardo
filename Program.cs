var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy( policity =>
    {
        policity
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
    }
);

var app = builder.Build();

app.UseCors();

app.MapGet("/", () =>
{
    return "API Sistema de Gestión funcionando";
});


app.MapGet("/", () =>
{
    return "API Sistema Academico funcionando";
});

app.MapGet("/api/estudiantes", () =>
{
    return Results.Ok(new[]
    {
        new
        {
    ID= 1,
    Nombre= "Mojito",
    Precio= 15.00,
    Ingredientes= "Ron blanco, Hojas de menta, Jugo de limón, Azúcar, Soda",
    Stock= 50
  },
  new
  {
    ID= 2,
    Nombre= "Margarita",
    Precio= 18.50,
    Ingredientes= "Tequila, Triple sec, Jugo de limón, Sal",
    Stock= 30
  },
  new
  {
    ID= 3,
    Nombre= "Piña Colada",
    Precio= 16.00,
    Ingredientes= "Ron blanco, Crema de coco, Jugo de piña",
    Stock= 40
  },
  new
  {
    ID= 4,
    Nombre= "Pisco Sour",
    Precio= 20.00,
    Ingredientes= "Pisco, Jugo de limón, Jarabe de goma, Clara de huevo, Amargo de Angostura",
    Stock= 25
  },
  new
  {
    ID= 5,
    Nombre= "Cuba Libre",
    Precio= 12.00,
    Ingredientes= "Ron añejo, Refresco de cola, Jugo de limón",
    Stock= 80
  },
  new
  {
    ID= 6,
    Nombre= "Gin Tonic",
    Precio= 17.00,
    Ingredientes= "Ginebra, Agua tónica, Rodaja de limón, Hielo",
    Stock= 60
  },
  new
  {
    ID= 7,
    Nombre= "Cosmopolitan",
    Precio= 19.00,
    Ingredientes= "Vodka, Triple sec, Jugo de arándano, Jugo de limón",
    Stock= 20
  },
  new
  {
    ID= 8,
    Nombre= "Tequila Sunrise",
    Precio= 15.50,
    Ingredientes= "Tequila, Jugo de naranja, Granadina",
    Stock= 45
  },
  new
  {
    ID= 9,
    Nombre= "Daiquiri",
    Precio= 14.00,
    Ingredientes= "Ron blanco, Jugo de limón, Almíbar",
    Stock= 35
  },
  new
  {
    ID= 10,
    Nombre= "Caipirinha",
    Precio= 15.00,
    Ingredientes= "Cachaza, Limón, Azúcar, Hielo picado",
    Stock= 55
  }
    });
});

var port = Environment.GetEnvironmentVariable("Port") ?? "10000";

app.Run();
