using System;
using prep.utility.filtering;

namespace prep.collections
{
  public class Where<ItemToFilter>
  {
    public static MatchFactory<ItemToFilter, TProperty> has_a<TProperty>(
      PropertyAccessor<ItemToFilter, TProperty> accessor)
    {
      return new MatchFactory<ItemToFilter, TProperty>(accessor);
    }

    public static ComparableMatchFactory<ItemToFilter, SomeProperty> has_an<SomeProperty>(
      PropertyAccessor<ItemToFilter, SomeProperty> accessor) where SomeProperty : IComparable<SomeProperty>
    {
      return new ComparableMatchFactory<ItemToFilter, SomeProperty>(has_a(accessor));
    }
  }
}