using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMicroservice2.BuildingBlocks.EventBus.EventBus.Abstraction
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
    {
        Task Handle(TIntegrationEvent @event);
    }
    public interface IIntegrationEventHandler
    {
    }
}
