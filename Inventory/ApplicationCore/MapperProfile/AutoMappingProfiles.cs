using ApplicationCore.PurchaseOrder_cq.Commands;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.MapperProfile
{
    public class AutoMappingProfiles : Profile
    {
        public AutoMappingProfiles()
        {
            CreateMap<OrderItem, PurchaseOrderItem>();
        }
    }
}
