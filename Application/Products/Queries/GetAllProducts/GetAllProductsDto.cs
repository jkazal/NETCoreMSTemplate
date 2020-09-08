using Application.Common.Mappings;
using AutoMapper;

namespace Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsDto : IMapFrom<GetAllProductsResponse>
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetAllProductsResponse, GetAllProductsDto>();
        }
    }
}