using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Inventory.Queries
{
    public class GetProducts : IRequest<IEnumerable<Product>>
    {
        public int PageId { get; set; } = 1;
        public int PageSize { get; set; } = 50;
        public string Name { get; set; } = "";
    }
}
