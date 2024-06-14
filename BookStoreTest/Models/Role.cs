namespace BookStoreTest.Models
{
    public class Role
    {
        public int IdRole { get; set; }
        public string Title { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }

}
