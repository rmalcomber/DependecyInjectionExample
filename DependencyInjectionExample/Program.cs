using System;
using DependencyInjectionExample.Interfaces;
using DependencyInjectionExample.Providers;
using DependencyInjectionExample.Writers;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var provider = CreateServiceProvider();

            var writers = provider.GetServices<IWriter>();
            var authorProvider = provider.GetService<IAuthorNameProvider>();

            foreach (var writer in writers)
            {
                TextToWrite.WriteText(writer, authorProvider);
            }

            Console.WriteLine("Application Finished");
            Console.ReadLine();
        }

        private static IServiceProvider CreateServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider =  serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IPathProvider, PathProvider>();
            serviceCollection.AddSingleton<IAuthorNameProvider, AuthorNameProvider>();

            ConfigureWriters(serviceCollection);
        }

        private static void ConfigureWriters(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IWriter, ConsoleWriter>();
            serviceCollection.AddTransient<IWriter, FileWriter>();
        }

    }
}
