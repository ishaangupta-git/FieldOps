using FieldOps.Api.Data;
using FieldOps.Api.Repositories;
using FieldOps.Api.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<DbConnectionFactory>();
builder.Services.AddScoped<WorkOrderRepository>();
builder.Services.AddScoped<WorkOrderService>();

// Register services
builder.Services.AddControllers();


builder.Services.AddOpenApi();

var app = builder.Build();

// Configure HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
