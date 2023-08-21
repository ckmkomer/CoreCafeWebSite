using BussinesLayer.Abstract;
using BussinesLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();




//var connectionString = builder.Configuration.GetConnectionString("DbCon");
//builder.Services.AddDbContext<Context>(x => x.UseSqlServer(connectionString));
var app = builder.Build();

//builder.Services.AddScoped<IAboutDal, EfAboutRepository>();
//builder.Services.AddScoped<IAboutService, AboutManager>();

//builder.Services.AddScoped<ICategoryMenuDal, EfCategoryMenuRepository>();
//builder.Services.AddScoped<ICategoryMenuService, CategoryMenuManager>();

//builder.Services.AddScoped<IChefDal, EfChefRepository>();
//builder.Services.AddScoped<IChefService, ChefManager>();

//builder.Services.AddScoped<IContactInfoDal, EfContactInfoRepository>();
//builder.Services.AddScoped<IContactInfoService, ContactInfoManager>();

//builder.Services.AddScoped<IGalleryItemDal, EfGalleryItemRepository>();
//builder.Services.AddScoped<IGalleryItemService, GalleryItemManager>();

//builder.Services.AddScoped<IMenutemDal, EfMenuItemRepository>();
//builder.Services.AddScoped<IMenuItemService, MenuItemManager>();

//builder.Services.AddScoped<IGalleryItemDal, EfGalleryItemRepository>();
//builder.Services.AddScoped<IGalleryItemService, GalleryItemManager>();

//builder.Services.AddScoped<IReservationDal, EfReservationRepository>();
//builder.Services.AddScoped<IReservationService, ReservationManager>();

//builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaRepository>();
//builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();

//builder.Services.AddScoped<ISpecialMealOfferDal, EfSpecialMealOfferRepository>();
//builder.Services.AddScoped<ISpecialMealOfferService, SpecialMealOfferManager>();


//var app = builder.Build();

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
    pattern: "{controller=Default}/{action=Index}/{id?}");



app.Run();
