using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            var prodacts = new List<Prodact>
            {
                new Prodact
                {
                    Title = "داشبورد تحلیلی",
                    Description = "تحلیل داده‌های کسب‌وکار با نمودارهای تعاملی و گزارش‌های هوشمند",
                    Price = "۲.۵ میلیون تومان",
                    GradientClass = "from-blue-500 to-cyan-500",
                    IconClass = "fa-solid fa-chart-line"
                },
                new Prodact
                {
                    Title = "سیستم CRM",
                    Description = "مدیریت ارتباط با مشتریان و پیگیری فرصت‌های فروش",
                    Price = "۴.۸ میلیون تومان",
                    GradientClass = "from-purple-500 to-pink-500",
                    IconClass = "fa-solid fa-users"
                },
                new Prodact
                {
                    Title = "مدیریت پروژه",
                    Description = "برنامه‌ریزی و پیگیری پروژه‌ها با تیم‌های چندگانه",
                    Price = "۳.۲ میلیون تومان",
                    GradientClass = "from-green-500 to-emerald-500",
                    IconClass = "fa-solid fa-list-check"
                },
                new Prodact
                {
                    Title = "فروشگاه ساز",
                    Description = "راه‌اندازی فروشگاه آنلاین حرفه‌ای با امکانات کامل",
                    Price = "۵.۵ میلیون تومان",
                    GradientClass = "from-orange-500 to-amber-500",
                    IconClass = "fa-solid fa-cart-shopping"
                },
                new Prodact
                {
                    Title = "وبینار پرو",
                    Description = "برگزاری وبینار و کلاس آنلاین با کیفیت بالا",
                    Price = "۱.۹ میلیون تومان",
                    GradientClass = "from-red-500 to-rose-500",
                    IconClass = "fa-solid fa-video"
                },
                new Prodact
                {
                    Title = "هاستینگ ابری",
                    Description = "میزبانی امن و پرسرعت با پشتیبانی ۲۴/۷",
                    Price = "۸۹۰ هزار تومان / ماه",
                    GradientClass = "from-indigo-500 to-violet-500",
                    IconClass = "fa-solid fa-server"
                }


            };
            return View(prodacts);
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}