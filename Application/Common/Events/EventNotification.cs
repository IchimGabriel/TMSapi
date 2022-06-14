using MediatR;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Events
{
    public class EventNotification<TEvent> : INotification
    where TEvent : IEvent
    {
        public EventNotification(TEvent @event) => Event = @event;

        public TEvent Event { get; }
    }
}
