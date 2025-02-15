var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://0.0.0.0:80");  // Add this line
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
