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
    public class TransactionService : ITransactionService

    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUnitOfWork _unitOfWork;
        public TransactionService(ITransactionRepository transactionRepository, IUnitOfWork unitOfWork)
        {
            _transactionRepository = transactionRepository;
            _unitOfWork = unitOfWork;
        }
        public void AddTransaction(Transaction transaction)
        {
            _transactionRepository.Add(transaction);
            _unitOfWork.complete();
        }

        public TransactionViewModel GetAllTransactions()
        {
            return new TransactionViewModel() { Transactions = _transactionRepository.GetAll() };
        }

        public TransactionViewModel GetBuildingTransactions(int id)
        {
            return new TransactionViewModel() { Transactions=_transactionRepository.GetBuildingTransactions(id) };
        }

        public TransactionViewModel GetFlatTransactions(int id)
        {
            return new TransactionViewModel() { Transactions = _transactionRepository.GetFlatTransactions(id) };
        }

        public Transaction GetTransaction(int transactionid)
        {
            return  _transactionRepository.Find(e=>e.ID==transactionid).First();
        }

        public void RemoveTransaction(int transactionid)
        {
            _transactionRepository.Remove(GetTransaction(transactionid));
            _unitOfWork.complete();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _transactionRepository.update(transaction);
            _unitOfWork.complete();
        }
    }
}
