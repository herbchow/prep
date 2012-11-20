using System;
using System.Collections.Generic;
using prep.utility.ranges;

namespace prep.utility.DSL
{
    public class RangeDSL<TProperty> : IRangeDSL<TProperty> where TProperty : IComparable<TProperty>
    {
        public class RangeEntry
        {
            public RangeOperation<TProperty> Operation;
            public TProperty ValueToCompare;
        }

        public List<RangeEntry> Operations { get; set; }

        // TODO: Return different IRangeDSL implementations to help guide sentence to avoid multiple
        // LessThan or GreaterThan's

        public static RangeDSL<TProperty> Range()
        {
            return new RangeDSL<TProperty>(){Operations = new List<RangeEntry>()};
        }

        public IRangeDSL<TProperty> GreaterThan(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation<TProperty>.GreaterThan, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> LessThan(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation<TProperty>.LessThan, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> GreaterThanOrEqual(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation<TProperty>.GreaterThanOrEqual, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> LessThanOrEqual(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation<TProperty>.LessThanOrEqual, ValueToCompare = prop });
            return this;
        }

        public IRangeDSL<TProperty> Equal(TProperty prop)
        {
            Operations.Add(new RangeEntry { Operation = RangeOperation<TProperty>.Equal, ValueToCompare = prop });
            return this;
        }
    }
}
