using BookStoreTest.Repositories;
using MediatR;
using BookStoreTest.Models;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Queries.Get
{
    public class GetAuthorHandler : IRequestHandler<GetAuthorQuery, Models.Author>
    {
        public AuthorsRepository authorsRepository;

        public GetAuthorHandler(AuthorsRepository _authorsRepository)
        {
            authorsRepository = _authorsRepository;
        }

        public async Task<Models.Author> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            return await authorsRepository.GetByIdAsync(request.IdAuthor, cancellationToken);
        }
    }
}
