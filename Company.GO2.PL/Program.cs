using Company.GO2.BLL.Repositories;
using Company.GO2.DAL.Data.Contexts;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace Company.GO2.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); //register built in mvc services
            builder.Services.AddScoped<DepartmentRepository>();//Allow DI for DepartmentRepository
            builder.Services.AddDbContext<CompanyDbContext>(Option=>{
                Option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            }); //Allow DI for CompanyDbContext
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
