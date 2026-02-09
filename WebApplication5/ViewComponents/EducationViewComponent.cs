using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var educations = new List<Education>
            {
                new Education("آموزش جامع ASP.NET Core", "یادگیری فریم‌ورک محبوب دات‌نت برای بک‌اند.", "ویژه",
                    "image1.png", 850000),
                new Education("دوره Docker برای برنامه‌نویسان", "مدیریت کانتینرها و استقرار ساده اپلیکیشن.", "جدید",
                    "image2.png",420000),
                new Education("مبانی امنیت در وب", "چگونه اپلیکیشن‌های امن‌تری در دنیای اینترنت بنویسیم.", "مهم",
                    "image3.png",300000),
                new Education("آموزش Clean Architecture", "پیاده‌سازی پروژه‌های بزرگ با ساختار اصولی.", "پیشرفته",
                    "image4.png", 950000),
                new Education("دوره مقدماتی Git", "کنترل نسخه و همکاری تیمی در پروژه‌های نرم‌افزاری.", "رایگان",
                    "image5.png", 0)
            };
            return View("education" , educations);
        }
    }
}