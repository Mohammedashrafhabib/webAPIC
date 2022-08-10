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
    public class FlatService : IFlatService
    {
        private readonly IFlatRepository _flatRepository;
        private readonly IUnitOfWork _unitOfWork;
        public FlatService(IFlatRepository flatRepository, IUnitOfWork unitOfWork)
        {
            _flatRepository = flatRepository;
            _unitOfWork = unitOfWork;
        }
        public void AddFlat(Flat Flat)
        {
            _flatRepository.Add(Flat);
            _unitOfWork.complete();
        }

        public FlatViewModel GetAllFlats()
        {
            return new FlatViewModel() { flats = _flatRepository.GetAll() };
        }

        public Building GetBuilding(int id)
        {
            return _flatRepository.GetBuilding(id);
        }

        public Flat GetFlat(int FlatId)
        {
            return _flatRepository.Find(e => e.FlatID == FlatId).First();
        }

        public void RemoveFlat(Flat Flat)
        {
            _flatRepository.Remove(Flat);
            _unitOfWork.complete();
        }

        public void UpdateFlat(Flat Flat)
        {
            _flatRepository.update(Flat);
            _unitOfWork.complete();
        }
    }
}
