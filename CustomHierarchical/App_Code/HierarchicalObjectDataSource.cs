using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSTruter.com
{
    public class HierarchicalObjectDataSource : ObjectDataSource, IHierarchicalDataSource
    {
        public event EventHandler DataSourceChanged;

        public String DataTextField
        {
            get;
            set;
        }

        public String DataValueField
        {
            get;
            set;
        }

        public String DataParentField
        {
            get;
            set;
        }

        public HierarchicalDataSourceView GetHierarchicalView(string viewPath)
        {
            return new HierarchicalObjectDataSourceView(this, viewPath);
        }
    }
}