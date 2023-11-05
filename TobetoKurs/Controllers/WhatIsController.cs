using Microsoft.AspNetCore.Mvc;
using TobetoKurs.Models;

namespace TobetoKurs.Controllers
{
    public class WhatIsController : Controller
    {
        public IActionResult RazorSyntax()
        {
            return View();
        }
        public IActionResult HtmlHelpers()
        {
            Student student = new Student()
            {
                Adi = "John"
            };
            return View(student);
        }

        public IActionResult ViewBagViewDataTempData()
        {
            ViewBag.NameSurname = "Murat Başeren";
            ViewBag.PostalCode = 80000;

            ViewData["FullName"] = "John Doe";
            ViewData["IsActive"] = true;

            TempData["TempNumber"] = 123;
            return View();
        }

        public IActionResult ViewBagViewDataTempData2()
        {
            return View();
        }

    }
}
