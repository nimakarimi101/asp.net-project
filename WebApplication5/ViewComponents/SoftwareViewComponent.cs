using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.ViewComponents
{
    public class SoftwareViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var products = new List<Prodact>
            {
                new Prodact("داشبورد تحلیلی", "تحلیل داده‌های کسب‌وکار با نمودارهای تعاملی و گزارش‌های هوشمند", "۲.۵ میلیون تومان", "from-blue-500 to-cyan-500", "fa-solid fa-chart-line"),
                new Prodact("سیستم CRM", "مدیریت ارتباط با مشتریان و پیگیری فرصت‌های فروش", "۴.۸ میلیون تومان", "from-purple-500 to-pink-500", "fa-solid fa-users"),
                new Prodact("مدیریت پروژه", "برنامه‌ریزی و پیگیری پروژه‌ها با تیم‌های چندگانه", "۳.۲ میلیون تومان", "from-green-500 to-emerald-500", "fa-solid fa-list-check"),
                new Prodact("فروشگاه ساز", "راه‌اندازی فروشگاه آنلاین حرفه‌ای با امکانات کامل", "۵.۵ میلیون تومان", "from-orange-500 to-amber-500", "fa-solid fa-cart-shopping"),
                new Prodact("وبینار پرو", "برگزاری وبینار و کلاس آنلاین با کیفیت بالا", "۱.۹ میلیون تومان", "from-red-500 to-rose-500", "fa-solid fa-video"),
                new Prodact("هاستینگ ابری", "میزبانی امن و پرسرعت با پشتیبانی ۲۴/۷", "۸۹۰ هزار تومان / ماه", "from-indigo-500 to-violet-500", "fa-solid fa-server")
            };
            return View("SoftwareProjects", products);
        }
    }
}