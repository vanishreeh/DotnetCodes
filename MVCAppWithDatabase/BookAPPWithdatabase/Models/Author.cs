using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPPWithdatabase.Models
{
    public class Author
    {
        public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //[NotMapped]
        [Required]
        public string Name { get; set; }

        // collection navigation property
        public ICollection<Book> Books { get; set; }

    }
}
