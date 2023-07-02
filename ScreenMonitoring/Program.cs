using ScreenMonitoring.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDefaultFiles();
    app.UseStaticFiles();
}

app.UseHttpsRedirection();

app.UseAuthorization();
#region
app.MapGet("api/cpu", () =>
{
    Cpu cpu = new Cpu();
    return Results.Json(cpu);
});

app.MapGet("api/ram", () =>
{
    Ram ram = new Ram();
    return Results.Json(ram);
});

app.MapGet("api/disk", () =>
{
    Disk disk = new Disk();
    return Results.Json(disk);
});
#endregion

app.MapControllers();

app.Run();
