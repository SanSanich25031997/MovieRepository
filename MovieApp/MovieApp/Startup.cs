using DataLayer;
using DataLayer.Entities.ActorMovieRelations;
using DataLayer.Entities.Actors;
using DataLayer.Entities.Directors;
using DataLayer.Entities.Genres;
using DataLayer.Entities.MovieGenreRelations;
using DataLayer.Entities.Movies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieApp.Models.Actors;
using MovieApp.Models.Directors;
using MovieApp.Models.Genres;
using MovieApp.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp
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
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<IDirectorRepository, DirectorRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IActorViewModelListBuilder, ActorViewModelListBuilder>();
            services.AddScoped<IDirectorViewModelListBuilder, DirectorViewModelListBuilder>();
            services.AddScoped<IGenreViewModelListBuilder, GenreViewModelListBuilder>();
            services.AddScoped<IMovieViewModelListBuilder, MovieViewModelListBuilder>();

            services.AddHttpClient();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews(mvcOptions =>
            {
                mvcOptions.EnableEndpointRouting = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}");
            });

            using(var scope = app.ApplicationServices.CreateScope())
            {
                ApplicationContext context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                DbObjects.Initialize(context);
            }
        }
    }
}
