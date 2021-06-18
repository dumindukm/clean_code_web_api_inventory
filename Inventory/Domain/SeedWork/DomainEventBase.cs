using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.SeedWork
{
    public class DomainEventBase : IDomainEvent
    {
        public DomainEventBase()
        {
            this.OccurredOn = DateTime.Now;
        }
        public DateTime OccurredOn { get; }
    }
}
