using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracker.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public bool IsRead { get; set; }

        // Foreign key
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
    }
}
