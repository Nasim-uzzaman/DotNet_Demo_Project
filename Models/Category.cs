using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [DisplayName("Category Name")]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 200, ErrorMessage = "Please insert the order between 1-200")]
        public int DisplayOrder { get; set; }

    }
}
