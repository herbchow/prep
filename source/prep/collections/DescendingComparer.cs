using System;
using System.Collections.Generic;
using prep.utility.filtering;

namespace prep.collections
{
    public class DescendingComparer<ItemToFilter,PropertyType> : IComparer<ItemToFilter> : where PropertyType : IComparable<PropertyType>
    {
        PropertyAccessor<ItemToFilter, PropertyType> accessor;

        public DescendingComparer(PropertyAccessor<ItemToFilter,PropertyType> accessor )
        {
            this.accessor = accessor;
        }

        public int Compare(ItemToFilter x, ItemToFilter y)
        {
            return accessor.Invoke(y).CompareTo(accessor.Invoke(x));
        }
    }
}
