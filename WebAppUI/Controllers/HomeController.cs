using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppUI.Models;

namespace WebAppUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productSevice;

        public HomeController(IProductService productService)
        {
            _productSevice = productService;
        }

        public IActionResult Index()
        {

            var produts = new ProductViewModel
            {
                products = _productSevice.GetAll().Where(x=>x.IsDeleted==0).ToList()

            };
            return View(produts);
        }
    }
}
