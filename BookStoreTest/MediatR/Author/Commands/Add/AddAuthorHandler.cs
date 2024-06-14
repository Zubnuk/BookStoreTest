using BookStoreTest.Repositories;
using MediatR;
using BookStoreTest.Models;
using System.Diagnostics.Metrics;
using DocumentFormat.OpenXml.Wordprocessing;

namespace BookStoreTest.MediatR.Author.Commands.Add
{
    public class AddAuthorHandler : IRequestHandler<AddAuthorCommand, Models.Author>
    {
        public AuthorsRepository countryRepo;

        public AddAuthorHandler(AuthorsRepository _countryRepo)
        {
            countryRepo = _countryRepo;
        }

        public async Task<Models.Author> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            var country = new Models.Author
            {

                FirstName = request.FirstName,
                LastName= request.LastName
            };
            await countryRepo.AddAsync(country, cancellationToken);
            return country;
        }

        Task<Models.Author> IRequestHandler<AddAuthorCommand, Models.Author>.Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
