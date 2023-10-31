using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.MyClassAndInterface
{
    public class DSModelForComboBox<T>
    {
        public T Value { get; set; }
        public string Name { get; set; }
        public DSModelForComboBox(T value, string name)
        {
            Value = value;
            Name = name;
        }
        public static List<DSModelForComboBox<T>> GetDSList(List<T> valueList, Func<T, string> nameGenerator)
        {
            var list = new List<DSModelForComboBox<T>>();
            foreach (var item in valueList)
            {
                list.Add(new DSModelForComboBox<T>(item, nameGenerator(item)));
            }
            return list;
        }
    }
}
