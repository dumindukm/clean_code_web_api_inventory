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

        [HttpGet("stores/id/{id}")]
        public async Task<Store> GetAsync([FromRoute] int id)
        {
            
            return new Store();
        }

        [HttpPost("stores")]
        public async Task<IEnumerable<Store>> GetAsync([FromBody] GetStores query)
        {
            var stores = await mediator.Send(query);// TO DO : Response wrapping
            return stores;
        }
    }
}
