using BooApp.Application.Interfaces;
using BookApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BookApp.Infrastructure.Repository;


namespace BookApp.Infrastructure
{
    public static class InterfaceServiceRegistration
    {
        public static IServiceCollection AddInterfaceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BookWebAPIconnString"));


            });
            services.AddScoped<IBookRepository, BookRepository>();
            return services;

        }
    }
}
