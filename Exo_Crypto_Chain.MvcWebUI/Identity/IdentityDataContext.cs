using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Exo_Crypto_Chain.MvcWebUI.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Exo_Crypto_Chain.MvcWebUI.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationKullanıcı>
    {

        public IdentityDataContext() : base("dataConnection") 
        { 


        }
        
      }  
}