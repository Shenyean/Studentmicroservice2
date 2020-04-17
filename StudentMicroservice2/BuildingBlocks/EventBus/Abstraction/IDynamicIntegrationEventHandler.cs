using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMicroservice2.BuildingBlocks.EventBus.EventBus.Abstraction
{
   public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
