using Microsoft.EntityFrameworkCore;
using mvcDesignTemp.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer("Server=WIN-0F0TGHD6FSA\\SQLEXPRESS;Database=AlmazMvc;Trusted_connection=true;Integrated security=true;Encrypt=false");
});

var app = builder.Build();
app.UseStaticFiles();


app.MapControllerRoute(


    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}");

app.Run();
