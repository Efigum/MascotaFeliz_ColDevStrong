using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mascota_Feliz.App.Persistencia.App_Repositorios;

namespace Mascota_Feliz.App.Presentacion
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
            //Agregar paginas Razor
            services.AddRazorPages();

            //Asociamos los repositorios a la capa de presentación para el uso del servicio DbContext para llamar los métodos CRUD.
            services.AddScoped<IRepositorio_Historia_Clinica, Repositorio_Historia_Clinica>();
            services.AddScoped<IRepositorio_Mascota, Repositorio_Mascota>();
            services.AddScoped<IRepositorio_Medico_Veterinario, Repositorio_Medico_Veterinario>();
            services.AddScoped<IRepositorio_Propietario_Mascota, Repositorio_Propietario_Mascota>();
            services.AddScoped<IRepositorio_Visita, Repositorio_Visita>();

            //Agregamos el AppContext
            services.AddSingleton<Mascota_Feliz.App.Persistencia.App_Repositorios.AppContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
