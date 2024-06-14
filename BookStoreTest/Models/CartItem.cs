namespace BookStoreTest.Models
{
    public class CartItem
    {
        public int IdCartItem { get; set; }
        public int IdCart { get; set; }
        public Cart Cart { get; set; }
        public int IdBook { get; set; }
        public Cart Book { get; set; }
        public int Quantity { get; set; }
    }

}
