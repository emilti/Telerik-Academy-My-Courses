namespace TwitterSystem.Api.Infrastructure.Mapping
{
    using System;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using App_Start;
    using System.Linq.Expressions;

    public static class QueryableExtensions
    {
        public static IQueryable<TDestination> To<TDestination>(this IQueryable source, params Expression<Func<TDestination, object>>[] membersToExpand)
        {
            return source.ProjectTo(AutoMapperConfig.Configuration, membersToExpand);
        }
    }
}