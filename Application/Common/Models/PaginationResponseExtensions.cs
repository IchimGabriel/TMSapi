using Application.Common.Interfaces;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public static class PaginationResponseExtensions
    {
        public static async Task<PaginationResponse<TDestination>> PaginatedListAsync<T, TDestination>(
            this IReadRepositoryBase<T> repository, ISpecification<T, TDestination> spec, int pageNumber, int pageSize, CancellationToken cancellationToken = default)
            where T : class
            where TDestination : class, IDto
        {
            var list = await repository.ListAsync(spec, cancellationToken);
            int count = await repository.CountAsync(spec, cancellationToken);

            return new PaginationResponse<TDestination>(list, count, pageNumber, pageSize);
        }
    }
}
