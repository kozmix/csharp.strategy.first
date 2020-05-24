using Strategy.First.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.First.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        decimal GetTaxFor(Order order);
    }
}
