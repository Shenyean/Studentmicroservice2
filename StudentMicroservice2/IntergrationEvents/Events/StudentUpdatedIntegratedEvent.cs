using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMicroservice2.IntergrationEvents.Events
{
    public class StudentUpdatedIntegratedEvent
    {
        public int StudentId { get; private set; }
        public string Name { get; private set; }
        public string CcaId { get; private set; }

        public StudentUpdatedIntegratedEvent(int studentId, string name, string ccaId)
        {
            StudentId = studentId;
            Name = name;
            CcaId = ccaId;
        }
    }
}
