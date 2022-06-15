using Application.Common.Events;
using Application.Common.Interfaces;
using MediatR;
using Shared.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Notifications
{
    public class SendEventNotificationToClientsHandler<TNotification> : INotificationHandler<TNotification>
    where TNotification : INotification
    {
        private readonly INotificationSender _notifications;

        public SendEventNotificationToClientsHandler(INotificationSender notifications) =>
            _notifications = notifications;

        public Task Handle(TNotification notification, CancellationToken cancellationToken)
        {
            var notificationType = typeof(TNotification);
            if (notificationType.IsGenericType
                && notificationType.GetGenericTypeDefinition() == typeof(EventNotification<>)
                && notificationType.GetGenericArguments()[0] is { } eventType
                && eventType.IsAssignableTo(typeof(INotificationMessage)))
            {
                INotificationMessage notificationMessage = ((dynamic)notification).Event;
                return _notifications.SendToAllAsync(notificationMessage, cancellationToken);
            }

            return Task.CompletedTask;
        }
    }
}
