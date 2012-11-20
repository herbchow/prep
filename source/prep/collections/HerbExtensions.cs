using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prep.utility.filtering;

namespace prep.collections
{
    public static class MovieListExtensions
    {
        public static IProvideAccessToFilteringExtensions<ItemToFilter,TProperty> where<ItemToFilter,TProperty>(this IEnumerable<ItemToFilter> self,PropertyAccessor<ItemToFilter, TProperty> accessor)
        {
            throw new NotImplementedException();
        }
    }
}
