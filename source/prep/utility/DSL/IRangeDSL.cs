using System;

namespace prep.utility.ranges
{
    public interface IRangeDSL<TProperty> where TProperty : IComparable<TProperty>
    {
        IRangeDSL<TProperty> GreaterThan(TProperty prop);
        IRangeDSL<TProperty> LessThan(TProperty prop);

        IRangeDSL<TProperty> GreaterThanOrEqual(TProperty prop);
        IRangeDSL<TProperty> LessThanOrEqual(TProperty prop);

        IRangeDSL<TProperty> Equal(TProperty prop);

    }
}
