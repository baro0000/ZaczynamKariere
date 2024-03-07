using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
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
        public async Task<IActionResult> GetAllBooks([FromQuery] string title = "")
        {
            GetBooksRequest request = new GetBooksRequest() { Title = title};
            var response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        [Route("{bookId}")]
        public async Task<IActionResult> GetAllBooks([FromRoute] int bookId)
        {
            var request = new GetBookByIdRequest()
            {
                BookId = bookId
            };
            var response = await mediator.Send(request);
            return Ok(response);
        }
    }
}
