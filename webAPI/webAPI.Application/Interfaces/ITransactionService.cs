using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.ViewModels;
using webAPI.Domain.Models;

namespace webAPI.Application.Interfaces
{
    public interface ITransactionService
    {
        public void AddTransaction(Transactions transaction);
        public void RemoveTransaction(int transactionid);
        public TransactionViewModel GetAllTransactions();
        public Transactions GetTransaction(int transactionid);
        public void UpdateTransaction(Transactions transaction);
        public TransactionViewModel GetBuildingTransactions(int id);
        public TransactionViewModel GetFlatTransactions(int id);
    }
}
