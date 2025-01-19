var builder = WebApplication.CreateBuilder(args);

//add services to the container


var app = builder.Build();

app.MapGet("/", () => "Hello World From catalog!");


//configure the HTTP request pipeline



app.Run();
