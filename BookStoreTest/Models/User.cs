using DocumentFormat.OpenXml.Spreadsheet;

namespace BookStoreTest.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public ICollection<Cart> Carts { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Seller Seller { get; set; } // One-to-one relationship with Seller
        public ICollection<UserRole> UserRoles { get; set; }

        
    }

}
