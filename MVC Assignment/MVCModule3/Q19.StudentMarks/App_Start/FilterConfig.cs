﻿using System.Web;
using System.Web.Mvc;

namespace Q19.StudentMarks
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
