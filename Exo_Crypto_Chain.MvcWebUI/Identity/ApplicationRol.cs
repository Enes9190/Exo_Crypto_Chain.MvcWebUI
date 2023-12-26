using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Exo_Crypto_Chain.MvcWebUI.Identity
{
    public class ApplicationRol:IdentityRole
    {
        public string Description {  get; set; }

        public ApplicationRol()
        {

        }
        public ApplicationRol(string rolname,string description)
        {

            this.Description = description;
        }


    }
}