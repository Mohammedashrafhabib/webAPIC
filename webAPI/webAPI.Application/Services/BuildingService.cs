using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;

namespace webAPI.Application.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BuildingService(IBuildingRepository buildingService, IUnitOfWork unitOfWork)
        {
            _buildingRepository = buildingService;
            _unitOfWork = unitOfWork;
        }

        public void AddBuilding(Building building)
        {
            _buildingRepository.Add(building);
            _unitOfWork.complete();

        }

        public BuildingViewModel GetAllBuildings()
        {
            return new BuildingViewModel() { buildings = _buildingRepository.GetAll() };
        }

        public Building GetBuilding(int buildingId)
        {
            return _buildingRepository.Find(x=>x.BuildingID==buildingId).First();

        }

        public void RemoveBuilding(int buildingId)
        {
            _buildingRepository.Remove(GetBuilding(buildingId));
            _unitOfWork.complete();
        }

        public void UpdateBuilding(Building building)
        {
            _buildingRepository.update(building);
            _unitOfWork.complete();
        }
    }
}
