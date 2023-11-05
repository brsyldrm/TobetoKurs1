using Microsoft.AspNetCore.Mvc;
using TobetoKurs.Models;

namespace TobetoKurs.Controllers
{
    public class JobController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(JobList.jobs);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Job job)
        {
            if (job.Summary?.StartsWith("test_") == false)
            {
                ModelState.AddModelError(string.Empty, "Bazı alanlarda eksik bilgi mevcuttur.");
                ModelState.AddModelError("Summary", "Summary alanı test_ ön eki ile başlamalıdır.");

            }
            if(ModelState.IsValid)
            {
                job.Id = Guid.NewGuid();
                JobList.jobs.Add(job);
                return RedirectToAction("Index");
            }
            return View(job);
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            Job job = JobList.jobs.FirstOrDefault(x=>x.Id == id);
            return View(job);
        }
        [HttpPost]
        public IActionResult Edit(Job job)
        {
            if (job.Summary?.StartsWith("test_") == false)
            {
                ModelState.AddModelError(string.Empty, "Bazı alanlarda eksik bilgi mevcuttur.");
                ModelState.AddModelError("Summary", "Summary alanı test_ ön eki ile başlamalıdır.");

            }
            if (ModelState.IsValid)
            {

                
                return RedirectToAction("Index");
            }
            return View(job);
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            Job job = JobList.jobs.FirstOrDefault(x => x.Id == id);
            return View(job);
        }
        //[HttpPost]
        //public IActionResult Index(Job job)
        //{
        //    return View();
        //}
    }
}
