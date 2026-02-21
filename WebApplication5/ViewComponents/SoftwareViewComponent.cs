using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.ViewComponents
{
    public class SoftwareViewComponent : ViewComponent
    {
        /*
        private readonly ProductService _productService = new ProductService(); 
        */
        private readonly DBContext _dbContext; 
        public SoftwareViewComponent(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var products = _dbContext.Products.ToList();
            return View("SoftwareProjects", products);
        }
    }
}