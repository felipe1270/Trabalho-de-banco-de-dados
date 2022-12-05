using Microsoft.EntityFrameworkCore;
using trabalho_banco_de_dados.dados;
using trabalho_banco_de_dados.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BancoContext>(options =>options.UseSqlServer(@"Server=./;Database=DB_GerenciadorDeTCC;User ID=sa;Password=97809444; TrustServerCertificate=True"));
builder.Services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
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
 