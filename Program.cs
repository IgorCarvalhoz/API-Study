using API_Study.Context;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<ScheduleContext> (options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("StandardConnection"))
        );
        //We need to add this code to configure the SQL with some options to use SQL Server and the "builder" works to get configuration of the appsettings dev json
        //the "GetConnectionString" recieve the value of connection key (in appsettings dev json) with the name connection.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

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
    }
    //dotnet-ef migrations add MigrationName
}