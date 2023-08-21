using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents
{
    public class DashboardGalleryList:ViewComponent
    {
        GalleryItemManager galleryItemManager = new GalleryItemManager(new EfGalleryItemRepository());
        public IViewComponentResult Invoke()
        {
            var values = galleryItemManager.TGetList();
            return View(values);
        }
    }
}
