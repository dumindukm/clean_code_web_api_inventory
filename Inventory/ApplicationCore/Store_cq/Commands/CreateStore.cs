using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Store_cq.Commands
{
    public class CreateStore : IRequest<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
