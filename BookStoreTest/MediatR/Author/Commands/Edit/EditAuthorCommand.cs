using MediatR;

namespace BookStoreTest.MediatR.Author.Commands.Edit
{
    public class EditAuthorCommand:IRequest<Models.Author>
    {
        public int IdAuthor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EditAuthorCommand(int id, string firstName, string lastName)
        {
            IdAuthor = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
