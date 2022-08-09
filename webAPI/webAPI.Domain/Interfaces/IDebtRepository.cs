using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Models;

namespace webAPI.Domain.Interfaces
{
    public interface IDebtRepository : IRepository<Debt>
    {
        IEnumerable<Debt> GetAllFlatDebt(int id);
        IEnumerable<Debt> GetDueDebts(int id);
    }
}
