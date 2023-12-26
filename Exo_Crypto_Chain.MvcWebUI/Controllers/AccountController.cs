using Exo_Crypto_Chain.MvcWebUI.Identity;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Exo_Crypto_Chain.MvcWebUI.Models;
using Microsoft.Owin.Security;

namespace Exo_Crypto_Chain.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private UserManager<ApplicationKullanıcı> UserManager;
        private RoleManager<ApplicationRol> RoleManager;

        public AccountController()
        {

            var userStore = new UserStore<ApplicationKullanıcı>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationKullanıcı>(userStore);
            var roleStore = new RoleStore<ApplicationRol>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRol>(roleStore);
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register Model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationKullanıcı();
                user.Name = Model.Name;
                user.Surname = Model.SurName;
                user.Email = Model.Email;
                user.UserName = Model.UserName;

                IdentityResult result = UserManager.Create(user, Model.Password);

                if (result.Succeeded)
                {
                    //rol atanabilir ve kullanıcı oluştı
                    if (RoleManager.RoleExists("User"))
                    {
                        UserManager.AddToRole(user.Id, "User");
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError","Kullanıcı Oluşturma Hatası");
                }


               
            }
            return View(Model);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login Model,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
               //giriş işlemleriii
               var user=UserManager.Find(Model.UserName,Model.Password);

                if(user != null)
                {
                 //kullanıcıyı sisteme aktar dahil et
                    var authManager=HttpContext.GetOwinContext().Authentication;

                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = Model.RememberMe;

                    authManager.SignIn(authProperties,identityclaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);

                    }


                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("LoginrUserError", "Böyle bir kullanıcı bulunamadı!..");
                }

            }
            return View(Model);
        }

        
        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index","Home");
        }
        
    }

}
