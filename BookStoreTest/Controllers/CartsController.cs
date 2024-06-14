using BookStoreTest.Models;
using BookStoreTest.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly IBaseRepository<Cart> _repository;

        public CartsController(IBaseRepository<Cart> repository)
        {
            _repository = repository;
        }

      /*  [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> GetCarts()
        {
            var carts = await _repository.GetAllAsync();
            return Ok(carts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> GetCart(int id)
        {
            var cart = await _repository.GetByIdAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            return Ok(cart);
        }

        [HttpPost]
        public async Task<ActionResult<Cart>> CreateCart(Cart cart)
        {
            await _repository.AddAsync(cart);
            return CreatedAtAction(nameof(GetCart), new { id = cart.IdCart }, cart);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCart(int id, Cart cart)
        {
            if (id != cart.IdCart)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync(cart);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            var cart = await _repository.GetByIdAsync(id);
            if (cart == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(cart);
            return NoContent();
        }*/
    }
}
