using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class PaginationFilter : BaseFilter
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; } = int.MaxValue;

        public string[]? OrderBy { get; set; }
    }

    public static class PaginationFilterExtensions
    {
        public static bool HasOrderBy(this PaginationFilter filter) =>
            filter.OrderBy?.Any() is true;
    }
}
