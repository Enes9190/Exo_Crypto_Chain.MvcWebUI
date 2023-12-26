
using Exo_Crypto_Chain.MvcWebUI.Entity;
using Exo_Crypto_Chain.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Exo_Crypto_Chain.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context=new DataContext();
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length>120?i.Description.Substring(0,118)+"...":i.Description,
                    Price = i.Price,
                    Stock= i.Stock,
                    CategoryId = i.CategoryId,
                    Image= i.Image,

                }).ToList();

          return View(urunler);

        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 120 ? i.Description.Substring(0, 118) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    CategoryId = i.CategoryId,
                    Image = i.Image,

                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);


            }

            return View(urunler.ToList());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Hakkımızda";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult GetCategories()
        {

            return PartialView(_context.Categories.ToList());

        }
    }
}