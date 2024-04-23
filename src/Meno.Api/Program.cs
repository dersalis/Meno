using Meno.Infrastructure;
using Meno.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication(builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{

}

app.UseInfrastructure();

app.UseHttpsRedirection();


app.Run();
