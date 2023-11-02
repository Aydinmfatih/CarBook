using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.BusinessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.EntitiyFramework;
using MyAcademyCarBook.EntityLayer.Concrete;
using MyAcademyCarBook.PresentationLayer.Models;

namespace MyAcademyCarBook.PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<CarBookContext>();
            builder.Services.AddScoped<IBrandDal,EfBrandDal>();
            builder.Services.AddScoped<IBrandService,BrandManager>();

            builder.Services.AddScoped<ICarStatusDal, EfCarStatusDal>();
            builder.Services.AddScoped<ICarStatusService, CarStatusManager>();

            builder.Services.AddScoped<ICarDal, EfCarDal>();
            builder.Services.AddScoped<ICarService, CarManager>();

            builder.Services.AddScoped<IPriceDal, EfPriceDal>();
            builder.Services.AddScoped<IPriceService, PriceManager>();

            builder.Services.AddScoped<IServiceDal, EfServiceDal>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();


            builder.Services.AddScoped<IHowItWorkStepDal, EfHowItWorkStepDal>();
            builder.Services.AddScoped<IHowItWorkStepService, HowItWorkStepManager>();


            builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<CarBookContext>().AddErrorDescriber<CustomIdentityValidator>();
            builder.Services.AddControllersWithViews();

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
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Brand}/{action=Index}/{id?}");

            app.Run();
        }
    }
}