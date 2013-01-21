using System.ComponentModel;
namespace CSTruter.com
{
    [DataObject(true)]
    public class Data
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static HierarchicalCollection GetData()
        {
            HierarchicalCollection collection = new HierarchicalCollection();
            collection.Add(new Hierarchical(1, 0, "Programming Languages"));
            collection.Add(new Hierarchical(2, 1, "Microsoft"));
            collection.Add(new Hierarchical(3, 2, "C#"));
            collection.Add(new Hierarchical(4, 2, "VB.net"));
            collection.Add(new Hierarchical(5, 1, "Open Source"));
            collection.Add(new Hierarchical(6, 5, "Python"));
            collection.Add(new Hierarchical(7, 5, "Ruby"));
            collection.Add(new Hierarchical(8, 5, "PHP"));
            collection.Add(new Hierarchical(9, 5, "Perl"));
            collection.Add(new Hierarchical(10, 5, "Java"));
            collection.Add(new Hierarchical(11, 3, "linQ"));
            collection.Add(new Hierarchical(12, 8, "5.2"));
            collection.Add(new Hierarchical(13, 8, "4.4"));
            return collection;
        }
    }
}