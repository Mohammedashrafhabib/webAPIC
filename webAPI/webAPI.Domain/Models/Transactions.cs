using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Transactions
    {
        public int ID { get; set; }
        public Boolean Dept_or_Payment { get; set; }
        public int Flat_ID { get; set; }
        public int Debt_ID { get; set; }
        public int Building_ID { get; set; }
        public int Amount { get; set; }

    }
}
