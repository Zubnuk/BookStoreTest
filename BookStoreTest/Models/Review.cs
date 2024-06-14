namespace BookStoreTest.Models
{
    public class Review
    {
        public int IdReview { get; set; }
        public int IdBook { get; set; }
        public Cart Book { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
    }

}
