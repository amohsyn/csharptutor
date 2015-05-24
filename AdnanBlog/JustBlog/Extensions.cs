using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace JustBlog
{
    public static class Extensions
    {
        public static string ToConfigLocalTime(this DateTime utcDT)
        {
            var istTZ = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id);
            return String.Format("{0}", TimeZoneInfo.ConvertTimeFromUtc(utcDT, istTZ).ToShortDateString());
        }
    }
}