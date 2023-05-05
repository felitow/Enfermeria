using Enfer.Shared.DTOS;

namespace Enfer.API.Helpers
{
    public static class QueryableExtensions
    {

        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable,
            PaginationDTO pagination)
        {
            return queryable
                .Skip((pagination.Page - 1) * pagination.RecordsNumber)
                .Take(pagination.RecordsNumber);
        }

    }
}
