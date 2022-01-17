using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianRetailSuplier.DATA.Models
{
    [Table("Product")]
   public class Product
   {
        [Key, Column("ProductId", Order = 1)]
        public int Id { get; set; }
        [Required, Column("ProductName")]
        public string  ProductName { get; set; }
        [Required, Column("Description")]
        public string  ProductDescription { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }
   }
}
