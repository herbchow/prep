using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prep.utility.filtering;

namespace prep.collections
{
    public class Sort<ItemToFilter>
    {
        public static IComparer<TProperty> by_descending<TProperty>(
            PropertyAccessor<ItemToFilter,TProperty> accessor) where TProperty : IComparable<TProperty>  
        {
            accessor.Invoke()
            return new DescendingComparer<ItemToFilter,TProperty>(accessor.Invoke);
        }
    }
}
