using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianRetailSuplier.DATA.Models
{
    [Table("Category")]
    public class Category
    {
        [Key, Column("ID", Order = 1)]
        public int Id { get; set; }
        [Required, Column("CategoryName")]
        public string? CategoryName { get; set; }
        [Required, Column("Description")]
        public string? Description { get; set; }

    }
}
