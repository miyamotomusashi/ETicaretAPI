using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ETicaretAPI.Persistance
{
  public static class ServiceRegistration
  {
    public static void AddPersistanceServices(this IServiceCollection services)
    {
      //services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("User ID=pgadmin;Password=WvYYurkWfk9EuEfQ;Host=localhost;Port=5435;Database=ETicaretApiDB;"));
      services.AddDbContext<ETicaretAPIDbContext>(options => options.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = ETicaretApiDB; Trusted_Connection= True;"));
      //Pooling = true; Min Pool Size = 0; Max Pool Size = 100; Connection Lifetime = 0;
      
    }
  }
}
