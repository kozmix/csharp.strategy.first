﻿using System;
using System.Collections.Generic;
using System.Text;
using Strategy.First.Business.Models;

namespace Strategy.First.Business.Strategies.SalesTax
{
    public class UsSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": return order.TotalPrice * 0.095m;
                case "ny": return order.TotalPrice * 0.04m;
                case "nyc": return order.TotalPrice * 0.045m;
                default: return 0m;
            }
        }
    }
}
