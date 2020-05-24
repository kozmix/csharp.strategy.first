using Strategy.First.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.First.Business.Strategies.Invoice
{
    public interface IInvoiceStrategy
    {
        void Generate(Order order);
    }
}
