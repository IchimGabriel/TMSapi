using MediatR;
using Shared.Events;

namespace Application.Common.Events
{
    public interface IEventNotificationHandler<TEvent> : INotificationHandler<EventNotification<TEvent>>
    where TEvent : IEvent
    {
    }

    public abstract class EventNotificationHandler<TEvent> : INotificationHandler<EventNotification<TEvent>>
        where TEvent : IEvent
    {
        public Task Handle(EventNotification<TEvent> notification, CancellationToken cancellationToken) =>
            Handle(notification.Event, cancellationToken);

        public abstract Task Handle(TEvent @event, CancellationToken cancellationToken);
    }
}
