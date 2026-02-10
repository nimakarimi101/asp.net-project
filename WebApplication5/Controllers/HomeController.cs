using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ProdactPage()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            var ContactForm = new Contact();
            return View(ContactForm);
        }

        /*[HttpPost]
        public IActionResult ContactUs(IFormCollection form)
        {
            return Json(form["name"]);
        }*/

        [HttpPost]
        public IActionResult ContactUs(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست. لطفا مجددا تلاش کنید.";
                return View( contact);
            }

            ViewBag.Success = "فرم با موفقیت ارسال شد. منتظر تماس همکاران باشید";
            return RedirectToAction("Index");
        }
    }
}