using Microsoft.EntityFrameworkCore;
using Angioletti.Models;
using Angioletti.Datas;


var builder = WebApplication.CreateBuilder(args);

//IConfiguration config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .AddEnvironmentVariables()
//    .Build();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(options => //options.UseInMemoryDatabase("audio"));
                                                       //options.UseSqlite(config.GetConnectionString("AudioContextConnection"));
        options.UseSqlite("Data Source=Prova.db"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    SeedData.Initilize(dbContext);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();