using CourseApp.Infrastructure.Data;
using CourseApp.Infrastructure.Repositories;
using CourseApp.Services;
using CourseApp.Services.Mappings;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Hangfire;
using Hangfire.SqlServer;
using CourseApp.HangfireBackgroundJobs.Schedules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<ICourseRepository, EFCourseRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();
builder.Services.AddScoped<IUserService, UserService>();
//IoC
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddSession(opt =>
{
    opt.IdleTimeout = TimeSpan.FromMinutes(15);
});

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddDbContext<CourseDbContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt =>
                {
                    opt.LoginPath = "/Users/Login";
                    opt.AccessDeniedPath = "/Users/AccessDenied";
                    opt.ReturnUrlParameter = "gidilecekSayfa";
                });


//########## HANGFIRE #################
var hangfireConnectionString = builder.Configuration["ConnectionStrings:HangfireConnection"];
builder.Services.AddHangfire(config =>
{
    var option = new SqlServerStorageOptions
    {
        PrepareSchemaIfNecessary = true,
        QueuePollInterval = TimeSpan.FromMinutes(5),
        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
        UseRecommendedIsolationLevel = true,
        //UsePageLocksOnDequeue = true,
        DisableGlobalLocks = true
    };

    config.UseSqlServerStorage(hangfireConnectionString, option)
          .WithJobExpirationTimeout(TimeSpan.FromHours(6));

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<CourseDbContext>();
context.Database.EnsureCreated();
DbSeeding.SeedDatabase(context);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//########## HANGFIRE #################

app.UseHangfireDashboard("/HangFireExample", new DashboardOptions
{
    DashboardTitle = "Orçun Balatlýoðlu Hangfire DashBoard",  // Dashboard sayfasýna ait Baþlýk alanýný deðiþtiririz.
    AppPath = "/Home",                     // Dashboard üzerinden "back to site" button
    //Authorization = new[] { new HangfireDashboardAuthorizationFilter() },   // Güvenlik için Authorization Ýþlemleri
});
//app.UseHangfireServer();
app.UseHangfireServer(new BackgroundJobServerOptions
{
    SchedulePollingInterval = TimeSpan.FromSeconds(30),

    //Arkaplanda çalýþacak Job sayýsýný deðiþtirebiliriz.
    WorkerCount = Environment.ProcessorCount * 5
});
GlobalJobFilters.Filters.Add(new AutomaticRetryAttribute { Attempts = 7 });
RecurringJobs.HappinessMessage();
app.Run();
