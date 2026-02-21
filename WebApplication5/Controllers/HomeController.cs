using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication5.Models;
using WebApplication5.Services;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBContext _dbContext; 
        public HomeController(DBContext dbContext)
        {
             _dbContext = dbContext;
        }

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
                return View(contact);
            }

            ViewBag.Success = "فرم با موفقیت ارسال شد. منتظر تماس همکاران باشید";
            ModelState.Clear();
            return View();
        }




        

        
        public IActionResult RequestDemo(int? id)
        {
            var _Product = ProductService.GetSoftWareProduct();
            var _DemoList = new List<DemoListViewModal>();
            
            foreach (var X in _Product)
            {
                _DemoList.Add(new DemoListViewModal(X.Id, X.Title));
            }

            
            var RequestDemo = new RequestDemoViewModel()
            {
               DemoList = new SelectList(_DemoList, "Id", "Title"),
               DemoSelected = id??0
               
            };
            
            return View(RequestDemo);
        }
        [HttpPost]
        public IActionResult RequestDemo(RequestDemoViewModel model)
        {
            var _DemoList = new List<DemoListViewModal>();
            var _Product = ProductService.GetSoftWareProduct();
            foreach (var X in _Product)
            {
                _DemoList.Add(new DemoListViewModal(X.Id, X.Title));
            }

            var RequestDemo = new RequestDemoViewModel()
            {
                DemoList = new SelectList(_DemoList, "Id", "Title")
            };
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "لطفا مقادیر را به درستی تکمیل کنید";
                return View(model);
            }

            ViewBag.Success = "درخواست شما ثبت شد.";
            ModelState.Clear();
            return View(RequestDemo);
        }
        



        public IActionResult ProjectDetail(long id)
        {
            var Product = ProductService.GetProductById(id);
            return View(Product);
        }


        

        
        
    }
}