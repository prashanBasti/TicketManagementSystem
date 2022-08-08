using FluentAssertions.Common;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.InMemory;
using Plugins.DataStore.SQL;
using TicketManagementSystem.Data;
using UseCases;
using UseCases.CompaniesUseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.TicketsUseCases;
using UseCases.UseCaseInterfaces;
using UseCases.UsersUseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//builder.Services.AddDbContext<ManagementContext>(options =>
//{
//    options.UseSqlServer(Configuration.GetConnectionString(DefaultConnection));
//});


//Injection of Dependencies for In-Memory Data Store
builder.Services.AddScoped<ICompanyRepository, CompanyInMemoryRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectInMemoryRepository>();
builder.Services.AddScoped<IUserRepository, UserInMemoryRepository>();
builder.Services.AddScoped<ITicketRepository, TicketInMemoryRepository>();



//Injection of Dependencies for Use Cases and Repositories
builder.Services.AddTransient<IViewCompaniesUseCase, ViewCompaniesUseCase>();
builder.Services.AddTransient<IAddCompanyUseCase, AddCompanyUseCase>(); 
builder.Services.AddTransient<IEditCompanyUseCase, EditCompanyUseCase>();
builder.Services.AddTransient<IGetCompanyByIdUseCase, GetCompanyByIdUseCase>();
builder.Services.AddTransient<IDeleteCompanyUseCase, DeleteCompanyUseCase>();

builder.Services.AddTransient<IViewProjectsUseCase, ViewProjectsUseCase>();
builder.Services.AddTransient<IAddProjectUseCase, AddProjectUseCase>(); 
builder.Services.AddTransient<IEditProjectUseCase, EditProjectUseCase>();
builder.Services.AddTransient<IGetProjectByIdUseCase, GetProjectByIdUseCase>();
builder.Services.AddTransient<IDeleteProjectUseCase, DeleteProjectUseCase>();

builder.Services.AddTransient<IAddUserUseCase, AddUserUseCase>();
builder.Services.AddTransient<IViewUsersUseCase, ViewUsersUseCase>(); 
builder.Services.AddTransient<IEditUserUseCase, EditUserUseCase>(); 
builder.Services.AddTransient<IDeleteUserUseCase, DeleteUserUseCase>();
builder.Services.AddTransient<IGetUserByIdUseCase, GetUserByIdUseCase>();

builder.Services.AddTransient<IAddTicketUseCase, AddTicketUseCase>();   
builder.Services.AddTransient<IViewTicketUseCase, ViewTicketUseCase>(); 
builder.Services.AddTransient<IEditTicketUseCase, EditTicketUseCase>(); 
builder.Services.AddTransient<IDeleteTicketUseCase, DeleteTicketUseCase>();
builder.Services.AddTransient<IGetTicketByIdUseCase, GetTicketByIdUseCase>();

//builder.Services.AddTransient<IGetTransactionsUseCase, GetTransactionsUseCase>();



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
