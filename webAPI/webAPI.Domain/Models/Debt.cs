using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Debt
    {
       
        public int DebtID { get; set; }
        public int FlatID { get; set; }
        public Flat flat { get; set; }
        public int Amount { get; set; }
        public bool IsDue { get; set; }
    }
}
