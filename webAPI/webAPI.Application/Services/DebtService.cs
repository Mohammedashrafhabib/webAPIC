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
    public class DebtService : IDebtService
    {
        private readonly IDebtRepository _debtRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DebtService(IDebtRepository debtRepository, IUnitOfWork unitOfWork)
        {
            _debtRepository = debtRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddDebt(Debt debt)
        {
            _debtRepository.Add(debt);
            _unitOfWork.complete();
        }

       

        public DebtViewModel GetAllDebts()
        {
           return new DebtViewModel() { Debts = _debtRepository.GetAll() };
        }

        public DebtViewModel GetAllFlatDebt(int id)
        {
            return new DebtViewModel() { Debts = _debtRepository.GetAllFlatDebt(id) };
        }

        

        public Debt GetDebt(int debtId)
        {
            return _debtRepository.Find(x => x.DebtID == debtId).First();
        }

        public DebtViewModel GetDueDebts(int id)
        {
            return new DebtViewModel() { Debts = _debtRepository.GetDueDebts(id) };
        }


        public void RemoveDebt(int debtId)
        {
           _debtRepository.Remove(GetDebt(debtId));
            _unitOfWork.complete();
        }

     
        public void UpdateDebt(Debt debt)
        {
            _debtRepository.update(debt);
            _unitOfWork.complete();
        }

       
    }
}
