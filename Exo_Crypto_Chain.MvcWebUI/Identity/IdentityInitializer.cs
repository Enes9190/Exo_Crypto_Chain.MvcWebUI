using Exo_Crypto_Chain.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Exo_Crypto_Chain.MvcWebUI.Identity
{
    public class IdentityInitializer: CreateDatabaseIfNotExists<IdentityDataContext>
    {

        protected override void Seed(IdentityDataContext context)
        {
            //roller
            if (!context.Roles.Any(i => i.Name == "admin"))
            {

                var store = new RoleStore<ApplicationRol>(context);
                var manager = new RoleManager<ApplicationRol>(store);
                var role = new ApplicationRol{Name="admin",Description= "yönetici rolü"};
                manager.Create(role);
            
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {

                var store = new RoleStore<ApplicationRol>(context);
                var manager = new RoleManager<ApplicationRol>(store);
                var role = new ApplicationRol { Name = "user", Description = "user rolü" };
                manager.Create(role);

            }
            if (!context.Roles.Any(i => i.Name == "enesGuler"))
            {

                var store = new UserStore<ApplicationKullanıcı>(context);
                var manager = new UserManager<ApplicationKullanıcı>(store);
                var user = new ApplicationKullanıcı() {Name="Enes",Surname="Guler",UserName="enesGuler",Email="enes_98_90@hotmail.com"};

             
                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");

            }
            if (!context.Roles.Any(i => i.Name == "esraSenli"))
            {

                var store = new UserStore<ApplicationKullanıcı>(context);
                var manager = new UserManager<ApplicationKullanıcı>(store);
                var user = new ApplicationKullanıcı() { Name = "Esra", Surname = "Senli", UserName = "esraSenli", Email = "esra104@gmail.com" };


                manager.Create(user, "12345678");
                manager.AddToRole(user.Id, "user");

            }

            base.Seed(context);
        }
    }
}