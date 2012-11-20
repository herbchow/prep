using System;

namespace prep.utility.DSL
{
    public class RangeOperation<TProperty> where TProperty : IComparable<TProperty>
    {
        public delegate bool OperationOverride(TProperty value);

        public static readonly RangeOperation<TProperty> LessThan = new RangeOperation<TProperty>(){ OperationOverride = { x => x.CompareTo()}};
        public static readonly RangeOperation<TProperty> GreaterThan = new RangeOperation<TProperty>();
        public static readonly RangeOperation<TProperty> LessThanOrEqual = new RangeOperation<TProperty>();
        public static readonly RangeOperation<TProperty> GreaterThanOrEqual = new RangeOperation<TProperty>();
        public static readonly RangeOperation<TProperty> Equal = new RangeOperation<TProperty>();
    }
}
