namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.MapControllerRoute("default", "{Controller=Home}/{Action=index}/{id?}");
            app.UseStaticFiles();
            app.Run();
        }
    }
}