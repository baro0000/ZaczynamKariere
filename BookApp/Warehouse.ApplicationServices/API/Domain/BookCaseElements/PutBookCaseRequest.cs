using MediatR;

namespace Warehouse.ApplicationServices.API.Domain.BookCaseElements
{
    public class PutBookCaseRequest : IRequest<PutBookCaseResponse>
    {
        public int BookCaseId { get; set; }
    }
}
