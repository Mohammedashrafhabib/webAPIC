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
        public int FlatID { get; set; }
        public Flat flat { get; set; }
        public int DebtID { get; set; }
        public Debt Debt { get; set; }
        public int BuildingID { get; set; }
        public Building Building { get; set; }
        public int Amount { get; set; }

    }
}
