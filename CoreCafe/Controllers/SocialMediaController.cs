﻿using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CafeWebSite.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaRepository());
        public IActionResult Index()
        {
            var values = socialMediaManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.TAdd(socialMedia);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            socialMediaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }
    }
}
