﻿using Exo_Crypto_Chain.MvcWebUI.Entity;
using Exo_Crypto_Chain.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exo_Crypto_Chain.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private DataContext db = new DataContext();

        public ActionResult Index()
        {
            return View(GetCart());

        }
        public ActionResult AddToCart(int Id)
        {
            var product=db.Products.FirstOrDefault(i=>i.Id == Id);

            if (product!=null) 
            {
                GetCart().AddProduct(product,1);

            }

            return RedirectToAction("Index");

        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);

            }

            return RedirectToAction("Index");

        }
        public Cart GetCart()
        {

            var cart = (Cart)Session["Cart"] ;

            if(cart == null)
            {
                cart = new Cart();
                Session["Cart"]=cart;
            }
        return cart;
        }

        public PartialViewResult Summary()
        {

            return PartialView(GetCart());
        }
    }
}