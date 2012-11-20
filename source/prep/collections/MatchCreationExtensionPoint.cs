using prep.utility.filtering;

namespace prep.collections
{
  public class MatchCreationExtensionPoint<ItemToFilter,PropertyType>
  {
    public PropertyAccessor<ItemToFilter, PropertyType> accessor;
    public bool isNegated = false;

    public MatchCreationExtensionPoint(PropertyAccessor<ItemToFilter, PropertyType> accessor,bool negated = false)
    {
      this.accessor = accessor;
      this.isNegated = negated;
    }

    public MatchCreationExtensionPoint<ItemToFilter,PropertyType> not
    {
        get { return new MatchCreationExtensionPoint<ItemToFilter, PropertyType>(accessor,true); }
    }
  }
}