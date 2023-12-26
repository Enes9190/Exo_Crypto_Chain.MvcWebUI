using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exo_Crypto_Chain.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Kripto Para Adı")]
        [StringLength(maximumLength:18,ErrorMessage ="En fazla 18 karakter girebilirsiniz!...")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }   
    }
}