using FunApp.WebApI.DBContext;
using FunApp.WebApI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FunApp.WebApI
{
    public class Startup
    {
        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // services.AddResponseCaching();
            services.AddControllers();
            services.AddControllers();
            services.AddTransient<ITeamMembersRepository, TeamMemberRepository>();
            services.AddTransient<IRetrospectionRepository, RetrospectionRepository>();
            services.AddTransient<IDocumentRepository, DocumentRepository>();
            services.AddTransient<IVideoRepository, VideoRepository>();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.UseCors(policy =>
            //    policy.WithOrigins("http://localhost:5000", "https://localhost:5001", "https://localhost:44339")
            //        .AllowAnyMethod()
            //        .WithHeaders(HeaderNames.ContentType, HeaderNames.Authorization)
            //        .AllowCredentials());
            app.UseCors(options => options.AllowAnyOrigin());
        }
    }
}