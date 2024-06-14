using BookStoreTest.Repositories;
using MediatR;
using BookStoreTest.Models;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Commands.Delete

{
    public class DeleteAuthorHandler : IRequestHandler<DeleteAuthorCommand, bool>
    {
        public AuthorsRepository authorsRepository;

        public DeleteAuthorHandler(AuthorsRepository _authorsRepository)
        {
            authorsRepository = _authorsRepository;
        }

        public async Task<bool> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            return await authorsRepository.DeleteByIdAsync(request.IdAuthor, cancellationToken);
        }


    }
}
