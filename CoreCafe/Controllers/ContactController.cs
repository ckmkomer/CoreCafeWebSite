using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class ContactController : Controller
    {
        ContactInfoManager _contactınfoManager = new ContactInfoManager(new EfContactInfoRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var values = _contactınfoManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(ContactInfo contact)
        {
        _contactınfoManager.TUpdate(contact);
            return RedirectToAction("Index");
        }
    }
}
