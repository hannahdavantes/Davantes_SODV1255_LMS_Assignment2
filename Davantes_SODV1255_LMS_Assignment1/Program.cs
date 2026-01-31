var builder = WebApplication.CreateBuilder(args);

//Add controller
builder.Services.AddControllers();

var app = builder.Build();

//Home route (temp)
app.MapGet("/", () => "HOME PAGE");

//Map controllers to HTTP
app.MapControllers();

app.Run();
