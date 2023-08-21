using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class GalleryController : Controller
    {
        GalleryItemManager galleryItemManager = new GalleryItemManager(new EfGalleryItemRepository());
        public IActionResult Index()
        {
            var values = galleryItemManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGallery()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGallery(GalleryItem gallery)
        {
            galleryItemManager.TAdd(gallery);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteGallery(int id)
        {
            var values = galleryItemManager.TGetByID(id);
            galleryItemManager.TDelete(values);
            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public IActionResult EditGallery(int id)
        //{
        //    var values = galleryItemManager.TGetByID(id);
        //    return View(values);
        //}
        [HttpPost]
        public IActionResult EditChef(GalleryItem gallery)
        {
            galleryItemManager.TUpdate(gallery);
            return RedirectToAction("Index");
        }
    }
}
