using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using PaintingClinic.Server.Services;
using PaintingClinic.Share;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISecurityDbService, SecurityDbService>();
builder.Services.AddSingleton<IClientService, ClientService>();
builder.Services.AddSingleton<ISecurityDbService, SecurityDbService>();
builder.Services.AddSignalR();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks();

var app = builder.Build();

InitializeRoot();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/healthchecks", new HealthCheckOptions
{
    ResultStatusCodes =
        {
            [HealthStatus.Healthy] = StatusCodes.Status200OK,
            [HealthStatus.Degraded] = StatusCodes.Status200OK,
            [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable
        }
});

app.Run();

#region Extra
void InitializeRoot()
{
   
}
#endregion