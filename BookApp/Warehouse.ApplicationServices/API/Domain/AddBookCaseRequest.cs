using MediatR;

namespace Warehouse.ApplicationServices.API.Domain
{
    public class AddBookCaseRequest : IRequest<AddBookCaseResponse>
    {
        public int Number { get; set; }
    }
}
