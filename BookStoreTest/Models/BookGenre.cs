namespace BookStoreTest.Models
{
    public class BookGenre
    {
        public int IdGenre { get; set; }
        public Genre Genre { get; set; }

        public int IdBook { get; set; }
        public Cart Book { get; set; }
    }

}
