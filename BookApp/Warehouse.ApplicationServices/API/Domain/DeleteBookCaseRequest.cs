using MediatR;

namespace Warehouse.ApplicationServices.API.Domain
{
    public class DeleteBookCaseRequest : IRequest<DeleteBookCaseResponse>
    {
        public int BookCaseId { get; set; }
    }
}
