using IndianRetailSuplier.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Models
{
    public class ProductViewModel
    {
       // public int productId { get; set; }
        public Product Product { get; set; }
        public ProductDetail productDetails { get; set; }
        public ProductImage productImages { get; set; }
    }
}
