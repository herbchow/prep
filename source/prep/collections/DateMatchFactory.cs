using System;
using prep.utility;
using prep.utility.filtering;

namespace prep.collections
{
    public class DateMatchFactory<ItemToFilter,TProperty> : ICreateMatchers<ItemToFilter, TProperty> where TProperty : IComparable<TProperty>
    {
        public IMatchAn<ItemToFilter> equal_to(TProperty value)
        {
            throw new NotImplementedException();
        }

        public IMatchAn<ItemToFilter> equal_to_any(params TProperty[] values)
        {
            throw new NotImplementedException();
        }

        public IMatchAn<ItemToFilter> not_equal_to(TProperty value)
        {
            throw new NotImplementedException();
        }

        public IMatchAn<ItemToFilter> create_using(Condition<ItemToFilter> condition)
        {
            throw new NotImplementedException();
        }

        public IMatchAn<ItemToFilter> create_to_match(IMatchAn<TProperty> criteria)
        {
            throw new NotImplementedException();
        }
    }
}
