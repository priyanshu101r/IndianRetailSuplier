using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IndianRetailSuplier.DATA.Models
{
    [Table("productDetail")]
   public class ProductDetail
    {
        [Key, Column("detailId",Order =1)]
        public int detailId { get; set; }

        [Required]
        public string Number { get; set; }
     
        [Required]
        public int   price { get; set; }
        [Required]
        public int InStock { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string CompanyName { get; set; }
        
        public string  color { get; set; }
       
        public string  size { get; set; }
        public float weight { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

    }
}
