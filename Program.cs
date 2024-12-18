using DogAdoption.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DogAdoption.Data;
using DogAdoption.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<MessageContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MessageContext") ?? throw new InvalidOperationException("Connection string 'MessageContext' not found.")));
builder.Services.AddDbContextFactory<DogAdoptionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DogAdoptionContext") ?? throw new InvalidOperationException("Connection string 'DogAdoptionContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddSingleton<IUserService, AdminService>();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
