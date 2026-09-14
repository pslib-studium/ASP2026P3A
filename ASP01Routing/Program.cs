var builder = WebApplication.CreateBuilder(args); // inicializace builderu pro webovou aplikaci

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// routovací kaskáda middleware, která zajišťuje směrování požadavků na správné koncové body
app.UseHttpsRedirection(); // přesměrování HTTP požadavků na HTTPS

app.UseRouting(); // povolení směrování požadavků na koncové body

app.UseAuthorization(); // povolení autorizace pro koncové body
/*
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
    endpoints.MapGet("/ahoj", async context =>
    {
        await context.Response.WriteAsync("Ahoj.");
    });
    endpoints.MapGet("/ahoj/{name}", async context =>
    {
        var name = context.Request.RouteValues["name"];
        await context.Response.WriteAsync($"Ahoj, {name}!");
    });
}
);
*/
app.MapStaticAssets(); // mapuje obsah ve složce wwwroot
app.MapRazorPages()
   .WithStaticAssets();
// konec kaskády
app.Run(); // spuštění aplikace
