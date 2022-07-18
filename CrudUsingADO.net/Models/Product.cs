using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsingADO.net.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Product name is requied")]
        [DataType(DataType.Text)]
        [Display(Name="Product Name")]

        public String Name { get; set; }

        [Required(ErrorMessage ="Price is required")]
        [DataType(DataType.Text)]
        [Range(minimum:1,maximum:50000)]


        public double Price { get; set; }
    }
}
