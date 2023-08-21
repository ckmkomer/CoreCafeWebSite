using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.ViewComponents.Contact
{
    public class ContactList:ViewComponent
    {
        ContactInfoManager contactInfoManager = new ContactInfoManager(new EfContactInfoRepository());
        public IViewComponentResult Invoke()
        {
            var values = contactInfoManager.TGetList();
            return View(values);
        }
    }
}
