using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.collections
{
    public interface IProvideAccessToComparerDSL<ItemToCompare, PropertyType>
    {
        IComparer<PropertyType> BuildComparer() 
    }
}
