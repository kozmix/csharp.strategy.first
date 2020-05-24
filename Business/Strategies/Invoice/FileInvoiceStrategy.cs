using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Strategy.First.Business.Models;

namespace Strategy.First.Business.Strategies.Invoice
{
    class FileInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (var stream = new StreamWriter($"invoice_{Guid.NewGuid()}.txt"))
            {
                stream.Write(GenerateTextInvoice(order));

                stream.Flush();
            }
        }
    }
}
