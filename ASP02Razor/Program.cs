using ASP02Razor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddSingleton<DataProviderService>();
// AddTransient, AddScoped, AddSingleton
// AddTransient: A new instance is provided every time it is requested.
// AddScoped: A new instance is provided per request.
// AddSingleton: A single instance is provided for the entire application lifetime.
// Dependency Injection (DI) is a design pattern that allows for the decoupling of components and promotes testability and maintainability in applications. In ASP.NET Core, DI is built-in and allows you to inject dependencies into your classes, such as services, repositories, and other components, without having to manually instantiate them. This makes it easier to manage dependencies and promotes a more modular architecture.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
