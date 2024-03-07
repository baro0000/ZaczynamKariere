using MediatR;
using Microsoft.AspNetCore.Mvc;
using Warehouse.ApplicationServices.API.Domain;
using Warehouse.DataAccess;
using Warehouse.DataAccess.Entities;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCaseController : ControllerBase
    {
        private readonly IMediator mediator;

        public BookCaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddBookCase([FromBody] AddBookCaseRequest request)
        {
            var response = await mediator.Send(request);
            return Ok(response);
        }
    }
}
