using CollegeManagement.API.Repository.Impl;
using CollegeManagement.API.Repository;
using CollegeManagement.API.Service.Impl;
using CollegeManagement.API.Service;
using CollegeManagement.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CollegeManagement.API
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

            services.AddControllers();

            services.AddScoped<ICollegeRepository, CollegeRepository>();
            services.AddScoped<ICollegeService, CollegeService>();

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<ISemesterService, SemesterService>();

            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ISubjectService, SubjectService>();

            services.AddDbContext<CollegeManagementContext>(opt =>
               opt.UseSqlServer(Configuration.GetConnectionString("CollegeManagementConnection"))
                  .EnableSensitiveDataLogging()
               );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
