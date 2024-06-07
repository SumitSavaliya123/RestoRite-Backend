using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestoRite_Common.Constants;
using RestoRite_Entities.DTOs.Request;

namespace RestoRite_DataAccessLayer.QueryExtension
{
    public static class ApplyFilterPageQuery
    {
        public static IQueryable<T> ApplyQuery<T>(this IQueryable<T> query, PageRequest request)
        {
            int pageSize = request.PageSize;
            int pageNumber = request.PageNumber;

            if (pageSize < 1) throw new ArgumentOutOfRangeException(nameof(pageSize), ErrorMessages.PAGE_SIZE);
            if (pageNumber < 1) throw new ArgumentOutOfRangeException(nameof(pageNumber), ErrorMessages.PAGE_NUMBER);

            int skip = (pageNumber - 1) * pageSize;

            return
                query
                .Skip(skip)
                .Take(pageSize);
        }
    }
}