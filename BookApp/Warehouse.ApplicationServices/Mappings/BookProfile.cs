using AutoMapper;
using Warehouse.ApplicationServices.API.Domain.BookElements;

namespace Warehouse.ApplicationServices.Mappings
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            this.CreateMap<PostBookRequest, Warehouse.DataAccess.Entities.Book>()
                .ForMember(x => x.Title, y => y.MapFrom(z => z.Title))
                .ForMember(x => x.Year, y => y.MapFrom(z => z.Year));

            this.CreateMap<Warehouse.DataAccess.Entities.Book, API.Domain.Models.Book>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Title, y => y.MapFrom(z => z.Title));
        }
    }
}
