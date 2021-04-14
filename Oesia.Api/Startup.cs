using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oesia.Api.Base;

namespace Oesia.Api
{
    public class Startup
    {
        private readonly InitialStartUp _initialize;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _initialize = new InitialStartUp(Configuration);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            _initialize.ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            _initialize.Configure(app, env);
        }
    }
}
