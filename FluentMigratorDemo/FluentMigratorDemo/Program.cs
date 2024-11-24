using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FluentMigratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = CreateServices();

            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
            //runner.MigrateDown(2024112102);

        }
        public static IServiceProvider CreateServices()
        {
            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(runner => runner
                    .AddSqlServer()
                    .WithGlobalConnectionString("Server=localhost;Database=FluentMigratorDemo;Trusted_Connection=True;TrustServerCertificate=True;")
                    .ScanIn(typeof(Program).Assembly).For.Migrations())
                .BuildServiceProvider();
        }

        
    }
}

