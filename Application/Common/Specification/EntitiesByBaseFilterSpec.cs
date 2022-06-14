using Application.Common.Models;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Specification
{
    public class EntitiesByBaseFilterSpec<T, TResult> : Specification<T, TResult>
    {
        public EntitiesByBaseFilterSpec(BaseFilter filter) =>
            Query.SearchBy(filter);
    }

    public class EntitiesByBaseFilterSpec<T> : Specification<T>
    {
        public EntitiesByBaseFilterSpec(BaseFilter filter) =>
            Query.SearchBy(filter);
    }
}
