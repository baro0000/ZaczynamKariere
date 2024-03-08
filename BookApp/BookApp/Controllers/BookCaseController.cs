using MediatR;
using Microsoft.AspNetCore.Mvc;
using Warehouse.ApplicationServices.API.Domain;

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

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllBookCasesOrById([FromQuery] int bookCaseId)
        {
            var request = new GetAllBookCasesOrByIdRequest()
            {
                BookCaseId = bookCaseId
            };
            var response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddBookCase([FromBody] AddBookCaseRequest request)
        {
            var response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        [Route("{bookCaseId}")]
        public async Task<IActionResult> GetAllBooks([FromRoute] int bookCaseId)
        {
            var request = new PutBookCaseRequest()
            {
                BookCaseId = bookCaseId
            };
            var response = await mediator.Send(request);
            return Ok(response);
        }
    }
}
