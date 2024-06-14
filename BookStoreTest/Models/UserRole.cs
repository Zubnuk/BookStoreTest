using System.Data;

namespace BookStoreTest.Models
{
    public class UserRole
    {
        public int IdRole { get; set; }
        public Role Role { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
    }

}
