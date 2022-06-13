using Domain.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Events
{
    public static class EntityUpdatedEvent
    {
        public static EntityUpdatedEvent<TEntity> WithEntity<TEntity>(TEntity entity)
            where TEntity : IEntity
            => new(entity);
    }

    public class EntityUpdatedEvent<TEntity> : DomainEvent
        where TEntity : IEntity
    {
        internal EntityUpdatedEvent(TEntity entity) => Entity = entity;

        public TEntity Entity { get; }
    }
}
