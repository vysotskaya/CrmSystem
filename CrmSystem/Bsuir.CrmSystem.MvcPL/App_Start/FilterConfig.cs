﻿using System.Web.Mvc;

namespace Bsuir.CrmSystem.MvcPL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
