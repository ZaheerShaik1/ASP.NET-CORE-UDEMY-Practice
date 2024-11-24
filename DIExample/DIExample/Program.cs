using Services;
using ServiceContracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//builder.Services.Add(new ServiceDescriptor(
//    typeof(ICitiesService),
//    typeof(CitiesService),
//    ServiceLifetime.Singleton
//    //ServiceLifetime.Transient
//    ));
builder.Services.AddSingleton<ICitiesService, CitiesService>();
builder.Services.AddTransient<ICitiesService, CitiesService>();
//builder.Services.AddScoped<ICitiesService,CitiesService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();


app.Run();
