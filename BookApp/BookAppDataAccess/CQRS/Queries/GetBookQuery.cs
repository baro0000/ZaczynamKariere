using BookAppDataAccess;
using BookAppDataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.DataAccess.CQRS.Queries
{
    internal class GetBookQuery : QueryBase<Book>
    {
        public int Id { get; set; }
        public async override Task<Book> Execute(WarehouseAppContext context)
        {
            return await context.Books.FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
