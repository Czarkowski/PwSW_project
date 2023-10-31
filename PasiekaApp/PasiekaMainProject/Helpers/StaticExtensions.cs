﻿using PasiekaMainProject.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Helpers
{
    public static class StaticExtensions
    {
        public static bool IsNull(this object obj)
        {
            if (obj == null)
                return true;
            return false;
        }

        public static bool IsEmpty(this ICollection obj)
        {
            if (obj == null || obj.Count == 0)
                return true;
            return false;
        }

        public static bool IsNullOrEmpty(this object obj)
        {
            if (obj.IsNull())
                return true;
            if (obj is ICollection icol && icol.IsEmpty())
                return true;
            return false;
        }

        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var descriptionAttribute = fieldInfo?.GetCustomAttributes(typeof(DescriptionForFormAttribute), false) as DescriptionForFormAttribute[];

            if (descriptionAttribute != null && descriptionAttribute.Length > 0)
            {
                return descriptionAttribute[0].Description;
            }

            return value.ToString();
        }
    }
}
