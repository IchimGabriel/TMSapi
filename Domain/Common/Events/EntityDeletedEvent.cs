using Domain.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Events
{
    public static class EntityDeletedEvent
    {
        public static EntityDeletedEvent<TEntity> WithEntity<TEntity>(TEntity entity)
            where TEntity : IEntity
            => new(entity);
    }

    public class EntityDeletedEvent<TEntity> : DomainEvent
        where TEntity : IEntity
    {
        internal EntityDeletedEvent(TEntity entity) => Entity = entity;

        public TEntity Entity { get; }
    }
}
