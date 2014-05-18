using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facebook.Models.Enums;

namespace Facebook.Extensions
{
    public static class TranslatorExtensions
    {
        public static ColorScheme ToColorScheme(this byte colorScheme)
        {
            return (ColorScheme)Enum.ToObject(typeof(ColorScheme), colorScheme);
        }
    }
}