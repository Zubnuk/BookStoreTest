using MediatR;

namespace BookStoreTest.MediatR.Author.Queries.Get
{
    public class GetAuthorQuery : IRequest<Models.Author>
    {
        public int IdAuthor { get; set; }

        public GetAuthorQuery(int id)
        {
            IdAuthor = id;
        }
    }
}
