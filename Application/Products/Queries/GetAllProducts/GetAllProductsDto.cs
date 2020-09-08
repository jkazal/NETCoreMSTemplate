using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsDto : IMapFrom<Vsproduct>
    {
        public string ProductName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Vsproduct, GetAllProductsDto>();
        }
    }
}