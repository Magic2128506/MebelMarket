using MebelMarket.Domain;
using MebelMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MebelMarket.Infrastructure.Mapping
{
    public static class OrderMapping
    {
        public static OrderViewModel ToView(this Order f) => new OrderViewModel
        {
            ID = f.ID,
            Name = f.Name,
            Phone = f.Phone,
            Description = ""
        };
        public static Order FromView(this OrderViewModel vwm) => new Order
        {
            Name = vwm.Name,
            Phone = vwm.Phone,
            Description = vwm.Description
        };
    }
}
