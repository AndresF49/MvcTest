var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}"); // here, default URL segment is home/ with action index
    // whateverController/ then the default ACTION is index
    // first part determines the controller class to run
    // second part determines the action on the controller class
    // the third URL section matches the route parameter id
    // The Welcome method contains a parameter id that matched the URL template in the MapControllerRoute method.
    // The trailing ? (in id?) indicates the id parameter is optional.

app.Run();

