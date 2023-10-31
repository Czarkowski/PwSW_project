using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Annotations
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class DescriptionForFormAttribute: Attribute
    {
        public string Description { get; }

        public DescriptionForFormAttribute(string description)
        {
            Description = description;
        }
    }
}
