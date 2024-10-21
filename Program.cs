using System.Runtime.Versioning;
using Microsoft.OpenApi.Models;
using Serilog;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using UnipPimFazenda.Data;
using Serilog.Events;

namespace UnipPimFazenda
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            Log.Logger = ConfigurarLogger().CreateLogger();
            using var loggerFactory = LoggerFactory.Create(builder => builder.AddSerilog());
            ILogger<Program> printLog = loggerFactory.CreateLogger<Program>();

            try
            {

                var builder = WebApplication.CreateBuilder(args);
                builder.Services.AddControllers();
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PIM Fazenda", Version = "v1" });
                    c.EnableAnnotations();
                });

                builder.Services.AddLogging(config =>
                {
                    config.ClearProviders();
                    config.AddConsole();
                });
                builder.Host.UseSerilog();

                AdicionarBatch(builder);
                AdicionarSingletons(builder);
                AdicionarScoped(builder);
                AdicionarDb(builder);

                builder.WebHost.ConfigureKestrel(serverOptions =>
                {
                    serverOptions.ListenLocalhost(8089);
                });

                var app = builder.Build();

                using (var scope = app.Services.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    dbContext.Database.EnsureCreated();
                    dbContext.Database.Migrate();
                }

                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PIM Fazenda v1"));
                app.UseAuthorization();
                app.UseRouting();
                app.UseStaticFiles();
                app.MapControllers();
                app.MapControllers().WithMetadata(new Microsoft.AspNetCore.Mvc.RouteAttribute("api/v1"));
                app.MapFallbackToFile("/index.html");

                app.Run();
            }
            catch (Exception e)
            {
                printLog.LogDebug(e, "Erro ao iniciar o sistema");
            }
            finally
            {
                printLog.LogInformation("Sistema finalizado");
                Log.CloseAndFlush();
            }

        }

        private static void AdicionarBatch(WebApplicationBuilder builder)
        {
            // builder.Services.AddHostedService<AppBatchService>();
        }

        private static void AdicionarSingletons(WebApplicationBuilder builder)
        {
            // builder.Services.AddSingleton<HttpHelper>();
        }

        private static void AdicionarScoped(WebApplicationBuilder builder)
        {
            // builder.Services.AddScoped<AppService>();
        }


        private static void AdicionarDb(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        }

        public static LoggerConfiguration ConfigurarLogger()
        {
            string dirLogs = @"logs";
            if (!Directory.Exists(dirLogs))
            {
                Directory.CreateDirectory(dirLogs);
            }
            return new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .WriteTo.File(
                path: Path.Combine(dirLogs, "pimfazenda.log"),
                rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
            )
            .Enrich.FromLogContext();
        }
    }
}