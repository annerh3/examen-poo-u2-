using ProyectoExamenU2POO;
var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
var app = builder.Build(); //  Construye la aplicación.
startup.Configure(app, app.Environment);

//using (var scope = app.Services.CreateScope()) // "Servicio Paralelo"
//{
//    var services = scope.ServiceProvider;
//    var loggerFactory = services.GetRequiredService<ILoggerFactory>();

//    try
//    {
//        var context = services.GetRequiredService<ProyectoExamenContext>();
//        await ProyectoExamenSeeder.LoadDataAsync(context, loggerFactory);
//    }
//    catch (Exception e)
//    {
//        var logger = loggerFactory.CreateLogger<Program>();
//        logger.LogError(e, "Error al ejecutar el Seed de datos.");
//    }
//}
app.Run(); 