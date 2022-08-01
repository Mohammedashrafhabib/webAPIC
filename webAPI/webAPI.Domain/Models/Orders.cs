using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int Product_Quantity { get; set; }

    }
}
