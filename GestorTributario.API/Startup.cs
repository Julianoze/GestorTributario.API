using Biobar.API.Configurations.Swagger;
using GestorTributario.API.Configurations;
using GestorTributario.API.Configurations.AutoMapperConfig;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GestorTributario.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AutoMapperServices();
            services.AddHttpClientConfiguration();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                                               .AllowAnyOrigin()
                                               .AllowAnyMethod()
                                               .AllowAnyHeader()
                );
            });

            services.AddControllers();
            services.AddSwaggerConfiguration();
            services.AddAutoMapper(typeof(Configurations.MapperConfig));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            // app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerSetup();
        }
    }
}
