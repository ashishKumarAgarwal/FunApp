using FunApp.Data;
using FunApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.AspNetCore.Identity;

namespace FunApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var baseUri = "https://localhost:44342/";
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            RegisterFunAppServices(services, baseUri);
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<FunAppContext>();
            services.AddAntiforgery(o => o.SuppressXFrameOptionsHeader = true);
        }
        private static void RegisterFunAppServices(IServiceCollection services, string baseUri)
        {
            services.AddHttpClient<ITeamMemberService, TeamMemberService>(client =>
                client.BaseAddress = new Uri(baseUri)
            );
            services.AddHttpClient<IRetrospectionService, RetrospectionService>(client =>
                client.BaseAddress = new Uri(baseUri)
            );
            services.AddHttpClient<IDocumentService, DocumentService>(client =>
                client.BaseAddress = new Uri(baseUri)
            );
            services.AddHttpClient<IVideoService, VideoService>(client =>
                client.BaseAddress = new Uri(baseUri)
            );
            services.AddHttpClient<ISubjectAreaService, SubjectAreaService>(client =>
                client.BaseAddress = new Uri(baseUri)
            );
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}