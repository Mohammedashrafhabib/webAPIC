using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.ViewModels;
using webAPI.Domain.Models;

namespace webAPI.Application.Interfaces
{
    public interface IDebtService
    {
        public void AddDebt(Debt debt);
        public void RemoveDebt(int debtId);
        public DebtViewModel GetAllDebts();
        public Debt GetDebt(int buildingId);
        public void UpdateDebt(Debt debt);
        public DebtViewModel GetAllFlatDebt(int id);

        public DebtViewModel GetDueDebts(int id);
    }
}
