using WestMidlandsTravel;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterConfigurations();
// Add services to the container.
builder.Services.AddControllers();
builder.Services.RegisterHttpClients();
builder.Services.AddServices();
builder.Services.AddResponseCaching();


var app = builder.Build();

app.UseResponseCaching();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();