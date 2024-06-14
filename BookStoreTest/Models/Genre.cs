namespace BookStoreTest.Models
{
    public class Genre
    {
        public int IdGenre { get; set; }
        public string GenreName { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
    }

}
