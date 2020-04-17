using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMicroservice2.IntergrationEvents.Events;

namespace StudentMicroservice2.Service
{
    public interface ISimpleEventBusService
    {
        void Publish(StudentCreatedIntegratedEvent studentCreatedIntegratedEvent);
    }
}
