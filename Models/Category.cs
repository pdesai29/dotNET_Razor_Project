using System.ComponentModel.DataAnnotations;

namespace bulky_Razor_temp.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }

    }
}
