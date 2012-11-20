using System;
using prep.utility.DSL;
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
            foreach(var operation in _range.Operations)
            {
                if( operation.Operation == RangeOperation<T>.GreaterThan)
                {
                    if (!(item.CompareTo(operation.ValueToCompare) > 0))
                        return false;
                }
                else if( operation.Operation == RangeOperation<T>.Equal)
                {
                    if (item.CompareTo(operation.ValueToCompare) != 0)
                        return false;
                }
                else if(operation.Operation == RangeOperation<T>.LessThan)
                {
                    if (!(item.CompareTo(operation.ValueToCompare) < 0))
                        return false;
                }
                else if(operation.Operation == RangeOperation<T>.GreaterThanOrEqual)
                {
                    if (!(item.CompareTo(operation.ValueToCompare) >= 0))
                        return false;
                }
                else if(operation.Operation == RangeOperation<T>.LessThanOrEqual)
                {
                    if (!(item.CompareTo(operation.ValueToCompare) <= 0))
                        return false;
                }
            }
            return true;
        }
    }
}
