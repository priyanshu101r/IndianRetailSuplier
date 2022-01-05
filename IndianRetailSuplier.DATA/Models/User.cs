using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianRetailSuplier.DATA.Models
{
    [Table("USER")]
    public class User
    {
        [Key, Column("ID", Order = 1)]
        public int Id { get; set; }
        [Required, Column("FirstName")]
        public string? firstName { get; set; }
        [Required, Column("LastName")]
        public string? lastName { get; set; }
        [Required, Column("Email")]
        public string? email { get; set; }
        [Required, Column("Password")]
        public string? password { get; set; }
        [Required, Column("ContactNumber")]
        public int mobilenumber { get; set; }
    }
}
