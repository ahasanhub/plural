using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrittingTestableCode.Module2.Shared;

namespace WrittingTestableCode.Module2.Hard
{
    public class PrintInvoiceCommand
    {
        public void Execute(int invoiceId)
        {
            var database=new Database();
            var invoice = database.GetInvoice(invoiceId);
            Printer.WriteLine("Invoice Id: "+invoice.InvoiceId);
            Printer.WriteLine("Total: " + invoice.Total);
            var dateTime = DateTime.Now;
            Printer.WriteLine("Printed: "+dateTime.ToShortDateString());
        }
    }
}
