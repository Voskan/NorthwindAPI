using AutoMapper;
using MediatR;
using NorthwindAPI.Application.Filters;
using NorthwindAPI.Application.Interfaces.Repositories;
using NorthwindAPI.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NorthwindAPI.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrdersQuery : IRequest<PagedResponse<IEnumerable<GetAllOrders.GetAllOrdersViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrders.GetAllOrdersQuery, PagedResponse<IEnumerable<GetAllOrdersViewModel>>>
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        public GetAllOrdersQueryHandler(IProductRepositoryAsync productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllOrdersViewModel>>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllOrders.GetAllOrdersParameter>(request);

            var product = await _productRepository.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var productViewModel = _mapper.Map<IEnumerable<GetAllOrdersViewModel>>(product);

            return new PagedResponse<IEnumerable<GetAllOrdersViewModel>>(productViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
