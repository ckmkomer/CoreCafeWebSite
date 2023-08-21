using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class SocialMedia
    {
        [Key]
        public int ID { get; set; }
        public string? Platform { get; set; }
        public string? Url { get; set; }

        public string? Icon { get; set; }
    }
}
