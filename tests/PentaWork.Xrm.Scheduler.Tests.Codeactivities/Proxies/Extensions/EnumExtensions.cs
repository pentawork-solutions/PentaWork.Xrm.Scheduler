using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PentaWork.Xrm.Scheduler.Tests.Codeactivities.Proxies.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumLabel(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes = (LabelAttribute[])fi.GetCustomAttributes(typeof(LabelAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Label;

            return value.ToString();
        }

        public static string GetEnumDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return attributes[0].Description;

            return value.ToString();
        }

        public static Dictionary<int, string> GetOptionSetDisplayNames<T>()
        {
            var optionSetNameList = new Dictionary<int, string>();

            var enumValues = Enum.GetValues(typeof(T));
            foreach (int value in enumValues)
            {
                var enumObj = (Enum)Enum.Parse(typeof(T), value.ToString());
                var enumName = enumObj.GetEnumLabel();
                optionSetNameList.Add(value, enumName);
            }

            return optionSetNameList;
        }
    }
}


