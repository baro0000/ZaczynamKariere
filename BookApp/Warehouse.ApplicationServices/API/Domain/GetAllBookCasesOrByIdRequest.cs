using MediatR;

namespace Warehouse.ApplicationServices.API.Domain
{
    public class GetAllBookCasesOrByIdRequest : IRequest<GetAllBookCasesOrByIdResponse>
    {
        public int BookCaseId { get; set; }
    }
}
