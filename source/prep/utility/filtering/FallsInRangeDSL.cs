using System;
using prep.utility.ranges;

namespace prep.utility.filtering
{
    public class FallsInRangeDSL<T> : IMatchAn<T> where T : IComparable<T>
    {
        IRangeDSL<T> _range; 

        public FallsInRangeDSL(IRangeDSL<T> range)
        {
            _range = range;
        }

        public bool matches(T item)
        {
            var accumulatedResult = true;
            if (_range.GreaterThanSet)
                accumulatedResult &= item.CompareTo(_range.GreaterThanValue) > 0;
            if (_range.LessThanSet)
                accumulatedResult &= item.CompareTo(_range.LessThanValue) < 0;

            return accumulatedResult;
        }
    }
}
