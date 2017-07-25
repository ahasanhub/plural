using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globalmantics.DAL.Entities
{
    public class CatalogItem
    {
        public int CatalogItemId { get; set; }
        public string Slu { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
