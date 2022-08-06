using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Plugins.DataStore.InMemory;
using TicketManagementSystem.Data;
using UseCases;
using UseCases.CompaniesUseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<ICompanyRepository, CompanyInMemoryRepository>();

//Injection of Dependencies for In-Memory Data Store
builder.Services.AddScoped<ICompanyRepository, CompanyInMemoryRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectInMemoryRepository>();


//Injection of Dependencies for Use Cases and Repositories
builder.Services.AddTransient<IViewCompaniesUseCase, ViewCompaniesUseCase>();
builder.Services.AddTransient<IAddCompanyUseCase, AddCompanyUseCase>(); 
builder.Services.AddTransient<IEditCompanyUseCase, EditCompanyUseCase>();
builder.Services.AddTransient<IGetCompanyByIdUseCase, GetCompanyByIdUseCase>();
builder.Services.AddTransient<IDeleteCompanyUseCase, DeleteCompanyUseCase>();
builder.Services.AddTransient<IViewProjectsUseCase, ViewProjectsUseCase>();



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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
