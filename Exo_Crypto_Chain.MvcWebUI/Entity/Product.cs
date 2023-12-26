using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Exo_Crypto_Chain.MvcWebUI.Entity
{
    public class Product
    {

        public int Id { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public string Image {  get; set; }
        [DisplayName("Kripto Para")]
        public string Name { get; set;}
        [DisplayName("Açıklama")]
        public string Description { get; set;}
        public int CategoryId { get; set; }
        public Category Category{ get; set;}
    }
}