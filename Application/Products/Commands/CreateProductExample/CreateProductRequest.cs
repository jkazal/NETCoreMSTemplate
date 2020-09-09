using Application.Common.Mappings;
using AutoMapper;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductRequest : IMapFrom<CreateProductCommand>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string UserId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductCommand, CreateProductRequest>();
        }
    }
}