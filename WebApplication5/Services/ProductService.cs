using System.Collections.Generic;
using System.Linq;

namespace WebApplication5.Services
{
    public class ProductService
    {
        public static List<Product> GetSoftWareProduct()
        {
            return new List<Product>
            {
                new Product(1,"داشبورد تحلیلی", "تحلیل داده‌های کسب‌وکار با نمودارهای تعاملی و گزارش‌های هوشمند", "۲.۵ میلیون تومان", "from-blue-500 to-cyan-500", "fa-solid fa-chart-line"),
                new Product(2,"سیستم CRM", "مدیریت ارتباط با مشتریان و پیگیری فرصت‌های فروش", "۴.۸ میلیون تومان", "from-purple-500 to-pink-500", "fa-solid fa-users"),
                new Product(3,"مدیریت پروژه", "برنامه‌ریزی و پیگیری پروژه‌ها با تیم‌های چندگانه", "۳.۲ میلیون تومان", "from-green-500 to-emerald-500", "fa-solid fa-list-check"),
                new Product(4,"فروشگاه ساز", "راه‌اندازی فروشگاه آنلاین حرفه‌ای با امکانات کامل", "۵.۵ میلیون تومان", "from-orange-500 to-amber-500", "fa-solid fa-cart-shopping"),
                new Product(5,"وبینار پرو", "برگزاری وبینار و کلاس آنلاین با کیفیت بالا", "۱.۹ میلیون تومان", "from-red-500 to-rose-500", "fa-solid fa-video"),
                new Product(6,"هاستینگ ابری", "میزبانی امن و پرسرعت با پشتیبانی ۲۴/۷", "۸۹۰ هزار تومان / ماه", "from-indigo-500 to-violet-500", "fa-solid fa-server")

            };
        }

        public static Product GetProductById(long id)
        {
            return GetSoftWareProduct().FirstOrDefault(x => x.Id == id);
        }
    }
}