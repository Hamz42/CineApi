using MC.Cine.BLL.Extensions.ApplicationBuilder;
using MC.Cine.BLL.Extensions.ServiceCollection;
using MC.Cine.BLL.Mappings;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Registro automapper
builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(AutoMapperProfile).Assembly);

//Se añade la configuración de los controller
ControllersConfig.AddControllersExtend(builder.Services);

// Configuración de los logs
builder.Host.UseSerilog();
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.MSSqlServer(
        builder.Configuration.GetConnectionString("ConnectionSirecV2"),
        sinkOptions: new MSSqlServerSinkOptions()
        {
            TableName = "CineApiLog",
            SchemaName = "dbo",
            AutoCreateSqlTable = true
        })
    .CreateLogger();

// Configuración de la autenticación
AuthenticationConfig.AddAuthentication(builder.Services, builder.Configuration);

// Conexión al contexto de DB
DbContextConfig.AddDbContexts(builder.Services, builder.Configuration);

// Contenedor de inversión de control 
IoC.AddDependency(builder.Services, builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

DefaultConfig.InitconfigurationAPI(app, app.Environment);

app.Run();
