using ApplicationCore.Store_cq.Commands;
using ApplicationCore.Store_cq.Queries;
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
    public class StoreController : ControllerBase
    {
        private readonly ISender mediator;

        public StoreController(ISender sender) => mediator = sender;

        [HttpGet("stores/id/{id:int}")]
        public async Task<IEnumerable<Store>> GetAsync([FromRoute] int id)
        {
            GetStores query = new GetStores();
            var stores = await mediator.Send(query);// TO DO : Response wrapping and in GetStoreshandler use specification pattern
            return stores;
        }

        [HttpGet("stores")]
        public async Task<IEnumerable<Store>> GetAsync([FromQuery] GetStores query)
        {
            var stores = await mediator.Send(query);// TO DO : Response wrapping
            return stores;
        }

        [HttpPost("stores")]
        public async Task<IActionResult> CreateAsync([FromBody] CreateStore query)
        {
            var storeId = await mediator.Send(query);
            return CreatedAtAction(nameof(GetAsync), new { id = storeId }, storeId);
        }

    }
}
