using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using F5074.Common.Annotations;

namespace F5074.Common.Extension
{
    public static class EnumExtension
    {
        public static string GetStringValue(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            StringValueAttribute[] attr = fi.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
            return attr.Length > 0 ? attr[0].StringValue : null;
        }

        public static int GetIntValue(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            IntValueAttribute[] attr = fi.GetCustomAttributes(typeof(IntValueAttribute), false) as IntValueAttribute[];
            return attr.Length > 0 ? attr[0].IntValue : 0;
        }

        public static bool HasStringValue(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            StringValueAttribute[] attr = fi.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
            return !attr.IsEmpty();
        }

        public static T GetAttributeOfType<T>(this Enum _enum) where T : System.Attribute
        {
            Type t = _enum.GetType();
            var member = t.GetMember(_enum.ToString());
            var attr = member[0].GetCustomAttributes(typeof(T), false);
            return (attr.Length > 0) ? (T)attr[0] : null;
        }

        public static string GetName(this Enum _enum)
        {
            Type t = _enum.GetType();
            string eName = Enum.GetName(t, _enum);
            return eName;
        }

        public static int GetValue(this Enum _enum)
        {
            var eValue = Convert.ChangeType(_enum, _enum.GetType());
            return (int)eValue;
        }
    }
}
