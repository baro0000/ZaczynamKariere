using MediatR;

namespace Warehouse.ApplicationServices.API.Domain.BookElements
{
    public class PostBookRequest : IRequest<PostBookResponse>
    {
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
