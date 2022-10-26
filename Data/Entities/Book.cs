namespace BookList.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Author { get; set; } = null!;

        public decimal Rating { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; } = null!;

        public virtual ICollection<UserBook> UsersBooks { get; set; } = new List<UserBook>();
    }
}
