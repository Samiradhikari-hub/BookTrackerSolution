using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookTracker.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        
        public List<Book> Books { get; set; }
    }
}
