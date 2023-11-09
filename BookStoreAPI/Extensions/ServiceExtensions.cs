using Microsoft.EntityFrameworkCore;
using Repositories;


namespace BookStoreAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
       services.AddCors(options =>
       {
           options.AddPolicy("CorsPolicy", builders =>
           builders.AllowAnyHeader()
           .AllowAnyMethod()
           .AllowAnyOrigin());
       });
        public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(options =>
        {

        });
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<BookstoreDbContext>(opts
           => opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"),b => b.MigrationsAssembly("BookStoreAPI")));

    }
}
