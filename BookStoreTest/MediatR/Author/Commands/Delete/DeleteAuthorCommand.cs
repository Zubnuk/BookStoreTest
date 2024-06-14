using MediatR;


namespace BookStoreTest.MediatR.Author.Commands.Delete
{
    public class DeleteAuthorCommand : IRequest<bool>
    {
        public int IdAuthor { get; set; }

        public DeleteAuthorCommand(int id)
        {
            IdAuthor = id;
        }
    }
}
