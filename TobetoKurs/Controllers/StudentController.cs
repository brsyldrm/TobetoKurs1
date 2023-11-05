using Microsoft.AspNetCore.Mvc;
using TobetoKurs.Models;

namespace TobetoKurs.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                Adi = "John",
                Soyadi = "Doe",
                Yas = 35,
                YeniKayitMi = true,
                Sifre = "123456"
            };
            return View(student);
        }
        public IActionResult Details2()
        {
            Student student = new Student
            {
                Adi = "John",
                Soyadi = "Doe",
                Yas = 35,
                YeniKayitMi = true,
                Sifre = "123456"
            };
            return View(student);
        }
    }
}
