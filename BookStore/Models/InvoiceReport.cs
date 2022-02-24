using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class InvoiceReport
    {
        public string BookName { get; set; }
        public int Stock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
