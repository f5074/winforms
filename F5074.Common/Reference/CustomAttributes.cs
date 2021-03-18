using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Reference
{
    public class CustomAAttribute : Attribute
    {
        public CustomAAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }

    public class CustomBAttribute : Attribute
    {
    }
}
