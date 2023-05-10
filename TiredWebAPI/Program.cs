using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TiredWebAPI;
using TiredWebAPI.Data;
using TiredWebAPI.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TiredWebAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TiredWebAPIContext") ?? throw new InvalidOperationException("Connection string 'TiredWebAPIContext' not found.")));


builder.Services.AddScoped<ICustomerRepo,CustomerRepo>();
builder.Services.AddScoped<IAccountRepo,AccountRepo>();



var app = builder.Build();




app.MapGet("/Customers", async (ICustomerRepo repo) =>
{
    return repo.GetCustomers();
});


app.MapGet("/Accounts", async (IAccountRepo repo) =>
{
    return repo.GetBankAccounts();
});

app.MapGet("/Customers/{id}/accounts", async (IAccountRepo repo, int id) =>
{
    return  repo.GetCustomerAccounts(id);
});


app.MapGet("/customer/{id}/total-balance", async (IAccountRepo repo, int id) => {

    return repo.GetTotalBalance(id);
});


app.UseHttpsRedirection();


app.Run();
