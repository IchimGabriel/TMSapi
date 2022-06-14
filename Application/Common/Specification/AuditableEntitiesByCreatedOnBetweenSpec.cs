using Ardalis.Specification;
using Domain.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Specification
{
    public class AuditableEntitiesByCreatedOnBetweenSpec<T> : Specification<T>
    where T : AuditableEntity
    {
        public AuditableEntitiesByCreatedOnBetweenSpec(DateTime from, DateTime until) =>
            Query.Where(e => e.CreatedOn >= from && e.CreatedOn <= until);
    }
}
