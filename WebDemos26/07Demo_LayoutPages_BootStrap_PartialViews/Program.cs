namespace _07Demo_LayoutPages_BootStrap_PartialViews
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // images, bootstrap, js, css etc
            app.UseStaticFiles();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
