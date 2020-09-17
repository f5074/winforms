using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Annotations
{
    public class ValueAttribute
    {

    }

    public class StringValueAttribute : Attribute
    {
        public string StringValue { get; protected set; }

        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }
    }

    public class IntValueAttribute : Attribute
    {
        public int IntValue { get; protected set; }

        public IntValueAttribute(int value)
        {
            this.IntValue = value;
        }
    }
}
