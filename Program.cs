using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;
using Microsoft.AspNetCore.Identity;
using WebApplication1;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

/*
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBContext") ?? throw new InvalidOperationException("Connection string 'UsersWebAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//var builder = WebApplication.CreateBuilder(args);
//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services);


//var app = builder.Build();
//startup.Configure(app,builder.Environment);
*/

