using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Chef
    {
        [Key]
        public int ChefID { get; set; }
        public string? Name { get; set; }
        public string? Specialization { get; set; }
        public string? ImageUrl { get; set; } = string.Empty;
    }
}
