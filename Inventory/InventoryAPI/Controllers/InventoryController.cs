using ApplicationCore.Inventory.Queries;
using AutoMapper;
using Domain.Models;
using InventoryAPI.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly IMapper mapper;
        private readonly ILogger<InventoryController> logger;

        public InventoryController(ISender sender, IMapper map, ILogger<InventoryController> logger)
        {
            this.mediator = sender;
            this.mapper = map;
            this.logger = logger;
        }


        [HttpGet("products")]
        public async Task<IEnumerable<ProductViewModel>> GetAsync([FromQuery] GetProducts query)
        {
            var products = this.mapper.Map<IEnumerable<ProductViewModel>>( await mediator.Send(query));// TO DO : Response wrapping
            return products;
        }

    }
}
