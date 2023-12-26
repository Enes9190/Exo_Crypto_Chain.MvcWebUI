using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Exo_Crypto_Chain.MvcWebUI.Identity
{
    public class ApplicationKullanıcı:IdentityUser
    {
       public string Name {  get; set; }
       public string Surname { get; set; }


    }

   
}