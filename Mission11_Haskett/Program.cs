using Microsoft.EntityFrameworkCore;
using Mission11_Haskett.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OnlineBookstoreContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:BookConnection"]);
});

builder.Services.AddScoped<IBookRepository, EFBookRepository>();

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

app.MapControllerRoute("pagination", "Books/{pageNum}", new {Controller = "Home", action = "Index" }); // Set up the name and pattern for the pages so that the user can see which page they are on

app.MapDefaultControllerRoute(); // Basically like an if statement that goes to the defauly

app.Run();
