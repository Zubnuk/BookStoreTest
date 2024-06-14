using BookStoreTest.Repositories;
using MediatR;
using BookStoreTest.Models;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Queries.GetAll
{
    public class GetAllAuthorHandler : IRequestHandler<GetAllAuthorQuery, IEnumerable<Models.Author>>
    {
        public AuthorsRepository authorsRepository;

        public GetAllAuthorHandler(AuthorsRepository _authorsRepository)
        {
            authorsRepository = _authorsRepository;
        }

        public async Task<IEnumerable<Models.Author>> Handle(GetAllAuthorQuery request, CancellationToken cancellationToken)
        {
            return await authorsRepository.GetAllAsync(cancellationToken);
        }
    }
}
