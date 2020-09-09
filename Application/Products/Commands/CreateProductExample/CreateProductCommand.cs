using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;

namespace Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<CreateProductDto>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductDto>
        {
            private readonly IProductsApi _productsApi;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductsApi productsApi, IMapper mapper)
            {
                _productsApi = productsApi;
                _mapper = mapper;
            }
            
            public async Task<CreateProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var response = await _productsApi.CreateProduct(_mapper.Map<CreateProductRequest>(request));
                return _mapper.Map<CreateProductDto>(response);
            }
        }
    }
}