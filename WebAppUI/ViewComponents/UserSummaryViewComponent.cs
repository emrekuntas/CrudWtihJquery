﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebAppUI.Models;

namespace Abc.Northwind.MvcWebUI.ViewComponents
{
    public class UserSummaryViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            UserDetailViewModel model = new UserDetailViewModel
            {
               UserName = HttpContext.User.Identity.Name
            };
            return View(model);
        }
    }
}
