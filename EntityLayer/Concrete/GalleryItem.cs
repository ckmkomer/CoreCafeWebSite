using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GalleryItem
    {
        [Key]
        public int ID { get; set; }
        public string? ImageUrl { get; set; }


        

    }
}
