using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Models;

namespace webAPI.Application.ViewModels
{
    public class BuildingViewModel
    {
        public IEnumerable<Building> buildings { get; set; }
    }
}
