using MediatR;
using Microsoft.AspNetCore.Mvc;
using Warehouse.ApplicationServices.API.Domain;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator mediator;

        public BooksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllBooks([FromQuery] GetBooksRequest request)
        {
            var response = await mediator.Send(request);
            return Ok(response);
        }
    }
}
