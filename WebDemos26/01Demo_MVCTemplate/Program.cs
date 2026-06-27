namespace _01Demo_MVCTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Services bind
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build(); // Express()

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // Middlewares- helper C# Classes
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            // Application: gets configured based on dependency services and middlewares, host your application on IIS/ Kestrel web server and also it strats the web application.. just like app.listen() from node application
            app.Run();
        }
    }
}
