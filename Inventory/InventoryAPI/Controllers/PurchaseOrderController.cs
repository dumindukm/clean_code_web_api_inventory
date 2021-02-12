using ApplicationCore.PurchaseOrder_cq.Commands;
using ApplicationCore.PurchaseOrder_cq.Queries;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly ISender mediator;

        public PurchaseOrderController(ISender sender) => mediator = sender;

        [HttpGet("purchase-order/id/{id:int}")]
        public async Task<IEnumerable<PurchaseOrder>> GetAsync([FromRoute] int id)
        {
            GetPurchaseOrders query = new GetPurchaseOrders();
            query.StoreId = id;
            var po = await mediator.Send(query);// TO DO : Response wrapping and in GetStoreshandler use specification pattern
            return po;
        }


        [HttpPost("purchase-order")]
        public async Task<IActionResult> CreateAsync([FromBody] CreatePurchaseOrder query)
        {
            var poId = await mediator.Send(query);
            return CreatedAtAction(nameof(GetAsync), new { id = poId }, poId);
        }

    }
}
