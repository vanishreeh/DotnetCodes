using BookAPPWithdatabase.AspectOrientedProgramming;
using BookAPPWithdatabase.Context;
using BookAPPWithdatabase.Logginglogic;
using BookAPPWithdatabase.Repository;
using BookAPPWithdatabase.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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
            builder.Services.AddScoped<ILoggerService, LoggerService>();
            //builder.Services.AddAuthentication();
            #region  Configuring custom password Constraints

            //builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
            //{
            //    options.Password.RequiredLength = 8;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = true;
            //}


            //)

            //    .AddEntityFrameworkStores<BookDbContext>();//add or retrieve info about user using EFCore and SQlServer
            #endregion
            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<BookDbContext>();
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
            //Authentication middleware
            app.UseAuthentication();
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