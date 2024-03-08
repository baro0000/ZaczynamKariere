using AutoMapper;
using Warehouse.ApplicationServices.API.Domain.Models;

namespace Warehouse.ApplicationServices.Mappings
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            this.CreateMap<Warehouse.DataAccess.Entities.Book, Book>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Title, y => y.MapFrom(z => z.Title));
        }
    }
}
