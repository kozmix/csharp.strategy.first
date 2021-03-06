﻿using Strategy.First.Business.Models;
using Strategy.First.Business.Strategies.Invoice;
using Strategy.First.Business.Strategies.SalesTax;
using System;

namespace Strategy.First
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                }
            };

            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
            
            if(destination == "sweden")
            {
                order.SalesTaxStrategy = new SwedenSalesTaxStrategy();
            }
            else if (destination == "us")
            {
                order.SalesTaxStrategy = new UsSalesTaxStrategy();
            }

            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

            Console.WriteLine(order.GetTax(new SwedenSalesTaxStrategy()));

            order.InvoiceStrategy = new FileInvoiceStrategy();
            order.FinalizeOrder();
        }
    }
}
