using Domain.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity
{
    public abstract class ApplicationUserEvent : DomainEvent
    {
        public string UserId { get; set; } = default!;

        protected ApplicationUserEvent(string userId) => UserId = userId;
    }

    public class ApplicationUserCreatedEvent : ApplicationUserEvent
    {
        public ApplicationUserCreatedEvent(string userId)
            : base(userId)
        {
        }
    }

    public class ApplicationUserUpdatedEvent : ApplicationUserEvent
    {
        public bool RolesUpdated { get; set; }

        public ApplicationUserUpdatedEvent(string userId, bool rolesUpdated = false)
            : base(userId) =>
            RolesUpdated = rolesUpdated;
    }
}
