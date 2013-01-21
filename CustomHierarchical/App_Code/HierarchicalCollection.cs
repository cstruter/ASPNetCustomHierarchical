using System.Collections.Generic;
using System.Web.UI;

namespace CSTruter.com
{
    public class HierarchicalCollection : List<Hierarchical>, IHierarchicalEnumerable
    {
        public HierarchicalCollection()
            : base()
        {
        }

        public IHierarchyData GetHierarchyData(object enumeratedItem)
        {
            return enumeratedItem as IHierarchyData;
        }
    }
}