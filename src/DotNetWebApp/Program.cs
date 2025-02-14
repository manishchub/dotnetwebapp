var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Listen on all interfaces (important for containerized apps)
app.Urls.Add("http://0.0.0.0:80");

app.MapGet("/", () => "Hello World!");

app.Run();
