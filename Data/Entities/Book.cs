namespace BookList.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Constants.DataConstants.Book;

    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(MaxBookTitleLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(MaxAuthorLength)]
        public string Author { get; set; } = null!;

        [Required]
        public decimal Rating { get; set; }

        [Required]
        public int GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public virtual Genre Genre { get; set; } = null!;

        public virtual ICollection<UserBook> UsersBooks { get; set; } = new List<UserBook>();
    }
}
