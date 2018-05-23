using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace SBear.DataAccess.BaseServices.Dapper
{
    public static class DapperServiceCollectionExtensions
    {
        public static IServiceCollection AddDapperContext<TContext>(this IServiceCollection serviceCollection, ServiceLifetime contextLifetime = ServiceLifetime.Scoped) where TContext : DapperContext
        {
            serviceCollection.TryAdd(new ServiceDescriptor(typeof(TContext), typeof(TContext), contextLifetime));
            return serviceCollection;
        }
    }
}
