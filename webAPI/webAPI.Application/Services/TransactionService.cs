using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Application.Interfaces;
using webAPI.Application.ViewModels;
using webAPI.Domain.Models;

namespace webAPI.Application.Services
{
    public class TransactionService : ITransactionService
    {
        public void AddTransaction(Transactions transaction)
        {
            throw new NotImplementedException();
        }

        public TransactionViewModel GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public TransactionViewModel GetBuildingTransactions(int id)
        {
            throw new NotImplementedException();
        }

        public TransactionViewModel GetFlatTransactions(int id)
        {
            throw new NotImplementedException();
        }

        public Transactions GetTransaction(int transactionid)
        {
            throw new NotImplementedException();
        }

        public void RemoveTransaction(int transactionid)
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaction(Transactions transaction)
        {
            throw new NotImplementedException();
        }
    }
}
