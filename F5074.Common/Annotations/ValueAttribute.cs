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

    public class CaptionAttribute : Attribute {
        public string CaptionValue { get; protected set; }

        public CaptionAttribute(string value)
        {
            this.CaptionValue = value;
        }
    }

    public class WidthAttribute : Attribute {
        public int WidthValue { get; protected set; }

        public WidthAttribute(int value)
        {
            this.WidthValue = value;
        }
    }
}
