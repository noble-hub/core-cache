using System.Threading;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace MemCached
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ContainerConfiguration.Configure();

            Console.WriteLine("Set cache");
            var repo = serviceProvider.GetService<ICacheRepository>();
            repo.Save("Key_1", "***First cache value***");

            var provider = serviceProvider.GetService<ICacheProvider>();
            Console.WriteLine($"Cache value for key Key_1 is {provider.Get<string>("Key_1")}");

            Thread.Sleep(1000 * 60);
            Console.WriteLine($"Cache value for key Key_1 is {provider.Get<string>("Key_1")}");

            Console.ReadLine();
        }
    }
}
