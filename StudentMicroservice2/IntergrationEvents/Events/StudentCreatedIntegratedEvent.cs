using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentMicroservice2.BuildingBlocks.EventBus.EventBus.Events;

namespace StudentMicroservice2.IntergrationEvents.Events
{
    public class StudentCreatedIntegratedEvent : IntegrationEvent
    {
        public int StudentId { get; private set; }
        public string Name { get; private set; }
        public StudentCreatedIntegratedEvent(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
    }
}
