using MediatR;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Queries.GetAll
{
    public class GetAllAuthorQuery : IRequest<IEnumerable<Models.Author>>
    {
    }
}
