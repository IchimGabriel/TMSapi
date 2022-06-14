using Application.Common.Interfaces;
using Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Events
{
    public interface IEventPublisher : ITransientService
    {
        Task PublishAsync(IEvent @event);
    }
}
