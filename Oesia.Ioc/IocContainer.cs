using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oesia.Repository.Data;
using Oesia.Repository.Interfaces;
using Oesia.Repository.Repository;
using Oesia.Service.Interfaces;
using Oesia.Service.Services;

namespace Oesia.Ioc
{
    public static class IocContainer
    {
        private static IConfiguration Configuration { get; }

        public static void ConfigureIOC(this IServiceCollection services)
        {
            services.AddDbContext<db_oesiaContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("oesia"),
            b => b.MigrationsAssembly("WebApi.Infrastructure.Data")));

            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IAuthorService, AuthorService>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IEditorialRepository, EditorialRepository>();
            services.AddTransient<IEditorialService, EditorialService>();
            services.AddTransient<IGenderRepository, GenderRepository>();
            services.AddTransient<IGenderService, GenderService>();
            services.AddTransient<IStateRepository, StateRepository>();
            services.AddTransient<IStateService, StateService>();
        }
    }
}
