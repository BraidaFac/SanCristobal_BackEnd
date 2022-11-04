using Microsoft.EntityFrameworkCore;
using GSC_BackEnd_TP.DataAccess;
using AutoMapper;
using GSC_BackEnd_TP.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Agregamos los servicios al contenedor de dependencias
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Maper
var mapperConfig = new MapperConfiguration(m =>
{
    m.AddProfile(new MappingProfile());
});
    IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ThingsContext>(options =>
{
    //Para poder utilizar SqlServer necesitamos instalar el paquete
    //Microsoft.EntityFrameworkCore.SqlServer
    options.UseSqlServer(builder.Configuration.GetConnectionString("ThingsContextConnection"));
});
   

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
