namespace MVC_Session2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();

            #region End Points
            //app.Use(async (context, next) =>
            //{
            //    Endpoint endpoint = context.GetEndpoint();
            //    await next();
            //});
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Home Page");
            //    });
            //    endpoints.MapGet("/Products", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Products Page");
            //    });
            //    endpoints.MapGet("/Products/{id?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"You Request Product With Id => {id}");
            //        }
            //        else
            //            await context.Response.WriteAsync($"You are at Products Page");
            //    });
            //    endpoints.MapGet("/Products/{id}/{author:alpha:minlength(4):maxlength(6)}", async context =>
            //    { 
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();
            //        await context.Response.WriteAsync($"You Request Product id => {id} and author => {author}");
            //    });

            //});
            #endregion

            app.MapControllerRoute(
                name: "default",
                pattern: "/{Controller=Home}/{action=Index}",
                defaults: new { Controller = "Home", Action = "Index" }
            );
            app.Run();
        }
    }
}
