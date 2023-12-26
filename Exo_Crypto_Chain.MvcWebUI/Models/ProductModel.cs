using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exo_Crypto_Chain.MvcWebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public string Image { get; set; }
    }
}