using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookAPPWithdatabase.Models
{
    public class Book
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public DateTime AddedAt { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

    }
}
