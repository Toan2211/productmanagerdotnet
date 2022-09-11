using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public String Name { get; set; }
        public List<Product> Products { get; set; }
    }
}