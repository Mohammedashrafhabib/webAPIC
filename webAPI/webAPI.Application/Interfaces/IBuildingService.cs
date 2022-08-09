using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.ViewModels;
using webAPI.Domain.Models;

namespace webAPI.Application.Interfaces
{
    public interface IBuildingService
    {
        public void AddBuilding(Building building);
        public void RemoveBuilding(int buildingId);
        public BuildingViewModel GetAllBuildings();
        public Building GetBuilding(int buildingId);
        public void UpdateBuilding(Building building);

    }
}
