using System;
using System.Collections;
using System.Web.UI;
using System.Linq;

namespace CSTruter.com
{
    public class HierarchicalObjectDataSourceView : HierarchicalDataSourceView
    {
        private string _viewPath;
        private HierarchicalCollection _source = new HierarchicalCollection();

        public HierarchicalObjectDataSourceView(HierarchicalObjectDataSource source, string viewPath)
        {
            _viewPath = viewPath;
            CreateCollection(source);
        }

        private void CreateCollection(HierarchicalObjectDataSource source)
        {
            IEnumerable data = source.Select();
            if (data != null)
            {
                foreach (Object dataItem in data)
                {
                    Int32 value = Convert.ToInt32(DataBinder.GetPropertyValue(dataItem, source.DataValueField, null));
                    Int32 parentID = Convert.ToInt32(DataBinder.GetPropertyValue(dataItem, source.DataParentField, null));
                    String text = DataBinder.GetPropertyValue(dataItem, source.DataTextField, null);
                    _source.Add(new Hierarchical(value, parentID, text));
                }
            }
        }

        public override IHierarchicalEnumerable Select()
        {
            HierarchicalCollection collection = new HierarchicalCollection();
            Int32 ParentId = (!String.IsNullOrEmpty(_viewPath)) ? Convert.ToInt32(_viewPath) : 0;

            foreach (Hierarchical Hierarchical in this._source)
            {
                if (Hierarchical.ParentID == ParentId)
                {
                    Hierarchical.source = _source;
                    collection.Add(Hierarchical);
                }
            }
            return collection;
        }
    }
}