//Сайт - Sokolov Development Studio
//-------------------------------------------------------------------------------------------------------------------------------------------------

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddHostedService<GeneralStatistics>();

//-------------------------------------------------------------------------------------------------------------------------------------------------

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Pages/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

//-------------------------------------------------------------------------------------------------------------------------------------------------

app.MapControllerRoute(
    name: "HomePage",
    pattern: "{controller=Pages}/{action=HomePage}/{id?}");

app.MapControllerRoute(
    name: "NovelPage",
    pattern: "{controller=Pages}/{action=NovelPage}/{id?}");

app.MapControllerRoute(
    name: "GameCreationPage",
    pattern: "{controller=Pages}/{action=GameCreationPage}/{id?}");

app.MapControllerRoute(
    name: "NovelDesignerPage",
    pattern: "{controller=Pages}/{action=NovelDesignerPage}/{id?}");

app.MapControllerRoute(
    name: "SiteDevelopmentPage",
    pattern: "{controller=Pages}/{action=SiteDevelopmentPage}/{id?}");

app.MapControllerRoute(
    name: "TelegramBotDevelopment",
    pattern: "{controller=Pages}/{action=TelegramBotDevelopment}/{id?}");

app.MapControllerRoute(
    name: "SoftwareDevelopmentPage",
    pattern: "{controller=Pages}/{action=SoftwareDevelopmentPage}/{id?}");

app.MapControllerRoute(
    name: "DesignServicePage",
    pattern: "{controller=Pages}/{action=DesignServicePage}/{id?}");

//-------------------------------------------------------------------------------------------------------------------------------------------------

app.Run();

//-------------------------------------------------------------------------------------------------------------------------------------------------
