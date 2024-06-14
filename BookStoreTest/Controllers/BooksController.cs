using BookStoreTest.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

   /*     [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> GetBooks()
        {
            var books = await _mediator.Send(new GetBooksQuery());
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> GetBook(int id)
        {
            var book = await _mediator.Send(new GetBookByIdQuery { Id = id });
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookCommand command)
        {
            var bookId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetBook), new { id = bookId }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, UpdateBookCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _mediator.Send(new DeleteBookCommand { Id = id });
            return NoContent();
        }*/
    }
}
