internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //Uncomment to enable detailed file logging. Filepath is specified in log4net.config
        //builder.Services.AddLogging(loggingBuilder =>
        //{
        //    loggingBuilder.ClearProviders();
        //    loggingBuilder.AddLog4Net("log4net.config");
        //    loggingBuilder.AddFilter("Microsoft", LogLevel.Debug);
        //    loggingBuilder.AddConsole();
        //    loggingBuilder.AddDebug();
        //});

        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();

        var app = builder.Build();

        //app.UseSwagger();
        //app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}