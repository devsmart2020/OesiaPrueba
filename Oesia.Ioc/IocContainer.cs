using Microsoft.Extensions.DependencyInjection;
using Oesia.Repository.Interfaces;
using Oesia.Repository.Repository;
using Oesia.Service.Interfaces;
using Oesia.Service.Mapping;
using Oesia.Service.Services;

namespace Oesia.Ioc
{
    public static class IocContainer
    {
        public static void ConfigureIOC(this IServiceCollection services)
        {

            //AutoMapper
            services.AddAutoMapper(typeof(MappingProfile));

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
