using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PrinterManagementAppLibrary.DataAccess.SQL;
using Microsoft.EntityFrameworkCore;

namespace PrinterManagementAppUI
{
    public static class RegisterServices {
        public static void ConfigureService(this WebApplicationBuilder builder) {
            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("SQLConnection");
            builder.Services.AddDbContext<SQLDBContext>(options=>options.UseSqlServer(connectionString));
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            builder.Services.AddDbContext<SQLDBContext>(opt =>{ 
                opt.UseInMemoryDatabase("MemoryDB");
            //  opt.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnection")).EnableSensitiveDataLogging());
        });


            builder.Services.AddScoped<IPrinterData, SQLPrinterData>();
        }
    }
}
