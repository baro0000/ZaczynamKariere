using Microsoft.AspNetCore.Mvc;
using Warehouse.DataAccess;
using Warehouse.DataAccess.Entities;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCaseController : ControllerBase
    {
        private readonly IRepository<BookCase> bookCaseRepository;

        public BookCaseController(IRepository<BookCase> bookCaseRepository)
        {
            this.bookCaseRepository = bookCaseRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<BookCase> GetAllBooks() => bookCaseRepository.GetAll();
    }
}
