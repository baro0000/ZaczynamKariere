using AutoMapper;
using MediatR;
using Warehouse.ApplicationServices.API.Domain.BookCaseElements;
using Warehouse.DataAccess.CQRS;
using Warehouse.DataAccess.CQRS.Commands;
using Warehouse.DataAccess.Entities;

namespace Warehouse.ApplicationServices.API.Handlers
{
    public class PutBookCaseHandler : IRequestHandler<PutBookCaseRequest, PutBookCaseResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutBookCaseHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutBookCaseResponse> Handle(PutBookCaseRequest request, CancellationToken cancellationToken)
        {
            var bookCase = mapper.Map<BookCase>(request);
            var command = new PutBookCaseCommand() { Parameter = bookCase };
            var bookCaseFromDb = await commandExecutor.Execute(command);
            var response = new PutBookCaseResponse()
            {
                Data = mapper.Map<Domain.Models.BookCase>(bookCaseFromDb)
            };
            return response;
        }
    }
}
