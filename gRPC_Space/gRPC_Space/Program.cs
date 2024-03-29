using CustomGrpcSpace.GrpcServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGrpcService<RocketService>();

app.Run();
