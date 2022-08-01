using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class ProductOrderCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Product_Quantity { get; set; }
    }
}
