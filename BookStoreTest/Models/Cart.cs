namespace BookStoreTest.Models
{
    public class Cart
    {
        public int IdCart { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }

        public ICollection<Cart> CartItems { get; set; }
        public Order Order { get; set; } // One-to-one relationship with Order
    }

}
