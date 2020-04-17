using StudentMicroservice2.BuildingBlocks.EventBus.EventBus.Abstraction;

using StudentMicroservice2.BuildingBlocks.EventBus.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMicroservice2.BuildingBlocks.EventBus.EventBusRabbitMQ
{
    public class EventBusRabbitMQ : IEventBus, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Publish(IntegrationEvent @event)
        {
            var eventName = @event.GetType().Name;

        }

        public void Subscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }

        public void SubscribeDynamic<TH>(string eventName) where TH : IDynamicIntegrationEventHandler
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }

        public void UnsubscribeDynamic<TH>(string eventName) where TH : IDynamicIntegrationEventHandler
        {
            throw new NotImplementedException();
        }
    }
}
