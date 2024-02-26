using HamburgaoDoGeorjao.DAO.Regras;
using Microsoft.AspNetCore.Authentication.Cookies;
using RegrasDeNegocios.Regras;
using RegrasDeNegocios.Servi�os;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adicionar servi�os de cria��o do HttpClient 
builder.Services.AddHttpClient();
builder.services.

// Adicionar schema de autentica��o
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = "/Login/Index"; // Defenir p�gina de login
    options.LogoutPath = "/Login/Logout"; // Defenir p�gina logout
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();


