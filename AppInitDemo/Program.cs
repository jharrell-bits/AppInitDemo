using AppInitDemo.Initializers;

var builder = WebApplication.CreateBuilder(args);

// call ResourceInitializer.Init()
ResourceInitializer.Init(builder);

// call an extension method in Initializers/ServiceCollectionExtensions
builder.Services.AddCustomServices();

// call an extension method in Initializers/ServiceCollectionExtensions
builder.Services.AddCustomSecurity();

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
