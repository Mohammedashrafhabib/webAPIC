using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.ViewModels;
using webAPI.Domain.Models;

namespace webAPI.Application.Interfaces
{
    public interface IFlatService
    {
        public void RemoveFlat(Flat Flat);
        public void AddFlat(Flat Flat);
        public FlatViewModel GetAllFlats();
        public Flat GetFlat(int FlatId);
        public void UpdateFlat(Flat Flat);
        public Building GetBuilding(int id);
    }
}
