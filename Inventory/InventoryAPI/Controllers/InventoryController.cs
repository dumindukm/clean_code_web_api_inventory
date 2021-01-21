using ApplicationCore.Inventory.Queries;
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
    [Route("api/[controller]/v1")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly ISender mediator;

        public InventoryController(ISender sender) => mediator = sender;


        [HttpGet("products")]
        public async Task<IEnumerable<Product>> GetAsync([FromBody] GetProducts query)
        {
            var products = await mediator.Send(query);// TO DO : Response wrapping
            return products;
        }

    }
}
