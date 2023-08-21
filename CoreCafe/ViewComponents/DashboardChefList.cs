using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents
{
    public class DashboardChefList:ViewComponent
    {
        ChefManager _chefManager = new ChefManager(new EfChefRepository());

       

        public IViewComponentResult Invoke()
        {
          var values=  _chefManager.TGetList();
            return View(values);
        }
    }
}
