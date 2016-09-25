using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Enums
{
    public enum GenderEnum
    {
        Herr = 0,
        Dam = 1
    }

    public static class Gender
    {
        public static string GetGenderName(int gender)
        {
            return Enum.GetName(typeof(GenderEnum), gender);
        }
    }

}