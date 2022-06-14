using Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Specification
{
    public class EntitiesByPaginationFilterSpec<T, TResult> : EntitiesByBaseFilterSpec<T, TResult>
    {
        public EntitiesByPaginationFilterSpec(PaginationFilter filter)
            : base(filter) =>
            Query.PaginateBy(filter);
    }

    public class EntitiesByPaginationFilterSpec<T> : EntitiesByBaseFilterSpec<T>
    {
        public EntitiesByPaginationFilterSpec(PaginationFilter filter)
            : base(filter) =>
            Query.PaginateBy(filter);
    }
}
