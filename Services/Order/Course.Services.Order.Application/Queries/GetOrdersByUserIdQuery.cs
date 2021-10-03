using Course.Services.Order.Application.Dtos;
using Course.Shared.Dtos;
using MediatR;
using System.Collections.Generic;

namespace Course.Services.Order.Application.Queries
{
    public class GetOrdersByUserIdQuery:IRequest<Response<List<OrderDto>>>
    {
        public string UserId { get; set; }
    }
}
