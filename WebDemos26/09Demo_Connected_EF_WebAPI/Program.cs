using _09Demo_Connected_EF_WebAPI.DAL;
using Microsoft.EntityFrameworkCore;

namespace _09Demo_Connected_EF_WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<EmpDbContext>();
            builder.Services.AddDbContext<ProductDbContext>(
                options => options.UseSqlServer("name=conStr")
                );
            builder.Services.AddDbContext<EmpDataDbContext>(options=> options.UseSqlServer("name=conStr"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Emp}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
