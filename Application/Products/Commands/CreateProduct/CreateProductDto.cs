using Application.Common.Mappings;
using AutoMapper;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductDto : IMapFrom<CreateProductResponse>
    {
        public int Id { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductResponse, CreateProductDto>();
        }
    }
}