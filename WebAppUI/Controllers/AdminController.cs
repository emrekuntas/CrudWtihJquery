using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAppUI.Models;

namespace WebAppUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IProductService _productSevice;
        Product product = new Product();
        public AdminController(IProductService productService)
        {
            _productSevice = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetProductList()
        {
            var produts = new ProductViewModel
            {
                products = _productSevice.GetAll().Where(x => x.IsDeleted == 0).ToList()

            };

            return Json(produts);
        }

        public JsonResult SaveProduct(ProductViewModel model)
        {
            var result = false;

            if (ModelState.IsValid)
            {
                try
                {
                    product.Id = model.Id;
                    product.Barcode = model.Barcode;
                    product.Description = model.Description;
                    product.Piece = model.Piece;
                    product.ImageUrl = model.ImageUrl;
                    product.Price = model.Price;
                    if (model.Id == 0)
                    {
                        _productSevice.Create(product);
                        result = true;
                    }
                    else
                    {
                        _productSevice.Update(product);
                        result = true;
                    }

                }
                catch (Exception)
                {
                }

            }
            else
            {
                result = false;
            }
            return Json(result);
        }

        public JsonResult GetProductById(int Id)
        {
            return Json(_productSevice.GetById(Id));
        }
        public JsonResult DeleteProductRecord(int Id)
        {
            bool result = false;
            var product = _productSevice.GetById(Id);

            if (product != null)
            {
                product.IsDeleted = 1;
                _productSevice.Update(product);
                result = true;
            }

            return Json(result);
        }
    }
}
