using ECommerce.Dtos.CommerceDtos;
using ECommerce.Models.ECommerceModels;
using ECommerce.Services.EcommerceServices.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommerceController : ControllerBase
    {
        private readonly ICommerceService _commerceService;

        public CommerceController(ICommerceService commerceService)
        {
            _commerceService = commerceService;
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<Commerce>> GetById(int id)
        {
            var commerce = await _commerceService.GetByIdAsync(id);
            if (commerce == null)
                return NotFound();
            return Ok(commerce);
        }

        [HttpGet("GetByName")]
        public async Task<ActionResult<Commerce>> GetByName(string name)
        {
            var commerce = await _commerceService.GetByNameAsync(name);
            if (commerce == null)
                return NotFound();
            return Ok(commerce);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<GetCommercesDto>>> GetAll()
        {
            var commerces = await _commerceService.GetAllAsync();
            return Ok(commerces);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Commerce>> Create(CreateCommerceDto commerce)
        {
            var createdCommerce = await _commerceService.CreateAsync(commerce);
            return CreatedAtAction(nameof(GetById), new { id = createdCommerce.Id }, createdCommerce);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id, Commerce commerce)
        {
            try
            {
                var updatedCommerce = await _commerceService.UpdateAsync(id, commerce);
                return Ok(updatedCommerce);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _commerceService.DeleteAsync(id);
            if (!result)
                return NotFound();
            return NoContent();
        }
    }
}
