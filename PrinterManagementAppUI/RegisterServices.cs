using Microsoft.EntityFrameworkCore;
using PrinterManagementAppLibrary.DataAccess.SQL;

namespace PrinterManagementAppUI
{
    public static class RegisterServices {
        public static void ConfigureService(this WebApplicationBuilder builder) {
            // Add services to the container.

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            builder.Services.AddDbContext<SQLDBContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnection")));

            builder.Services.AddScoped<IPrinterData, SQLPrinterData>();
        }
    }
}
