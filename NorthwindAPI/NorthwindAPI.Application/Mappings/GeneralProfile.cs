using AutoMapper;
using NorthwindAPI.Application.Features.Orders.Queries.GetAllOrders;
using NorthwindAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindAPI.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Orders, GetAllOrdersViewModel>().ReverseMap();
            CreateMap<GetAllOrdersQuery, GetAllOrdersParameter>();
        }
    }
}
