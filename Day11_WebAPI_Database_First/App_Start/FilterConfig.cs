﻿using System.Web;
using System.Web.Mvc;

namespace Day11_WebAPI_Database_First
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
