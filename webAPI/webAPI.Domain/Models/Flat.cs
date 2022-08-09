using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Domain.Models
{
    public class Flat
    {
      
        public int FlatID { get; set; }
       
        public int BuildingID { get; set; }
        public Building Building { get; set; }
        public int Safe { get; set; }
    }
}
