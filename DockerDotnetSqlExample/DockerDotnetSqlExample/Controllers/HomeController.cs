using DockerDotnetSqlExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerDotnetSqlExample.Controllers
{
    public class HomeController : Controller
    {
        private FoodContext context;
        public HomeController(FoodContext mc)
        {
            context = mc;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Food m)
        {
            if (ModelState.IsValid)
            {
                context.Add(m);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            else
                return View();
        }

        public IActionResult Index()
        {
            var m = context.Food.ToList();
            return View(m);
        }

        public IActionResult Update(int id)
        {
            var pc = context.Food.Where(a => a.Id == id).FirstOrDefault();
            return View(pc);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Food m)
        {
            if (ModelState.IsValid)
            {
                context.Update(m);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            else
                return View(m);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var pc = context.Food.Where(a => a.Id == id).FirstOrDefault();
            context.Remove(pc);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}