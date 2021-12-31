using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Activity0601_QuickCrud_Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual List<Item> Items { get; set; } = new List<Item>();

    }
}
