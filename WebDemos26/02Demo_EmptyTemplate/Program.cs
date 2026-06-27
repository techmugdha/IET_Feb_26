namespace _02Demo_EmptyTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Services
            var app = builder.Build();

            // Middlewares
            #region Map.GET/Map.Post etc
            //app.MapGet("/", () => "GET: Hello World!");
            //app.MapGet("/abc", () => "something!");
            //app.MapPost("/", () => "POST: Hello World!");
            //app.MapPut("/", () => "PUT: Hello World!"); 
            //app.MapDelete("/", () => "DELETE: Hello World!");
            //app.MapGet("/", () => "<h1>GET: Hello World!</h1>"); 
            #endregion


            app.Use(async (httpcontext,next) => {
                await httpcontext.Response.WriteAsync("Hello, Hugh Jackman!!");
                await httpcontext.Response.WriteAsync("\nWel-come to Asp.Net MVC Core Web Application");

                next(httpcontext);

                await httpcontext.Response.WriteAsync("\nStill getting this output");
            });

            app.Use(async (httpcontext, next) => {
                await httpcontext.Response.WriteAsync("\nABCD");
                await httpcontext.Response.WriteAsync("\n1234");

                next(httpcontext);

                await httpcontext.Response.WriteAsync("\nTom Holland");
            });

            app.Run(async (httpcontext) => {
                await httpcontext.Response.WriteAsync("\nDo not sleep in my class!!");
            });

            app.Run();
        }
    }
}
