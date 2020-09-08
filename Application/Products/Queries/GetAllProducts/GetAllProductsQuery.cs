using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IEnumerable<GetAllProductsDto>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<GetAllProductsDto>>
        {
            private readonly IProductsApi _productsApi;
            private readonly IMapper _mapper;

            public GetAllProductsQueryHandler(IProductsApi productsApi, IMapper mapper)
            {
                _productsApi = productsApi;
                _mapper = mapper;
            }
            
            public async Task<IEnumerable<GetAllProductsDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await _productsApi.GetAllProducts();
                return _mapper.Map<IEnumerable<GetAllProductsDto>>(products);
            }
        }
    }
}