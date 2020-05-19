using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindConsole.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "No Name Entered, Category Must Have A Name")]
        public string CategoryName { get; set; }


        [Required(ErrorMessage = "No Description Entered, Category Must Have A Description")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
