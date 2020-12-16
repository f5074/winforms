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
        /// <summary>
        /// ToCaption
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static string ToCaption(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            CaptionAttribute[] attr = fi.GetCustomAttributes(typeof(CaptionAttribute), false) as CaptionAttribute[];
            return attr.Length > 0 ? attr[0].CaptionValue : null;
        }

        /// <summary>
        /// ToWidth
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static int ToWidth(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            WidthAttribute[] attr = fi.GetCustomAttributes(typeof(WidthAttribute), false) as WidthAttribute[];
            return attr.Length > 0 ? attr[0].WidthValue : 0;
        }

        /// <summary>
        /// GetStringValue
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static string GetStringValue(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            StringValueAttribute[] attr = fi.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
            return attr.Length > 0 ? attr[0].StringValue : null;
        }

        /// <summary>
        /// GetIntValue
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static int GetIntValue(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            IntValueAttribute[] attr = fi.GetCustomAttributes(typeof(IntValueAttribute), false) as IntValueAttribute[];
            return attr.Length > 0 ? attr[0].IntValue : 0;
        }

        /// <summary>
        /// HasStringValue
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static bool HasStringValue(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            StringValueAttribute[] attr = fi.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];
            return !attr.IsEmpty();
        }
        /// <summary>
        /// GetAttributeOfType
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_enum"></param>
        /// <returns></returns>

        public static T GetAttributeOfType<T>(this Enum _enum) where T : System.Attribute
        {
            Type t = _enum.GetType();
            var member = t.GetMember(_enum.ToString());
            var attr = member[0].GetCustomAttributes(typeof(T), false);
            return (attr.Length > 0) ? (T)attr[0] : null;
        }

        /// <summary>
        /// GetName
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static string GetName(this Enum _enum)
        {
            Type t = _enum.GetType();
            string eName = Enum.GetName(t, _enum);
            return eName;
        }

        /// <summary>
        /// GetValue
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static int GetValue(this Enum _enum)
        {
            var eValue = Convert.ChangeType(_enum, _enum.GetType());
            return (int)eValue;
        }
    }
}
