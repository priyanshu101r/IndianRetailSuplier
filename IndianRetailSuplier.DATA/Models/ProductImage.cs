using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianRetailSuplier.DATA.Models
{
    [Table("ProductImage")]
   public class ProductImage
    {
        [Key,Column("ImageId",Order =1)]
        public int ImageId { get; set; }
        [Required, Column("Image1")]
        public string ImagePath1 { get; set; }
        [Required, Column("Image2")]
        public string ImagePath2 { get; set; }
        [Required, Column("Image3")]
        public string ImagePath3 { get; set; }
        [Required, Column("Image4")]
        public string ImagePath4 { get; set; }
        [ Column("Video")]
        public string Videopath { get; set; }
        [Required,Column("Image")]
        public string baseImage { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
