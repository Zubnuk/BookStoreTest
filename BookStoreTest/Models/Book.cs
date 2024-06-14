using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace BookStoreTest.Models
{
    public class Book
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double TotalRating { get; set; }
        public int IdSeller { get; set; }
        public Seller Seller { get; set; }
        public int? IdPriceChanged { get; set; }
        public PriceChanged PriceChanged { get; set; }
        public int StockQuantity { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<Cart> CartItems { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
