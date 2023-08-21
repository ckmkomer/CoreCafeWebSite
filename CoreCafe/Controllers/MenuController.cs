using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class MenuController : Controller
    {
        MenuItemManager menuItemManager = new MenuItemManager(new EfMenuItemRepository());
        public IActionResult Index()
        {
            var values = menuItemManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddMenu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMenu(MenuItem menu)
        {
            menuItemManager.TAdd(menu);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMenu(int id)
        {
            var values = menuItemManager.TGetByID(id);
            menuItemManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditMenu(int id)
        {
            var values = menuItemManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditMenu(MenuItem menu)
        {
           menuItemManager.TUpdate(menu);
            return RedirectToAction("Index");
        }
    }
}
