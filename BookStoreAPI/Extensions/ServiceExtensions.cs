using DAO;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Repositories;
using System.Diagnostics;
using System.Reflection.Emit;


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
        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<Book>("Books");
            modelBuilder.EntitySet<Author>("Authors");
            return modelBuilder.GetEdmModel();
        }
        public static void ConfigureDAOManager(this IServiceCollection services) => services.AddScoped<IDAOManager, DAOManager>(); 

    }
}
