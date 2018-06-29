﻿using Microsoft.Extensions.DependencyInjection;
using Ray.Core.MQ;
using Ray.Core;

namespace Ray.RabbitMQ
{
    public static class Extensions
    {
        public static void AddRabbitMQ<W>(this IServiceCollection serviceCollection) where W : IMessageWrapper, new()
        {
            serviceCollection.AddSingleton<IRabbitMQClient, RabbitMQClient>();
            serviceCollection.AddSingleton<IMQServiceContainer, MQServiceContainer<W>>();
            serviceCollection.AddSingleton<ISubManager, RabbitSubManager>();
        }
    }
}
