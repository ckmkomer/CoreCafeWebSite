using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EntityLayer.Concrete
{
    public class CategoryMenu
    {
        [Key]
        public int CategoryMenuID { get; set; }
        public string? CategoryName { get; set; }

        
     List<CategoryMenu> categoryMenus { get; set; } = new List<CategoryMenu>();
    }
}
