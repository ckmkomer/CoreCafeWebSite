﻿using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents.About
{
    public class AboutList :ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
