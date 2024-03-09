using AutoMapper;
using MediatR;
using Warehouse.ApplicationServices.API.Domain.BookElements;
using Warehouse.DataAccess.CQRS;
using Warehouse.DataAccess.CQRS.Commands;

namespace Warehouse.ApplicationServices.API.Handlers
{
    public class PostBookHandler : IRequestHandler<PostBookRequest, PostBookResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PostBookHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<PostBookResponse> Handle(PostBookRequest request, CancellationToken cancellationToken)
        {
            var book = mapper.Map<Warehouse.DataAccess.Entities.Book>(request);
            var command = new PostBookCommand() {Parameter = book};
            var bookFromDataBase = await commandExecutor.Execute(command);
            return new PostBookResponse()
            {
                Data = mapper.Map<API.Domain.Models.Book>(bookFromDataBase)
            };
        }
    }
}
