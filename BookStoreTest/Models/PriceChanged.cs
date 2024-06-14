namespace BookStoreTest.Models
{
    public class PriceChanged
    {
        public int IdPriceChanged { get; set; }
        public int IdBook { get; set; }
        public Cart Book { get; set; }

        public decimal CurrentPrice { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
