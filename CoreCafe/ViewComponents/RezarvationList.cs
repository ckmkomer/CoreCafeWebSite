using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CafeWebSite.ViewComponents
{
    public class RezarvationList : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }



    }
}