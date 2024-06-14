using BookStoreTest.MediatR.Author.Commands.Add;
using BookStoreTest.MediatR.Author.Commands.Delete;
using BookStoreTest.MediatR.Author.Commands.Edit;
using BookStoreTest.MediatR.Author.Queries.Get;
using BookStoreTest.MediatR.Author.Queries.GetAll;
using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace BookStoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        readonly IMediator mediator;

        public AuthorsController(IMediator _mediator)
        {
            mediator = _mediator;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var authors = await mediator.Send(new GetAllAuthorQuery(), cancellationToken);
            if (authors is null)
                return NotFound();
            return Ok(authors);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id, CancellationToken cancellationToken)
        {
            var author = await mediator.Send(new GetAuthorQuery(id), cancellationToken);
            if (author is null)
                return NotFound();
            return Ok(author);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <param name="cancellationToken"></param>
       /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCountryAsync(int id, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new DeleteAuthorCommand(id), cancellationToken);
            if (!result)
                return NotFound();
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="author"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddAsync(Models.Author author, CancellationToken cancellationToken)
        {
            await mediator.Send(new AddAuthorCommand(author.FirstName,author.FirstName), cancellationToken);
            return Ok(author);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="author"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> EditCountryAsync(int id, Models.Author author , CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new EditAuthorCommand(id, author.FirstName, author.LastName), cancellationToken);
            if (result==null)
                return NotFound();
            return Ok(author);
        }
    }
}
