using DocumentFormat.OpenXml.Wordprocessing;
using MediatR;
using System.Diagnostics.Metrics;

namespace BookStoreTest.MediatR.Author.Commands.Add
{
    public class AddAuthorCommand : IRequest<Models.Author>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddAuthorCommand(string firstName, string CountryName)
        {
            FirstName = firstName;
            LastName = CountryName;
        }
    }
}
