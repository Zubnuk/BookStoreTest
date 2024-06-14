using BookStoreTest.Repositories;
using MediatR;
using BookStoreTest.Models;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Commands.Edit
{
    public class EditAuthorHandler : IRequestHandler<EditAuthorCommand, Models.Author>
    {
        public AuthorsRepository countryRepo;

        public EditAuthorHandler(AuthorsRepository _countryRepo)
        {
            countryRepo = _countryRepo;
        }


        async Task<Models.Author> IRequestHandler<EditAuthorCommand, Models.Author>.Handle(EditAuthorCommand request, CancellationToken cancellationToken)
        {
            var country = new Models.Author
            {

                FirstName = request.FirstName,
                LastName = request.LastName
            };
            return await countryRepo.UpdateAsync(country, cancellationToken);
        }
    }
}
