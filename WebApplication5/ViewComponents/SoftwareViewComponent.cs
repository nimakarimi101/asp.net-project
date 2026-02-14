using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Services;

namespace WebApplication5.ViewComponents
{
    public class SoftwareViewComponent : ViewComponent
    {
        /*
        private readonly ProductService _productService = new ProductService(); 
        */
        public IViewComponentResult Invoke()
        {
            var products = ProductService.GetSoftWareProduct();
            return View("SoftwareProjects", products);
        }
    }
}