using MediatR;
using NorthwindAPI.Application.Exceptions;
using NorthwindAPI.Application.Interfaces.Repositories;
using NorthwindAPI.Application.Wrappers;
using NorthwindAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NorthwindAPI.Application.Features.Orders.Queries.GetOrderById
{
    public class GetOrderByIdQuery : IRequest<Response<Domain.Entities.Orders>>
    {
        public int Id { get; set; }
        public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Response<Domain.Entities.Orders>>
        {
            private readonly IProductRepositoryAsync _productRepository;
            public GetOrderByIdQueryHandler(IProductRepositoryAsync productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<Response<Domain.Entities.Orders>> Handle(GetOrderByIdQuery query, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(query.Id);

                if (product == null) throw new ApiException($"Order Not Found.");

                return new Response<Domain.Entities.Orders>(product);
            }
        }
    }
}
