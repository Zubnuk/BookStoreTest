using BookStoreTest.Repositories;
using MediatR;
using BookStoreTest.Models;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Commands.Delete

{
    public class DeleteAuthorHandler : IRequestHandler<DeleteAuthorCommand, bool>
    {
        public AuthorsRepository countryRepo;

        public DeleteAuthorHandler(AuthorsRepository _countryRepo)
        {
            countryRepo = _countryRepo;
        }

        public async Task<bool> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            return await countryRepo.DeleteByIdAsync(request.IdAuthor, cancellationToken);
        }


    }
}
