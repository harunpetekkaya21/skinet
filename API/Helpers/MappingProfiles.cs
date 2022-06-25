using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                    .ForMember(d=>d.ProductCategory,o => o.MapFrom(s =>s.ProductCategory.Name))
                    .ForMember(d=>d.ProductType, o => o.MapFrom(s =>s.ProductType.Name))
                    .ForMember(d=>d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());

                    CreateMap<Address,AddressDto>().ReverseMap();

        }
    }
}