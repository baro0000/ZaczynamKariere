using BookAppDataAccess;
using BookAppDataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.DataAccess.CQRS.Queries
{
    public class GetBooksQuery : QueryBase<List<Book>>
    {
        public override Task<List<Book>> Execute(WarehouseAppContext context)
        {
            return context.Books.ToListAsync();
        }
    }
}
