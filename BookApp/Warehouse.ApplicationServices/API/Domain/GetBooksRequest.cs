using MediatR;

namespace Warehouse.ApplicationServices.API.Domain
{
    public class GetBooksRequest : IRequest<GetBooksResponse>
    {
        public string Title { get; set; }
    }
}
