using System.ComponentModel.DataAnnotations;

namespace Activity0601_QuickCrud_Web.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
