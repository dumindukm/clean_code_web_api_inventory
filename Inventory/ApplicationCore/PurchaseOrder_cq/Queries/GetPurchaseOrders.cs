using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.PurchaseOrder_cq.Queries
{
    public class GetPurchaseOrders : IRequest<IEnumerable<PurchaseOrder>>
    {
        public int PageId { get; set; } = 1;
        public int PageSize { get; set; } = 50;
        public int StoreId { get; set; } = 0;
    }
}
