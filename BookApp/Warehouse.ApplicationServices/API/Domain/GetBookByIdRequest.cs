using MediatR;

namespace Warehouse.ApplicationServices.API.Domain
{
    public class GetBookByIdRequest : IRequest<GetBookByIdResponse>
    {
        public int BookId { get; set; }
    }
}
