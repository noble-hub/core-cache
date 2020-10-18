using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Enyim.Caching.Configuration;

namespace MemCached
{
    internal static class ContainerConfiguration
    {
        public static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
            serviceCollection.AddEnyimMemcached(c => c.Servers = new List<Server>{new Server{Address="localhost", Port=11211}});

            serviceCollection.AddSingleton<ICacheProvider, CacheProvider>();
            serviceCollection.AddSingleton<ICacheRepository, CacheRepository>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}