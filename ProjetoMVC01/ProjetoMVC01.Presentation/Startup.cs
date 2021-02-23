using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoMVC01.Repository.Repositories;

namespace ProjetoMVC01.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //componente para ler o arquivo appsettings.json
        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Habilitar o padrão de rotas do MVC
            services.AddControllersWithViews();

            #region Injeção de dependência

            //capturar a connectionstring mapeada no arquivo appsettings.json
            var connectionstring = Configuration.GetConnectionString("BDProjetoMVC01");

            //injetar em cada classe do repositorio a connectionstring
            services.AddTransient(map => new EmpresaRepository(connectionstring));
            services.AddTransient(map => new FuncionarioRepository(connectionstring));

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //configuração para habilitar a pasta /wwwroot
            app.UseStaticFiles();

            app.UseRouting();

            //mapeando a página inicial do projeto
            app.UseEndpoints(
              endpoints => {
                  endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Home}/{action=Index}"
                      );
              });
        }
    }
}
