using BookStoreTest.Repositories;
using MediatR;
using BookStoreTest.Models;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Queries.Get
{
    public class GetAuthorHandler : IRequestHandler<GetAuthorQuery, Models.Author>
    {
        public AuthorsRepository countryRepo;

        public GetAuthorHandler(AuthorsRepository _countryRepo)
        {
            countryRepo = _countryRepo;
        }

        public async Task<Models.Author> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            return await countryRepo.GetByIdAsync(request.IdAuthor, cancellationToken);
        }
    }
}
