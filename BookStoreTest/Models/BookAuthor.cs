namespace BookStoreTest.Models
{
    public class BookAuthor
    {
        public int IdAuthor { get; set; }
        public Author Author { get; set; }

        public int IdBook { get; set; }
        public Cart Book { get; set; }
    }

}
