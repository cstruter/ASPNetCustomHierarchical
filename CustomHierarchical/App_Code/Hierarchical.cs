using System.Web.UI;
using System;

namespace CSTruter.com
{
    public class Hierarchical : IHierarchyData
    {
        public HierarchicalCollection source
        {
            get;
            set;
        }

        public Int32 Value
        {
            get;
            set;
        }

        public Int32 ParentID
        {
            get;
            set;
        }

        public String Text
        {
            get;
            set;
        }

        private Hierarchical()
        {
        }

        public Hierarchical(int value, int parentID, string text)
        {
            this.Value = value;
            this.ParentID = parentID;
            this.Text = text;
        }

        public IHierarchicalEnumerable GetChildren()
        {
            HierarchicalCollection children = new HierarchicalCollection();

            foreach (Hierarchical Hierarchical in this.source)
            {
                if (Hierarchical.ParentID == this.Value)
                {
                    children.Add(Hierarchical);
                }
            }
            return children;
        }

        public IHierarchyData GetParent()
        {
            foreach (Hierarchical Hierarchical in this.source)
            {
                if (Hierarchical.Value == this.ParentID)
                    return Hierarchical;
            }
            return null;
        }

        public bool HasChildren
        {
            get
            {
                HierarchicalCollection children = GetChildren() as HierarchicalCollection;
                return children.Count > 0;
            }
        }

        public object Item
        {
            get { return this; }
        }

        public string Path
        {
            get { return this.Value.ToString(); }
        }

        public string Type
        {
            get { return this.GetType().ToString(); }
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}