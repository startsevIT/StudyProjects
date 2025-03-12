var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<string> a = [];

app.MapGet("/", () => "Hello World!");


app.Run();
