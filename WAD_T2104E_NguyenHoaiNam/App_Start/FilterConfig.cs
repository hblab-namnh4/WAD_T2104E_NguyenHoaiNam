﻿using System.Web;
using System.Web.Mvc;

namespace WAD_T2104E_NguyenHoaiNam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
