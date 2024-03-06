using BookAppDataAccess.Entities;
using MediatR;
using Warehouse.ApplicationServices.API.Domain;
using Warehouse.DataAccess;

namespace Warehouse.ApplicationServices.API.Handlers
{
    public class GetBooksHandler : IRequestHandler<GetBooksRequest, GetBooksResponse>
    {
        private readonly IRepository<Book> bookRepository;

        public GetBooksHandler(IRepository<BookAppDataAccess.Entities.Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public Task<GetBooksResponse> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            var books = bookRepository.GetAll();
            var domainBooks = books.Select(x => new Domain.Models.Book()
            {
                Id = x.Id,
                Title = x.Title
            });

            var response = new GetBooksResponse()
            {
                Data = domainBooks.ToList()
            };

            return Task.FromResult(response);
        }
    }
}
