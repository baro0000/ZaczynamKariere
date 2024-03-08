using MediatR;

namespace Warehouse.ApplicationServices.API.Domain
{
    public class PutBookCaseRequest : IRequest<PutBookCaseResponse>
    {
        public int BookCaseId { get; set; }
    }
}
