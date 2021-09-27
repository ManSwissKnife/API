using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);
string con = "Server=(localdb)\\mssqllocaldb;Database=usersdbstore;Trusted_Connection=True;";
builder.Services.AddDbContext<UsersContext>(options => options.UseSqlServer(con));
builder.Services.AddControllers();
var app = builder.Build();


app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
