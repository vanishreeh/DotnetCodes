using BookAPPWithdatabase.AspectOrientedProgramming;
using BookAPPWithdatabase.Context;
using BookAPPWithdatabase.Logginglogic;
using BookAPPWithdatabase.Repository;
using BookAPPWithdatabase.Service;
using Microsoft.EntityFrameworkCore;

namespace BookAPPWithdatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            string conn = builder.Configuration.GetConnectionString("LocaldatabaseConnection");
            builder.Services.AddDbContext<BookDbContext>(options => options.UseSqlServer(conn));
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IBookRepository, BookRepository>();
            builder.Services.AddSingleton<CustomLogger>();
            builder.Services.AddScoped<ExceptionHandlerAttribute>();
            builder.Services.AddScoped<AddResultFiler>();
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");//Home/Detail/5
            //app.MapControllerRoute(
            //    name: "login",
            //    pattern: "login/{Index}",
            //    defaults: new { controller = "Login", action = "Index" });//dedicated conventional Route
            //app.MapControllers();// for enabling attribute based routing
            app.Run();
        }
    }
}