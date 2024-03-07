using AutoMapper;
using BookAppDataAccess.Entities;
using MediatR;
using Warehouse.ApplicationServices.API.Domain;
using Warehouse.DataAccess;

namespace Warehouse.ApplicationServices.API.Handlers
{
    public class GetBooksHandler : IRequestHandler<GetBooksRequest, GetBooksResponse>
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IMapper mapper;

        public GetBooksHandler(IRepository<BookAppDataAccess.Entities.Book> bookRepository, IMapper mapper)
        {
            this.bookRepository = bookRepository;
            this.mapper = mapper;
        }
        public async Task<GetBooksResponse> Handle(GetBooksRequest request, CancellationToken cancellationToken)
        {
            var books = await bookRepository.GetAll();
            var mappedBooks = mapper.Map<List<Domain.Models.Book>>(books);

            var response = new GetBooksResponse()
            {
                Data = mappedBooks
            };

            return response;
        }
    }
}
