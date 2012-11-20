using System;
using System.Collections.Generic;
using prep.utility.ranges;

namespace prep.utility.DSL
{
    public class RangeDSL<TProperty> : IRangeDSL<TProperty> where TProperty : IComparable<TProperty>
    {
        public class RangeEntry
        {
            public RangeOperation Operation;
            public TProperty ValueToCompare;
        }

        public List<RangeEntry> Operations = new List<RangeEntry>();

        public static RangeDSL<TProperty> Range()
        {
            return new RangeDSL<TProperty>();
        }

        public IRangeDSL<TProperty> GreaterThan(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation.GreaterThan, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> LessThan(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation.LessThan, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> GreaterThanOrEqual(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation.GreaterThanOrEqual, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> LessThanOrEqual(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation.LessThanOrEqual, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> Equal(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation.Equal, ValueToCompare = prop });
            return this;
        }
    }
}
