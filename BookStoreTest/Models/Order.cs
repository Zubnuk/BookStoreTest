namespace BookStoreTest.Models
{
    public class Order
    {
        public int IdOrder { get; set; }
        public int IdCart { get; set; }
        public Cart Cart { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
    }

}
