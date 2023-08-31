using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUof;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.AnnouncementDto;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using TraversalPro.CQRS.Handlers.DestinationHandlers;
using TraversalPro.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<GetAllDestinationQueryHandler>();
builder.Services.AddScoped<GetDestinationByIDQueryHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<RemoveDestinationCommandHandler>();
builder.Services.AddScoped<UpdateDestinationCommandHandler>();

builder.Services.AddMediatR(typeof(Program));

builder.Services.AddLogging(x =>
{
    x.ClearProviders();
    x.SetMinimumLevel(LogLevel.Debug);
    x.AddDebug();
});

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();

builder.Services.AddHttpClient();

builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();

builder.Services.AddScoped<IDestinationService, DestinationManager>();
builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();

builder.Services.AddScoped<IAppUserSevice, AppUserManager>();
builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();

builder.Services.AddScoped<IReservationService, ReservationManager>();
builder.Services.AddScoped<IReservationDal, EfReservationDal>();

builder.Services.AddScoped<IGuideService, GuideManager>();
builder.Services.AddScoped<IGuideDal, EfGuideDal>();

builder.Services.AddScoped<IContactUsService, ContactUsManager>();
builder.Services.AddScoped<IContactUsDal, EfContactUsDal>();

builder.Services.AddScoped<IAnnouncementService, AnnouncementManager>();
builder.Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

builder.Services.AddScoped<IAccountService, AccountManager>();
builder.Services.AddScoped<IAccountDal, EfAccountDal>();

builder.Services.AddScoped<IUowDal, UowDal>();

// Add services to the container.

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();

builder.Services.AddControllersWithViews().AddFluentValidation();

//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.LoginPath = "/Login/SignIn/";
//});
builder.Services.AddLocalization(opt =>
{
    opt.ResourcesPath = "Resources";
});
builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.SetDefaultCulture("fr");
    options.AddSupportedUICultures("tr", "en", "fr");
    options.FallBackToParentUICultures = true;
    options.RequestCultureProviders.Clear();
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser()
//    .Build();
//    config.Filters.Add(new AuthorizeFilter(policy));

//app.UseRequestLocalization();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

//var suppertedCultures = new[] { "en", "fr", "es", "gr", "tr", "de" };
//var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(suppertedCultures[1]).AddSupportedCultures(suppertedCultures).AddSupportedUICultures(suppertedCultures);
//app.UseRequestLocalization(localizationOptions);
//builder.Services.Configure<RequestLocalizationOptions>(options =>
//{
//    options.SetDefaultCulture("fr");
//    options.AddSupportedUICultures("tr", "en", "fr");
//    options.FallBackToParentUICultures = true;
//    options.RequestCultureProviders.Clear();
//});

//app.UseRequestLocalization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
     name: "default",
     pattern: "{controller=Default}/{action=Index}/{id?}"); //Destination

    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
});
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//    name: "areas",
//    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
//});
//app.UseEndpoints(endpoints => ilk açtýðýmýzda signýn yönlendirmesi yapýcaz
//{
//    endpoints.MapControllerRoute(
//            name: "signin",
//            pattern: "/SignIn",
//            defaults: new { controller = "Login", action = "SignIn" });
//});
app.Run();